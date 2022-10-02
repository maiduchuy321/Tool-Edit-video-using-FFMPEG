
namespace tool_ffmpeg
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
            this.combineMusictoVideo = new DevExpress.XtraEditors.SimpleButton();
            this.Inputfilebtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Outputfilebtn = new DevExpress.XtraEditors.SimpleButton();
            this.Input = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.extensionComboBox = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.inputMusicbtn = new DevExpress.XtraEditors.SimpleButton();
            this.txtInputfile = new System.Windows.Forms.TextBox();
            this.txtInputMusic = new System.Windows.Forms.TextBox();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.txtNameFileOutput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extensiton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // combineMusictoVideo
            // 
            this.combineMusictoVideo.Location = new System.Drawing.Point(143, 359);
            this.combineMusictoVideo.Margin = new System.Windows.Forms.Padding(6);
            this.combineMusictoVideo.Name = "combineMusictoVideo";
            this.combineMusictoVideo.Size = new System.Drawing.Size(241, 45);
            this.combineMusictoVideo.TabIndex = 0;
            this.combineMusictoVideo.Text = "Combine music to video";
            this.combineMusictoVideo.Click += new System.EventHandler(this.combineMusictoVideo_Click);
            // 
            // Inputfilebtn
            // 
            this.Inputfilebtn.Location = new System.Drawing.Point(637, 121);
            this.Inputfilebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Inputfilebtn.Name = "Inputfilebtn";
            this.Inputfilebtn.Size = new System.Drawing.Size(94, 29);
            this.Inputfilebtn.TabIndex = 2;
            this.Inputfilebtn.Text = "Browse...";
            this.Inputfilebtn.Click += new System.EventHandler(this.Inputfilebtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Coral;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(158, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(471, 56);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Combine music to video";
            // 
            // Outputfilebtn
            // 
            this.Outputfilebtn.Location = new System.Drawing.Point(639, 267);
            this.Outputfilebtn.Margin = new System.Windows.Forms.Padding(5);
            this.Outputfilebtn.Name = "Outputfilebtn";
            this.Outputfilebtn.Size = new System.Drawing.Size(94, 28);
            this.Outputfilebtn.TabIndex = 5;
            this.Outputfilebtn.Text = "Browse...";
            this.Outputfilebtn.Click += new System.EventHandler(this.Outputfilebtn_Click);
            // 
            // Input
            // 
            this.Input.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Appearance.Options.UseFont = true;
            this.Input.Location = new System.Drawing.Point(66, 80);
            this.Input.Margin = new System.Windows.Forms.Padding(4);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(106, 29);
            this.Input.TabIndex = 6;
            this.Input.Text = "Input Video:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(66, 230);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 29);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Output:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(66, 318);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 29);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Name file:";
            // 
            // extensionComboBox
            // 
            this.extensionComboBox.FormattingEnabled = true;
            this.extensionComboBox.Items.AddRange(new object[] {
            ".mp4",
            ".flv",
            ".mpeg"});
            this.extensionComboBox.Location = new System.Drawing.Point(639, 326);
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.Size = new System.Drawing.Size(94, 24);
            this.extensionComboBox.TabIndex = 11;
            this.extensionComboBox.Text = ".mp4";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(66, 154);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(108, 29);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Input Music:";
            // 
            // inputMusicbtn
            // 
            this.inputMusicbtn.Location = new System.Drawing.Point(637, 195);
            this.inputMusicbtn.Margin = new System.Windows.Forms.Padding(4);
            this.inputMusicbtn.Name = "inputMusicbtn";
            this.inputMusicbtn.Size = new System.Drawing.Size(94, 29);
            this.inputMusicbtn.TabIndex = 13;
            this.inputMusicbtn.Text = "Browse...";
            this.inputMusicbtn.Click += new System.EventHandler(this.inputMusicbtn_Click);
            // 
            // txtInputfile
            // 
            this.txtInputfile.Location = new System.Drawing.Point(65, 122);
            this.txtInputfile.Name = "txtInputfile";
            this.txtInputfile.Size = new System.Drawing.Size(563, 22);
            this.txtInputfile.TabIndex = 15;
            // 
            // txtInputMusic
            // 
            this.txtInputMusic.Location = new System.Drawing.Point(66, 195);
            this.txtInputMusic.Name = "txtInputMusic";
            this.txtInputMusic.Size = new System.Drawing.Size(562, 22);
            this.txtInputMusic.TabIndex = 16;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(68, 270);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(563, 22);
            this.txtOutputFolder.TabIndex = 17;
            // 
            // txtNameFileOutput
            // 
            this.txtNameFileOutput.Location = new System.Drawing.Point(169, 325);
            this.txtNameFileOutput.Name = "txtNameFileOutput";
            this.txtNameFileOutput.Size = new System.Drawing.Size(460, 22);
            this.txtNameFileOutput.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Name,
            this.Dic,
            this.NewName,
            this.Extensiton,
            this.Process});
            this.dataGridView1.Location = new System.Drawing.Point(12, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(784, 190);
            this.dataGridView1.TabIndex = 19;
            // 
            // Number
            // 
            this.Number.HeaderText = "Thứ tự";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Tên";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Dic
            // 
            this.Dic.HeaderText = "Đường dẫn";
            this.Dic.MinimumWidth = 6;
            this.Dic.Name = "Dic";
            this.Dic.Width = 125;
            // 
            // NewName
            // 
            this.NewName.HeaderText = "Tên mới";
            this.NewName.MinimumWidth = 6;
            this.NewName.Name = "NewName";
            this.NewName.Width = 125;
            // 
            // Extensiton
            // 
            this.Extensiton.HeaderText = "Đuôi file";
            this.Extensiton.MinimumWidth = 6;
            this.Extensiton.Name = "Extensiton";
            this.Extensiton.Width = 125;
            // 
            // Process
            // 
            this.Process.HeaderText = "Tiến trình";
            this.Process.MinimumWidth = 6;
            this.Process.Name = "Process";
            this.Process.Width = 125;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(460, 376);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(271, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNameFileOutput);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.txtInputMusic);
            this.Controls.Add(this.txtInputfile);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.inputMusicbtn);
            this.Controls.Add(this.extensionComboBox);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Outputfilebtn);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Inputfilebtn);
            this.Controls.Add(this.combineMusictoVideo);
            //this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton combineMusictoVideo;
        private DevExpress.XtraEditors.SimpleButton Inputfilebtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton Outputfilebtn;
        private DevExpress.XtraEditors.LabelControl Input;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox extensionComboBox;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton inputMusicbtn;
        private System.Windows.Forms.TextBox txtInputfile;
        private System.Windows.Forms.TextBox txtInputMusic;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.TextBox txtNameFileOutput;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dic;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extensiton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

