
namespace tool_ffmpeg
{
    partial class frmSplitVideo
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
            this.splitVideo = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.endTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.cutVideo = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(116, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(271, 23);
            this.progressBar1.TabIndex = 47;
            // 
            // txtNameFileOutput
            // 
            this.txtNameFileOutput.Location = new System.Drawing.Point(170, 306);
            this.txtNameFileOutput.Name = "txtNameFileOutput";
            this.txtNameFileOutput.Size = new System.Drawing.Size(460, 22);
            this.txtNameFileOutput.TabIndex = 46;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(146, 248);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(485, 22);
            this.txtOutputFolder.TabIndex = 45;
            // 
            // txtInputfile
            // 
            this.txtInputfile.Location = new System.Drawing.Point(68, 131);
            this.txtInputfile.Name = "txtInputfile";
            this.txtInputfile.Size = new System.Drawing.Size(563, 22);
            this.txtInputfile.TabIndex = 44;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(69, 163);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 29);
            this.labelControl4.TabIndex = 43;
            // 
            // extensionComboBox
            // 
            this.extensionComboBox.FormattingEnabled = true;
            this.extensionComboBox.Items.AddRange(new object[] {
            ".mp4",
            ".flv",
            ".mpeg"});
            this.extensionComboBox.Location = new System.Drawing.Point(640, 307);
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.Size = new System.Drawing.Size(94, 24);
            this.extensionComboBox.TabIndex = 42;
            this.extensionComboBox.Text = ".mp4";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(67, 299);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 29);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Name file:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(67, 241);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 29);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Output:";
            // 
            // Input
            // 
            this.Input.Appearance.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Appearance.Options.UseFont = true;
            this.Input.Location = new System.Drawing.Point(69, 89);
            this.Input.Margin = new System.Windows.Forms.Padding(4);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(106, 29);
            this.Input.TabIndex = 39;
            this.Input.Text = "Input Video:";
            // 
            // Outputfilebtn
            // 
            this.Outputfilebtn.Location = new System.Drawing.Point(640, 246);
            this.Outputfilebtn.Margin = new System.Windows.Forms.Padding(5);
            this.Outputfilebtn.Name = "Outputfilebtn";
            this.Outputfilebtn.Size = new System.Drawing.Size(94, 28);
            this.Outputfilebtn.TabIndex = 38;
            this.Outputfilebtn.Text = "Browse...";
            this.Outputfilebtn.Click += new System.EventHandler(this.Outputfilebtn_Click);
            // 
            // Inputfilebtn
            // 
            this.Inputfilebtn.Location = new System.Drawing.Point(640, 130);
            this.Inputfilebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Inputfilebtn.Name = "Inputfilebtn";
            this.Inputfilebtn.Size = new System.Drawing.Size(94, 29);
            this.Inputfilebtn.TabIndex = 37;
            this.Inputfilebtn.Text = "Browse...";
            this.Inputfilebtn.Click += new System.EventHandler(this.Inputfilebtn_Click);
            // 
            // splitVideo
            // 
            this.splitVideo.Location = new System.Drawing.Point(146, 352);
            this.splitVideo.Margin = new System.Windows.Forms.Padding(6);
            this.splitVideo.Name = "splitVideo";
            this.splitVideo.Size = new System.Drawing.Size(241, 45);
            this.splitVideo.TabIndex = 36;
            this.splitVideo.Text = "Split Video";
            this.splitVideo.Click += new System.EventHandler(this.splitVideo_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Coral;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(268, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(211, 41);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Split Video";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Aptima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 28);
            this.label3.TabIndex = 51;
            this.label3.Text = "How many seconds";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // endTextBox
            // 
            this.endTextBox.Location = new System.Drawing.Point(602, 191);
            this.endTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(132, 22);
            this.endTextBox.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Aptima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 49;
            this.label2.Text = "Split start second";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startTextBox
            // 
            this.startTextBox.Location = new System.Drawing.Point(235, 191);
            this.startTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(132, 22);
            this.startTextBox.TabIndex = 48;
            // 
            // cutVideo
            // 
            this.cutVideo.Location = new System.Drawing.Point(484, 352);
            this.cutVideo.Margin = new System.Windows.Forms.Padding(6);
            this.cutVideo.Name = "cutVideo";
            this.cutVideo.Size = new System.Drawing.Size(241, 45);
            this.cutVideo.TabIndex = 52;
            this.cutVideo.Text = "Cut Video";
            this.cutVideo.Click += new System.EventHandler(this.cutVideo_Click);
            // 
            // frmSplitVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cutVideo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startTextBox);
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
            this.Controls.Add(this.splitVideo);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmSplitVideo";
            this.Text = "frmSplitVideo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraEditors.SimpleButton splitVideo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox endTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startTextBox;
        private DevExpress.XtraEditors.SimpleButton cutVideo;
    }
}