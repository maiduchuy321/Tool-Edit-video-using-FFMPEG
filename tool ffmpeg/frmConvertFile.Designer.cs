
namespace tool_ffmpeg
{
    partial class frmConvertFile
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtNameFileOutput = new System.Windows.Forms.TextBox();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.txtInputfile = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.extensionComboBox = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Input = new DevExpress.XtraEditors.LabelControl();
            this.Outputfilebtn = new DevExpress.XtraEditors.SimpleButton();
            this.Inputfilebtn = new DevExpress.XtraEditors.SimpleButton();
            this.combineMusictoVideo = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Coral;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(266, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(278, 41);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Convert Video";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(461, 359);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(271, 23);
            this.progressBar1.TabIndex = 34;
            // 
            // txtNameFileOutput
            // 
            this.txtNameFileOutput.Location = new System.Drawing.Point(168, 277);
            this.txtNameFileOutput.Name = "txtNameFileOutput";
            this.txtNameFileOutput.Size = new System.Drawing.Size(460, 22);
            this.txtNameFileOutput.TabIndex = 33;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(65, 201);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(563, 22);
            this.txtOutputFolder.TabIndex = 32;
            // 
            // txtInputfile
            // 
            this.txtInputfile.Location = new System.Drawing.Point(66, 105);
            this.txtInputfile.Name = "txtInputfile";
            this.txtInputfile.Size = new System.Drawing.Size(563, 22);
            this.txtInputfile.TabIndex = 30;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(67, 137);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 29);
            this.labelControl4.TabIndex = 29;
            // 
            // extensionComboBox
            // 
            this.extensionComboBox.FormattingEnabled = true;
            this.extensionComboBox.Items.AddRange(new object[] {
            ".mp4",
            ".flv",
            ".mpeg"});
            this.extensionComboBox.Location = new System.Drawing.Point(638, 278);
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.Size = new System.Drawing.Size(94, 24);
            this.extensionComboBox.TabIndex = 27;
            this.extensionComboBox.Text = ".mp4";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(65, 270);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 29);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Name file:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(65, 153);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 29);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Output:";
            // 
            // Input
            // 
            this.Input.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Appearance.Options.UseFont = true;
            this.Input.Location = new System.Drawing.Point(67, 63);
            this.Input.Margin = new System.Windows.Forms.Padding(4);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(106, 29);
            this.Input.TabIndex = 24;
            this.Input.Text = "Input Video:";
            // 
            // Outputfilebtn
            // 
            this.Outputfilebtn.Location = new System.Drawing.Point(638, 201);
            this.Outputfilebtn.Margin = new System.Windows.Forms.Padding(5);
            this.Outputfilebtn.Name = "Outputfilebtn";
            this.Outputfilebtn.Size = new System.Drawing.Size(94, 28);
            this.Outputfilebtn.TabIndex = 23;
            this.Outputfilebtn.Text = "Browse...";
            this.Outputfilebtn.Click += new System.EventHandler(this.Outputfilebtn_Click);
            // 
            // Inputfilebtn
            // 
            this.Inputfilebtn.Location = new System.Drawing.Point(638, 104);
            this.Inputfilebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Inputfilebtn.Name = "Inputfilebtn";
            this.Inputfilebtn.Size = new System.Drawing.Size(94, 29);
            this.Inputfilebtn.TabIndex = 22;
            this.Inputfilebtn.Text = "Browse...";
            this.Inputfilebtn.Click += new System.EventHandler(this.Inputfilebtn_Click);
            // 
            // combineMusictoVideo
            // 
            this.combineMusictoVideo.Location = new System.Drawing.Point(144, 342);
            this.combineMusictoVideo.Margin = new System.Windows.Forms.Padding(6);
            this.combineMusictoVideo.Name = "combineMusictoVideo";
            this.combineMusictoVideo.Size = new System.Drawing.Size(241, 45);
            this.combineMusictoVideo.TabIndex = 21;
            this.combineMusictoVideo.Text = "Convert";
            this.combineMusictoVideo.Click += new System.EventHandler(this.combineMusictoVideo_Click);
            // 
            // frmConvertFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtNameFileOutput);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.txtInputfile);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.extensionComboBox);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Outputfilebtn);
            this.Controls.Add(this.Inputfilebtn);
            this.Controls.Add(this.combineMusictoVideo);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmConvertFile";
            this.Text = "frmConvertFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtNameFileOutput;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.TextBox txtInputfile;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox extensionComboBox;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl Input;
        private DevExpress.XtraEditors.SimpleButton Outputfilebtn;
        private DevExpress.XtraEditors.SimpleButton Inputfilebtn;
        private DevExpress.XtraEditors.SimpleButton combineMusictoVideo;
    }
}