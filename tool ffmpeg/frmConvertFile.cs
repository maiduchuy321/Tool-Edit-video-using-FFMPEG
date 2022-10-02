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
    public partial class frmConvertFile : Form
    {
        public frmConvertFile()
        {
            InitializeComponent();
        }

        private void Inputfilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Ghi nhớ cả đường dẫn tới File sử dụng FileName
                txtInputfile.Text = openFileDialog.FileName;

                //CHỉ in ra tên file muốn xử lí không phải toàn bộ đường dẫn dùng SafeFileNam
                //SỬ dụng substring để loại bỏ phần đuôi từ sau dấu "."
                txtNameFileOutput.Text = openFileDialog.SafeFileName.Substring(0, openFileDialog.SafeFileName.LastIndexOf("."));
            }
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

        private void combineMusictoVideo_Click(object sender, EventArgs e)
        {
            string outputFileName = $@"{txtOutputFolder.Text}\{txtNameFileOutput.Text}{extensionComboBox.Text}";
            string command = $"-i \"{txtInputfile.Text}\" -c copy  \"{outputFileName}\"";

            ffmpeghandler.openFFMPEG(command);

            //Application.Exit();
        }
    }
}
