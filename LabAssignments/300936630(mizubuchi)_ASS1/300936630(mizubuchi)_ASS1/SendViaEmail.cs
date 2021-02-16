using System.Windows.Forms;

namespace _300936630_mizubuchi__ASS1
{
    public class SendViaEmail
    {
        public string EmailAddress { get; set; }
        public Publisher Publisher { get; set; }

        public void SendEmail(string message)
        {
            object x = this;
            MessageBox.Show($"The message \"{message}\" has already sent to {EmailAddress}");
        }

        public void Subscribe(Publisher publisher)
        {
            Publisher = publisher; // for notification history
            publisher.publishMsg += SendEmail;
        }

        public void Unsubscribe(Publisher publisher)
        {
            Publisher = null; // for notification history
            publisher.publishMsg -= SendEmail;
        }

    }
}

