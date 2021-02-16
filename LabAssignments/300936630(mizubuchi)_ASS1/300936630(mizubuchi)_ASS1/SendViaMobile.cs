using System.Windows.Forms;

namespace _300936630_mizubuchi__ASS1
{
    public class SendViaMobile
    {
        public string PhoneNumber { get; set; }
        public Publisher Publisher { get; set; }

        private void SendMessage(string message)
        {
            MessageBox.Show($"The message \"{message}\" has already texted to {PhoneNumber}");
        }

        public void Subscribe(Publisher publisher)
        {
            Publisher = publisher; // for notification history
            publisher.publishMsg += SendMessage;
        }

        public void Unsubscribe(Publisher pub)
        {            
            Publisher = null; // for notification history
            pub.publishMsg -= SendMessage;
        }

    }
}

