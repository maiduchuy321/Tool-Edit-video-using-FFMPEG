
namespace tool_ffmpeg
{
    partial class DownloadVideo
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
            this.btnDownVid = new DevExpress.XtraEditors.SimpleButton();
            this.btnDownloadm3u8 = new DevExpress.XtraEditors.SimpleButton();
            this.txtNameFileOutput = new System.Windows.Forms.TextBox();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.txtInputfile = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Input = new DevExpress.XtraEditors.LabelControl();
            this.Outputfilebtn = new DevExpress.XtraEditors.SimpleButton();
            this.extensionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Coral;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(229, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(323, 56);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Download Video";
            // 
            // btnDownVid
            // 
            this.btnDownVid.Location = new System.Drawing.Point(472, 359);
            this.btnDownVid.Name = "btnDownVid";
            this.btnDownVid.Size = new System.Drawing.Size(157, 29);
            this.btnDownVid.TabIndex = 5;
            this.btnDownVid.Text = "Download";
            this.btnDownVid.Click += new System.EventHandler(this.btnDownVid_Click);
            // 
            // btnDownloadm3u8
            // 
            this.btnDownloadm3u8.Location = new System.Drawing.Point(190, 359);
            this.btnDownloadm3u8.Name = "btnDownloadm3u8";
            this.btnDownloadm3u8.Size = new System.Drawing.Size(157, 29);
            this.btnDownloadm3u8.TabIndex = 6;
            this.btnDownloadm3u8.Text = "Download M3U8";
            this.btnDownloadm3u8.Click += new System.EventHandler(this.btnDownloadm3u8_Click);
            // 
            // txtNameFileOutput
            // 
            this.txtNameFileOutput.Location = new System.Drawing.Point(170, 268);
            this.txtNameFileOutput.Name = "txtNameFileOutput";
            this.txtNameFileOutput.Size = new System.Drawing.Size(460, 22);
            this.txtNameFileOutput.TabIndex = 26;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(67, 216);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(563, 22);
            this.txtOutputFolder.TabIndex = 25;
            // 
            // txtInputfile
            // 
            this.txtInputfile.Location = new System.Drawing.Point(66, 132);
            this.txtInputfile.Name = "txtInputfile";
            this.txtInputfile.Size = new System.Drawing.Size(563, 22);
            this.txtInputfile.TabIndex = 24;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(69, 261);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 29);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Name file:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(69, 179);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 29);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Output:";
            // 
            // Input
            // 
            this.Input.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Appearance.Options.UseFont = true;
            this.Input.Location = new System.Drawing.Point(67, 90);
            this.Input.Margin = new System.Windows.Forms.Padding(4);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(37, 29);
            this.Input.TabIndex = 20;
            this.Input.Text = "Link";
            // 
            // Outputfilebtn
            // 
            this.Outputfilebtn.Location = new System.Drawing.Point(640, 213);
            this.Outputfilebtn.Margin = new System.Windows.Forms.Padding(5);
            this.Outputfilebtn.Name = "Outputfilebtn";
            this.Outputfilebtn.Size = new System.Drawing.Size(94, 28);
            this.Outputfilebtn.TabIndex = 19;
            this.Outputfilebtn.Text = "Browse...";
            this.Outputfilebtn.Click += new System.EventHandler(this.Outputfilebtn_Click);
            // 
            // extensionComboBox
            // 
            this.extensionComboBox.FormattingEnabled = true;
            this.extensionComboBox.Items.AddRange(new object[] {
            ".mp4",
            ".flv",
            ".mpeg"});
            this.extensionComboBox.Location = new System.Drawing.Point(640, 266);
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.Size = new System.Drawing.Size(94, 24);
            this.extensionComboBox.TabIndex = 23;
            this.extensionComboBox.Text = ".mp4";
            // 
            // DownloadVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNameFileOutput);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.txtInputfile);
            this.Controls.Add(this.extensionComboBox);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Outputfilebtn);
            this.Controls.Add(this.btnDownloadm3u8);
            this.Controls.Add(this.btnDownVid);
            this.Controls.Add(this.labelControl1);
            this.Name = "DownloadVideo";
            this.Text = "DownloadVideo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDownVid;
        private DevExpress.XtraEditors.SimpleButton btnDownloadm3u8;
        private System.Windows.Forms.TextBox txtNameFileOutput;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.TextBox txtInputfile;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl Input;
        private DevExpress.XtraEditors.SimpleButton Outputfilebtn;
        private System.Windows.Forms.ComboBox extensionComboBox;
    }
}