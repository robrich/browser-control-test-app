using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserTestApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void oldBrowserButton_Click(object sender, EventArgs e)
        {
            // TODO: validate url starts with http or at least isn't blank
            this.oldBrowser.Navigate(this.oldBrowserUrl.Text);
            // TODO: try/catch in case navigating doesn't work
        }

        private void oldBrowserUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.oldBrowserButton_Click(sender, e);
            }
        }

        private void newBrowserButton_Click(object sender, EventArgs e)
        {
            // TODO: validate url starts with http or at least isn't blank
            this.newBrowser.Source = new Uri(this.newBrowserUrl.Text);
            // TODO: try/catch in case navigating doesn't work
        }

        private void newBrowserUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.newBrowserButton_Click(sender, e);
            }
        }

    }
}
