using System;
using System.Windows.Forms;

namespace _300936630_mizubuchi__ASS1
{
    public partial class NotificationManagerForm : Form
    {
        private Publisher publisher = new Publisher();

        public NotificationManagerForm()
        {
            InitializeComponent();
        }

        private void btnManageSubscription_Click(object sender, EventArgs e)
        {
            Form subscribeForm = new SubscribeForm(publisher);
            subscribeForm.Show(this);
            this.Hide();
        }

        private void btnPublishNotification_Click(object sender, EventArgs e)
        {
            Form publishNotificationForm = new PublishNotificationForm(publisher);
            publishNotificationForm.Show(this);
            this.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotificationManagerForm_VisibleChanged(object sender, EventArgs e)
        {
            if (publisher.ReadersViaEmail.Count > 0 || publisher.ReadersViaMobile.Count > 0)
            {
                btnPublishNotification.Enabled = true;
            }
            else
            {
                btnPublishNotification.Enabled = false;
            }
        }

    }
}
