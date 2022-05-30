using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPreglednik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnGo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUrl.Text) || txtUrl.Text.Equals("about:blank"))
            {
                MessageBox.Show("Enter URL!","Empty URL", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtUrl.Focus();
                return;
            }
            OpenURLInBrowser(txtUrl.Text);

            
        }

        private void OpenURLInBrowser(string url)
        {

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }

            try
            {
                webBrowser.Navigate(new Uri(url));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void tsbtnHome_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(new Uri("https://google.com"));
        }

        private void tsbtnBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void tsbtnForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }


        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
