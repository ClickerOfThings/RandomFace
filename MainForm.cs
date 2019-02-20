using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace RandomFace
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Image currentImageFull = null;
        private void generate_b_Click(object sender, EventArgs e)
        {
            WebRequest req = WebRequest.Create("https://thispersondoesnotexist.com/");
            try
            {
                if (currentImageFull != null) {
                    currentImageFull.Dispose();
                }
                WebResponse resp = req.GetResponse();
                Stream str = resp.GetResponseStream();
                Image img = Image.FromStream(str);
                currentImageFull = (Image)img.Clone();
                img = new Bitmap(img, new Size(256, 256));
                generatedImg.Image = img;
                str.Dispose();
                resp.Dispose();
            }
            catch (WebException)
            {
                MessageBox.Show("Произошла ошибка при соединении с сервером...");
                return;
            }
        }

        private void link_site_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://thispersondoesnotexist.com/");
        }

        private void save_b_Click(object sender, EventArgs e)
        {
            if (generatedImg.Image != null)
            {
                int i = 0;
                while (true)
                {
                    if (File.Exists("randomface" + i + ".jpg"))
                    {
                        i++;
                    }
                    else
                    {
                        currentImageFull.Save("randomface" + i + ".jpg");
                        break;
                    }
                }
            }
        }
    }
}
