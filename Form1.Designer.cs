namespace BrowserTestApp
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.oldBrowserLabel = new System.Windows.Forms.Label();
            this.oldBrowserUrl = new System.Windows.Forms.TextBox();
            this.oldBrowserButton = new System.Windows.Forms.Button();
            this.oldBrowser = new System.Windows.Forms.WebBrowser();
            this.newBrowserButton = new System.Windows.Forms.Button();
            this.newBrowserUrl = new System.Windows.Forms.TextBox();
            this.newBrowserLabel = new System.Windows.Forms.Label();
            this.newBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.oldBrowser);
            this.splitContainer1.Panel1.Controls.Add(this.oldBrowserButton);
            this.splitContainer1.Panel1.Controls.Add(this.oldBrowserUrl);
            this.splitContainer1.Panel1.Controls.Add(this.oldBrowserLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.newBrowser);
            this.splitContainer1.Panel2.Controls.Add(this.newBrowserButton);
            this.splitContainer1.Panel2.Controls.Add(this.newBrowserUrl);
            this.splitContainer1.Panel2.Controls.Add(this.newBrowserLabel);
            this.splitContainer1.Size = new System.Drawing.Size(800, 695);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 0;
            // 
            // oldBrowserLabel
            // 
            this.oldBrowserLabel.AutoSize = true;
            this.oldBrowserLabel.Location = new System.Drawing.Point(3, 8);
            this.oldBrowserLabel.Name = "oldBrowserLabel";
            this.oldBrowserLabel.Size = new System.Drawing.Size(183, 13);
            this.oldBrowserLabel.TabIndex = 0;
            this.oldBrowserLabel.Text = "System.Windows.Forms.WebBrowser";
            // 
            // oldBrowserUrl
            // 
            this.oldBrowserUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldBrowserUrl.Location = new System.Drawing.Point(192, 6);
            this.oldBrowserUrl.Name = "oldBrowserUrl";
            this.oldBrowserUrl.Size = new System.Drawing.Size(524, 20);
            this.oldBrowserUrl.TabIndex = 1;
            this.oldBrowserUrl.Text = "https://www.whatismybrowser.com/";
            this.oldBrowserUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.oldBrowserUrl_KeyUp);
            // 
            // oldBrowserButton
            // 
            this.oldBrowserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oldBrowserButton.Location = new System.Drawing.Point(722, 3);
            this.oldBrowserButton.Name = "oldBrowserButton";
            this.oldBrowserButton.Size = new System.Drawing.Size(75, 23);
            this.oldBrowserButton.TabIndex = 2;
            this.oldBrowserButton.Text = "Navigate";
            this.oldBrowserButton.UseVisualStyleBackColor = true;
            this.oldBrowserButton.Click += new System.EventHandler(this.oldBrowserButton_Click);
            // 
            // oldBrowser
            // 
            this.oldBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldBrowser.Location = new System.Drawing.Point(3, 32);
            this.oldBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.oldBrowser.Name = "oldBrowser";
            this.oldBrowser.Size = new System.Drawing.Size(794, 311);
            this.oldBrowser.TabIndex = 3;
            // 
            // newBrowserButton
            // 
            this.newBrowserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newBrowserButton.Location = new System.Drawing.Point(722, 3);
            this.newBrowserButton.Name = "newBrowserButton";
            this.newBrowserButton.Size = new System.Drawing.Size(75, 23);
            this.newBrowserButton.TabIndex = 6;
            this.newBrowserButton.Text = "Navigate";
            this.newBrowserButton.UseVisualStyleBackColor = true;
            this.newBrowserButton.Click += new System.EventHandler(this.newBrowserButton_Click);
            // 
            // newBrowserUrl
            // 
            this.newBrowserUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newBrowserUrl.Location = new System.Drawing.Point(245, 5);
            this.newBrowserUrl.Name = "newBrowserUrl";
            this.newBrowserUrl.Size = new System.Drawing.Size(471, 20);
            this.newBrowserUrl.TabIndex = 5;
            this.newBrowserUrl.Text = "https://www.whatismybrowser.com/";
            this.newBrowserUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.newBrowserUrl_KeyUp);
            // 
            // newBrowserLabel
            // 
            this.newBrowserLabel.AutoSize = true;
            this.newBrowserLabel.Location = new System.Drawing.Point(3, 8);
            this.newBrowserLabel.Name = "newBrowserLabel";
            this.newBrowserLabel.Size = new System.Drawing.Size(236, 13);
            this.newBrowserLabel.TabIndex = 4;
            this.newBrowserLabel.Text = "Microsoft.Web.WebView2.WinForms.WebView2";
            // 
            // newBrowser
            // 
            this.newBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newBrowser.CreationProperties = null;
            this.newBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.newBrowser.Location = new System.Drawing.Point(6, 32);
            this.newBrowser.Name = "newBrowser";
            this.newBrowser.Size = new System.Drawing.Size(791, 314);
            this.newBrowser.TabIndex = 7;
            this.newBrowser.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 695);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Test old and new Browser Controls App";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser oldBrowser;
        private System.Windows.Forms.Button oldBrowserButton;
        private System.Windows.Forms.TextBox oldBrowserUrl;
        private System.Windows.Forms.Label oldBrowserLabel;
        private System.Windows.Forms.Button newBrowserButton;
        private System.Windows.Forms.TextBox newBrowserUrl;
        private System.Windows.Forms.Label newBrowserLabel;
        private Microsoft.Web.WebView2.WinForms.WebView2 newBrowser;
    }
}

