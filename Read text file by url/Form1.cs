using System;
using System.Net;
using System.Windows.Forms;

namespace Read_text_file_by_url
{
    public partial class frm_read_text_by_url : Form
    {
        public frm_read_text_by_url()
        {
            InitializeComponent();
        }

        private void get_Click(object sender, EventArgs e)
        {
            var client = new WebClient { Encoding = System.Text.Encoding.UTF8 };
            try
            {
                var json = client.DownloadString(text_url.Text);
                text_read.Text = json;
            }
            catch
            {
                text_read.Text = "Error in receiving information";
            }
        }

        private void btn_creator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AliPlvP.ir","App");
        }
    }
}
