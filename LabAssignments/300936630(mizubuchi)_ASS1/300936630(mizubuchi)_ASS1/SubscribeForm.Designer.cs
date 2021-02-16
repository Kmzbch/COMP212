namespace _300936630_mizubuchi__ASS1
{
    partial class SubscribeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkPhoneNumber = new System.Windows.Forms.CheckBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errEmailAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errEmailAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(58, 87);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(270, 29);
            this.chkEmail.TabIndex = 1;
            this.chkEmail.Text = "Message Sent by Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            this.chkEmail.CheckedChanged += new System.EventHandler(this.chkEmailAddress_CheckedChanged);
            // 
            // chkPhoneNumber
            // 
            this.chkPhoneNumber.AutoSize = true;
            this.chkPhoneNumber.Location = new System.Drawing.Point(58, 175);
            this.chkPhoneNumber.Name = "chkPhoneNumber";
            this.chkPhoneNumber.Size = new System.Drawing.Size(281, 29);
            this.chkPhoneNumber.TabIndex = 3;
            this.chkPhoneNumber.Text = "Message Sent by Mobile";
            this.chkPhoneNumber.UseVisualStyleBackColor = true;
            this.chkPhoneNumber.CheckedChanged += new System.EventHandler(this.chkPhoneNumber_CheckedChanged);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Enabled = false;
            this.txtEmailAddress.Location = new System.Drawing.Point(367, 84);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(381, 31);
            this.txtEmailAddress.TabIndex = 2;
            this.txtEmailAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(367, 173);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(381, 31);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber_Validating);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Enabled = false;
            this.btnSubscribe.Location = new System.Drawing.Point(58, 294);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(160, 56);
            this.btnSubscribe.TabIndex = 5;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.Enabled = false;
            this.btnUnsubscribe.Location = new System.Drawing.Point(323, 294);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(160, 56);
            this.btnUnsubscribe.TabIndex = 6;
            this.btnUnsubscribe.Text = "Unsubscribe";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            this.btnUnsubscribe.Click += new System.EventHandler(this.btnUnsubscribe_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(588, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 55);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errEmailAddress
            // 
            this.errEmailAddress.ContainerControl = this;
            // 
            // errPhoneNumber
            // 
            this.errPhoneNumber.ContainerControl = this;
            // 
            // SubscribeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUnsubscribe);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.chkPhoneNumber);
            this.Controls.Add(this.chkEmail);
            this.Name = "SubscribeForm";
            this.Text = "Subscribe Form";
            ((System.ComponentModel.ISupportInitialize)(this.errEmailAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhoneNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkPhoneNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnUnsubscribe;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errEmailAddress;
        private System.Windows.Forms.ErrorProvider errPhoneNumber;
    }
}