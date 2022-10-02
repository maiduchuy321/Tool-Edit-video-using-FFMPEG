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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnCombineMusictoVId_Click(object sender, EventArgs e)
        {
            Form1 frmCombineMusictoVideo = new Form1();

            frmCombineMusictoVideo.ShowDialog();
        }

        private void btnDownVid_Click(object sender, EventArgs e)
        {
            DownloadVideo frmdownloadVideo = new DownloadVideo();

            frmdownloadVideo.ShowDialog();
        }

        private void btnConvertType_Click(object sender, EventArgs e)
        {
            frmConvertFile frmConvertFile = new frmConvertFile();

            frmConvertFile.ShowDialog();
        }

        private void btnSplitVideo_Click(object sender, EventArgs e)
        {
            frmSplitVideo frmSplitVideo = new frmSplitVideo();

            frmSplitVideo.ShowDialog();
        }
    }
}
