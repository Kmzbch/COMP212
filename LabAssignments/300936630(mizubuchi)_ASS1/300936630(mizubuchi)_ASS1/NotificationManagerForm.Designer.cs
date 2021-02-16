namespace _300936630_mizubuchi__ASS1
{
    partial class NotificationManagerForm
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
            this.btnManageSubscription = new System.Windows.Forms.Button();
            this.btnPublishNotification = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageSubscription
            // 
            this.btnManageSubscription.Location = new System.Drawing.Point(45, 57);
            this.btnManageSubscription.Name = "btnManageSubscription";
            this.btnManageSubscription.Size = new System.Drawing.Size(186, 78);
            this.btnManageSubscription.TabIndex = 0;
            this.btnManageSubscription.Text = "Manage Subscription";
            this.btnManageSubscription.UseVisualStyleBackColor = true;
            this.btnManageSubscription.Click += new System.EventHandler(this.btnManageSubscription_Click);
            // 
            // btnPublishNotification
            // 
            this.btnPublishNotification.Location = new System.Drawing.Point(287, 57);
            this.btnPublishNotification.Name = "btnPublishNotification";
            this.btnPublishNotification.Size = new System.Drawing.Size(186, 78);
            this.btnPublishNotification.TabIndex = 1;
            this.btnPublishNotification.Text = "Publish Notification";
            this.btnPublishNotification.UseVisualStyleBackColor = true;
            this.btnPublishNotification.Click += new System.EventHandler(this.btnPublishNotification_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(526, 57);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 78);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NotificationManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 194);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPublishNotification);
            this.Controls.Add(this.btnManageSubscription);
            this.Name = "NotificationManagerForm";
            this.Text = "Notification Manager";
            this.VisibleChanged += new System.EventHandler(this.NotificationManagerForm_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageSubscription;
        private System.Windows.Forms.Button btnPublishNotification;
        private System.Windows.Forms.Button btnExit;
    }
}

