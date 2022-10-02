using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tool_ffmpeg
{
    public partial class DownloadVideo : Form
    {
        public DownloadVideo()
        {
            InitializeComponent();
        }

        private void Outputfilebtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Environment.CurrentDirectory;
            folderBrowserDialog.ShowNewFolderButton = true;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnDownVid_Click(object sender, EventArgs e)
        {
            string outputFileName = $@"{txtOutputFolder.Text}\{txtNameFileOutput.Text}{extensionComboBox.Text}";
            string command = $"\"{txtInputfile.Text}\" -f \"bv*[ext=mp4]+ba[ext=m4a]/b[ext=mp4]/bv*+ba/b\"  -o \"{outputFileName}\"";

            ffmpeghandler.openYTDLP(command);

            Application.Exit();
            MessageBox.Show("Download Complete");

        }

        private void btnDownloadm3u8_Click(object sender, EventArgs e)
        {
            string outputFileName = $@"{txtOutputFolder.Text}\{txtNameFileOutput.Text}{extensionComboBox.Text}";
            string command = $"-i \"{txtInputfile.Text}\" -bsf:a aac_adtstoasc -vcodec copy -c copy -crf 50  \"{outputFileName}\"";
            string m3u8 = txtInputfile.Text.Substring(txtInputfile.Text.Length-5, 5);
            if (m3u8 == ".m3u8")
            {
                ffmpeghandler.openFFMPEG(command);

                Application.Exit();
                MessageBox.Show("Download Complete");

            }
            else
            {
                MessageBox.Show("Plese enter the link .m3u8");
            }
        }
    }
}
