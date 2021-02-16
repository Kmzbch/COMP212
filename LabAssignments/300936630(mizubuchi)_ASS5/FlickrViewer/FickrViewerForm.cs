// FickrViewerForm.cs
// Invoking a web service asynchronously with class HttpClient
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FlickrViewer
{
    public partial class FickrViewerForm : Form
    {
        // Use your Flickr API key here--you can get one at:
        // https://www.flickr.com/services/apps/create/apply
              private const string KEY = "a7e6b211862785ce584b1994bc84fa06";
        //        private const string KEY = "471777749ff7e55efe3abb50b9882185";

        // api key
//        private const string KEY = "dd53c0b45840222cf1f8fe5f17262427";

        // object used to invoke Flickr web service      
        private static HttpClient flickrClient = new HttpClient();

        Task<string> flickrTask = null; // Task<string> that queries Flickr

        const string FOLDER_PATH = "../../../ResizedImages";

        public FickrViewerForm()
        {
            InitializeComponent();

            // clean images directory
            if (Directory.Exists(FOLDER_PATH))
                Directory.Delete(FOLDER_PATH, true);
        }

        // initiate asynchronous Flickr search query; 
        // display results when query completes
        private async void searchButton_Click(object sender, EventArgs e)
        {
            // if flickrTask already running, prompt user 
            if (flickrTask?.Status != TaskStatus.RanToCompletion)
            {
                var result = MessageBox.Show(
                   "Cancel the current Flickr search?",
                   "Are you sure?", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

                // determine whether user wants to cancel prior search
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    flickrClient.CancelPendingRequests(); // cancel search
                }
            }

            // Flickr's web service URL for searches                         
            var flickrURL = "https://api.flickr.com/services/rest/?method=" +
               $"flickr.photos.search&api_key={KEY}&" +
               $"tags={inputTextBox.Text.Replace(" ", ",")}" +
               "&tag_mode=all&per_page=500&privacy_filter=1";

            imagesListBox.DataSource = null; // remove prior data source
            imagesListBox.Items.Clear(); // clear imagesListBox
            pictureBox.Image = null; // clear pictureBox
            imagesListBox.Items.Add("Loading..."); // display Loading...

            // invoke Flickr web service to search Flick with user's tags
            flickrTask = flickrClient.GetStringAsync(flickrURL);

            // await flickrTask then parse results with XDocument and LINQ
            XDocument flickrXML = XDocument.Parse(await flickrTask);

            // gather information on all photos
            var flickrPhotos =
               from photo in flickrXML.Descendants("photo")
               let id = photo.Attribute("id").Value
               let title = photo.Attribute("title").Value
               let secret = photo.Attribute("secret").Value
               let server = photo.Attribute("server").Value
               let farm = photo.Attribute("farm").Value
               select new FlickrResult
               {
                   Title = title,
                   URL = $"https://farm{farm}.staticflickr.com/" +
                     $"{server}/{id}_{secret}.jpg"
               };
            imagesListBox.Items.Clear(); // clear imagesListBox

            // set ListBox properties only if results were found
            if (flickrPhotos.Any())
            {
                imagesListBox.DataSource = flickrPhotos.ToList();
                imagesListBox.DisplayMember = "Title";
            }
            else // no matches were found
            {
                imagesListBox.Items.Add("No matches");
            }

            // enable resize
            tbxWidth.Enabled = true;
            tbxHeight.Enabled = true;
            btnResize.Enabled = true;
        }

        // display selected image
        private async void imagesListBox_SelectedIndexChanged(
           object sender, EventArgs e)
        {
            if (imagesListBox.SelectedItem != null)
            {
                string selectedURL = ((FlickrResult)imagesListBox.SelectedItem).URL;

                // use HttpClient to get selected image's bytes asynchronously
                byte[] imageBytes = await flickrClient.GetByteArrayAsync(selectedURL);

                // display downloaded image in pictureBox                  
                using (var memoryStream = new MemoryStream(imageBytes))
                {
                    pictureBox.Image = Image.FromStream(memoryStream);
                };

                CalculateHeight(pictureBox.Image.Width);
            }

        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            // exception handling
            try
            {
                int.Parse(tbxWidth.Text);
                int.Parse(tbxHeight.Text);
            }
            catch
            {
                MessageBox.Show("String is not allowed");
                return;
            }
            if (imagesListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("No images selected");
                return;
            }

            if (int.Parse(tbxHeight.Text) < 0 || int.Parse(tbxWidth.Text) < 0)
            {
                MessageBox.Show("Negative values not allowed");
                return;
            }

            // get aspect ratio            
            double rate = double.Parse(lblRatio.Text.Trim('%')) / 100;

            // create folder to save files
            string targetFolder = FOLDER_PATH + "/" + inputTextBox.Text;
            Directory.CreateDirectory(FOLDER_PATH);
            Directory.CreateDirectory(targetFolder);

            //            Parallel.ForEach(imagesListBox.Items.Cast<FlickrResult>(), async (current) =>
            Parallel.ForEach(imagesListBox.SelectedItems.Cast<FlickrResult>(), async (current) =>
            {
                // get filename without extention from url
                string filename = current.URL.Split('/').Last().Split('.').FirstOrDefault();

                try
                {
                    byte[] imageBytes = await flickrClient.GetByteArrayAsync(current.URL);

                    using (var stream = new MemoryStream(imageBytes))
                    {
                        var image = Image.FromStream(stream);
                        var resized_width = (int)(image.Width * rate);
                        var resized_height = (int)(image.Height * rate);
                        var thumbnail = image.GetThumbnailImage(resized_width, resized_height, null, IntPtr.Zero);

                        thumbnail.Save(targetFolder + "/" + filename + "_resized.jpg", ImageFormat.Jpeg);
                    }
                }
                catch (HttpRequestException ex)
                {
                    System.Diagnostics.Debug.WriteLine("CAUGHT EXCEPTION:");
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            });
        }

        // autofil of width and height
        private void CalculateHeight(double width)
        {
            var image = pictureBox.Image;
            var height = (width * image.Height) / image.Width;

            // keep aspect ration
            tbxHeight.Text = ((int)height).ToString();
            tbxWidth.Text = ((int)width).ToString();

            double ratio = double.Parse(tbxWidth.Text) / image.Width;
            lblRatio.Text = $"{ratio:P0}";
        }

        private void CalculateWidth(double height)
        {
            var image = pictureBox.Image;
            var width = (height * image.Width) / image.Height;

            // keep aspect ratio
            tbxWidth.Text = ((int)width).ToString();
            tbxHeight.Text = ((int)height).ToString();

            double ratio = double.Parse(tbxHeight.Text) / image.Height;
            lblRatio.Text = $"{ratio:P0}";
        }

        private void tbxWidth_Leave(object sender, EventArgs e)
        {
            try
            {
                int.Parse(tbxWidth.Text);
            }
            catch
            {
                MessageBox.Show("String is not allowed");
                return;
            }

            if (tbxWidth.Text == "" || tbxWidth.Text == "0")
                tbxWidth.Text = "1";
            CalculateHeight(int.Parse(tbxWidth.Text));
        }

        private void tbxHeight_Leave(object sender, EventArgs e)
        {
            try
            {
                int.Parse(tbxHeight.Text);
            }
            catch
            {
                MessageBox.Show("String is not allowed");
                return;
            }
        
            if (tbxHeight.Text == "" || tbxHeight.Text == "0")
                tbxHeight.Text = "1";
            CalculateWidth(int.Parse(tbxHeight.Text));
        }
    }
}

