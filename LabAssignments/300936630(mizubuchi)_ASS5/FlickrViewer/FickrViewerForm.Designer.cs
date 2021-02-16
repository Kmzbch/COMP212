namespace FlickrViewer
{
   partial class FickrViewerForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.imagesListBox = new System.Windows.Forms.ListBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.tbxWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbxHeight = new System.Windows.Forms.TextBox();
            this.lblRatio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Flickr search tags here:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.Location = new System.Drawing.Point(326, 25);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(578, 31);
            this.inputTextBox.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(326, 77);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(578, 1004);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(956, 21);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(303, 44);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // imagesListBox
            // 
            this.imagesListBox.FormattingEnabled = true;
            this.imagesListBox.ItemHeight = 25;
            this.imagesListBox.Location = new System.Drawing.Point(30, 77);
            this.imagesListBox.Margin = new System.Windows.Forms.Padding(6);
            this.imagesListBox.Name = "imagesListBox";
            this.imagesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.imagesListBox.Size = new System.Drawing.Size(280, 1004);
            this.imagesListBox.TabIndex = 5;
            this.imagesListBox.SelectedIndexChanged += new System.EventHandler(this.imagesListBox_SelectedIndexChanged);
            // 
            // btnResize
            // 
            this.btnResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResize.Enabled = false;
            this.btnResize.Location = new System.Drawing.Point(956, 286);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(303, 81);
            this.btnResize.TabIndex = 6;
            this.btnResize.Text = "Save Resized Images";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // tbxWidth
            // 
            this.tbxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxWidth.Enabled = false;
            this.tbxWidth.Location = new System.Drawing.Point(1048, 95);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(211, 31);
            this.tbxWidth.TabIndex = 7;
            this.tbxWidth.Leave += new System.EventHandler(this.tbxWidth_Leave);
            // 
            // lblWidth
            // 
            this.lblWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(951, 95);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(67, 25);
            this.lblWidth.TabIndex = 9;
            this.lblWidth.Text = "Width";
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(951, 157);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(74, 25);
            this.lblHeight.TabIndex = 10;
            this.lblHeight.Text = "Height";
            // 
            // tbxHeight
            // 
            this.tbxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHeight.Enabled = false;
            this.tbxHeight.Location = new System.Drawing.Point(1048, 157);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(211, 31);
            this.tbxHeight.TabIndex = 11;
            this.tbxHeight.Leave += new System.EventHandler(this.tbxHeight_Leave);
            // 
            // lblRatio
            // 
            this.lblRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRatio.AutoSize = true;
            this.lblRatio.Location = new System.Drawing.Point(1196, 221);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(48, 25);
            this.lblRatio.TabIndex = 12;
            this.lblRatio.Text = "100";
            this.lblRatio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(951, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Resize rate";
            // 
            // FickrViewerForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 1120);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRatio);
            this.Controls.Add(this.tbxHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.tbxWidth);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.imagesListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FickrViewerForm";
            this.Text = "Flickr Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox inputTextBox;
      private System.Windows.Forms.PictureBox pictureBox;
      private System.Windows.Forms.Button searchButton;
      private System.Windows.Forms.ListBox imagesListBox;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.TextBox tbxWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox tbxHeight;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.Label label2;
    }
}

