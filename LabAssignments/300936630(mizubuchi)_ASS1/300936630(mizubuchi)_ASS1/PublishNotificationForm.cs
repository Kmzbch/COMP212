using System;
using System.Windows.Forms;

namespace _300936630_mizubuchi__ASS1
{
    public partial class PublishNotificationForm : Form
    {
        private Publisher publisher;

        public PublishNotificationForm(Publisher publisher)
        {
            this.publisher = publisher;
            InitializeComponent();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            try
            {
                publisher.PublishMessage(txtNotificationContent.Text);
                MessageBox.Show("The message has been sent to all the subscribers!");
            }
            catch
            {
                MessageBox.Show("No subscribers currently!");
            }

            this.Owner.Show();
            this.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

    }
}
