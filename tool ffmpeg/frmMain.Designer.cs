
namespace tool_ffmpeg
{
    partial class frmMain
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
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnConvertType = new DevExpress.XtraEditors.SimpleButton();
            this.btnDownVid = new DevExpress.XtraEditors.SimpleButton();
            this.btnCombineMusictoVId = new DevExpress.XtraEditors.SimpleButton();
            this.btnSplitVideo = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 338);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(800, 112);
            this.windowsUIButtonPanel1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Coral;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(66, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(658, 30);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Phần mềm hỗ trợ chỉnh sửa sử dụng FFMPEG";
            // 
            // btnConvertType
            // 
            this.btnConvertType.Location = new System.Drawing.Point(443, 150);
            this.btnConvertType.Name = "btnConvertType";
            this.btnConvertType.Size = new System.Drawing.Size(157, 29);
            this.btnConvertType.TabIndex = 1;
            this.btnConvertType.Text = "Convert Type File";
            this.btnConvertType.Click += new System.EventHandler(this.btnConvertType_Click);
            // 
            // btnDownVid
            // 
            this.btnDownVid.Location = new System.Drawing.Point(168, 150);
            this.btnDownVid.Name = "btnDownVid";
            this.btnDownVid.Size = new System.Drawing.Size(157, 29);
            this.btnDownVid.TabIndex = 2;
            this.btnDownVid.Text = "Download Video";
            this.btnDownVid.Click += new System.EventHandler(this.btnDownVid_Click);
            // 
            // btnCombineMusictoVId
            // 
            this.btnCombineMusictoVId.Location = new System.Drawing.Point(168, 236);
            this.btnCombineMusictoVId.Name = "btnCombineMusictoVId";
            this.btnCombineMusictoVId.Size = new System.Drawing.Size(157, 29);
            this.btnCombineMusictoVId.TabIndex = 3;
            this.btnCombineMusictoVId.Text = "Combine Music in Video";
            this.btnCombineMusictoVId.Click += new System.EventHandler(this.btnCombineMusictoVId_Click);
            // 
            // btnSplitVideo
            // 
            this.btnSplitVideo.Location = new System.Drawing.Point(443, 236);
            this.btnSplitVideo.Name = "btnSplitVideo";
            this.btnSplitVideo.Size = new System.Drawing.Size(157, 29);
            this.btnSplitVideo.TabIndex = 4;
            this.btnSplitVideo.Text = "Split Video";
            this.btnSplitVideo.Click += new System.EventHandler(this.btnSplitVideo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSplitVideo);
            this.Controls.Add(this.btnCombineMusictoVId);
            this.Controls.Add(this.btnDownVid);
            this.Controls.Add(this.btnConvertType);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnConvertType;
        private DevExpress.XtraEditors.SimpleButton btnDownVid;
        private DevExpress.XtraEditors.SimpleButton btnCombineMusictoVId;
        private DevExpress.XtraEditors.SimpleButton btnSplitVideo;
    }
}