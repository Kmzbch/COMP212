using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _300936630_mizubuchi__ASS1
{
    public partial class SubscribeForm : Form
    {
        private Publisher publisher;
        private SendViaEmail readerViaEmail;
        private SendViaMobile readerViaMobile;

        public SubscribeForm(Publisher publisher)
        {
            this.publisher = publisher;
            InitializeComponent();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            ValidateSubscribeForm();

            if (!String.IsNullOrEmpty(txtEmailAddress.Text))
            {
                readerViaEmail = new SendViaEmail() { EmailAddress = txtEmailAddress.Text };

                if (publisher.ReadersViaEmail.Exists(
                    x => x.EmailAddress == readerViaEmail.EmailAddress))
                {
                    MessageBox.Show($"{readerViaEmail.EmailAddress} is already subscribed!");
                }
                else
                {
                    publisher.ReadersViaEmail.Add(readerViaEmail);
                    readerViaEmail.Subscribe(publisher);
                    MessageBox.Show($"{readerViaEmail.EmailAddress} has subscribed!");
                }
            }

            if (!String.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                readerViaMobile = new SendViaMobile() { PhoneNumber = txtPhoneNumber.Text };

                if (publisher.ReadersViaMobile.Exists(
                    x => x.PhoneNumber == readerViaMobile.PhoneNumber))
                {
                    MessageBox.Show($"{readerViaMobile.PhoneNumber} is already subscribed!");
                }
                else
                {
                    publisher.ReadersViaMobile.Add(readerViaMobile);
                    readerViaMobile.Subscribe(publisher);
                    MessageBox.Show($"{readerViaMobile.PhoneNumber} has subscribed!");
                }
            }

            this.Owner.Show();
            this.Close();

        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            ValidateSubscribeForm();

            if (!String.IsNullOrEmpty(txtEmailAddress.Text))
            {
                if (publisher.ReadersViaEmail.Exists(
                    x => x.EmailAddress == txtEmailAddress.Text))
                {
                    readerViaEmail = publisher.ReadersViaEmail.Find(x => x.EmailAddress == txtEmailAddress.Text);
                    publisher.ReadersViaEmail.Remove(readerViaEmail);
                    readerViaEmail.Unsubscribe(publisher);
                    MessageBox.Show($"{txtEmailAddress.Text} has unsubscribed!");
                }
                else
                {
                    MessageBox.Show($"{txtEmailAddress.Text} is not subscribed yet!");
                }
            }

            if (!String.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                if (publisher.ReadersViaMobile.Exists(
                    x => x.PhoneNumber == txtPhoneNumber.Text))
                {
                    readerViaMobile = publisher.ReadersViaMobile.Find(
                        x => x.PhoneNumber == txtPhoneNumber.Text);
                    publisher.ReadersViaMobile.Remove(readerViaMobile);
                    readerViaMobile.Unsubscribe(publisher);
                    MessageBox.Show($"{txtPhoneNumber.Text} has unsubscribed!");
                }
                else
                {
                    MessageBox.Show($"{txtPhoneNumber.Text} is not subscribed yet!");
                }
            }

            this.Owner.Show();
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidEmail(txtEmailAddress.Text))
            {
                errEmailAddress.SetError(txtEmailAddress, "");
            }
            else
            {
                errEmailAddress.SetError(txtEmailAddress, "Enter valid Email address");
            }

            ValidateSubscribeForm();

        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidPhoneNumber(txtPhoneNumber.Text))
            {
                errPhoneNumber.SetError(txtPhoneNumber, "");
            }
            else
            {
                errPhoneNumber.SetError(txtPhoneNumber, "Enter valid phone number");
            }

            ValidateSubscribeForm();

        }

        private void chkEmailAddress_CheckedChanged(object sender, EventArgs e)
        {
            txtEmailAddress.Enabled = chkEmail.Checked;
            ValidateSubscribeForm();
        }

        private void chkPhoneNumber_CheckedChanged(object sender, EventArgs e)
        {
            txtPhoneNumber.Enabled = chkPhoneNumber.Checked;
            ValidateSubscribeForm();
        }

        private void ValidateSubscribeForm()
        {
            bool hasValidEmail = chkEmail.Checked && IsValidEmail(txtEmailAddress.Text);
            bool hasValidPhoneNumber = chkPhoneNumber.Checked && IsValidPhoneNumber(txtPhoneNumber.Text);

            if(chkEmail.Checked && !IsValidEmail(txtEmailAddress.Text)
                || chkPhoneNumber.Checked && !IsValidPhoneNumber(txtPhoneNumber.Text)
                )
            {
                btnSubscribe.Enabled = false;
                btnUnsubscribe.Enabled = false;
            }
            else
            {
                if (hasValidEmail || hasValidPhoneNumber)
                {
                    btnSubscribe.Enabled = true;
                    btnUnsubscribe.Enabled = true;
                }
                else
                {
                    btnSubscribe.Enabled = false;
                    btnUnsubscribe.Enabled = false;
                }
            }
        }

        // for email-address validation instead of regex
        private bool IsValidEmail(string text)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(text);
                return addr.Address == text;
            }
            catch
            {
                return false;
            }
        }

        // using regex for phone number validation
        private bool IsValidPhoneNumber(string text)
        {
            const string validPhonePattern = @"^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$";

            Regex validPhoneRegex = new Regex(validPhonePattern);

            return validPhoneRegex.IsMatch(text);

        }


    }
}
