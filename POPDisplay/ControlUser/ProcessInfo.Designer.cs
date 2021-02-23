
namespace POPDisplay.ControlUser
{
    partial class ProcessInfo
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pgb_Per = new System.Windows.Forms.ProgressBar();
            this.lbl_Per = new System.Windows.Forms.Label();
            this.lbl_PcsName = new System.Windows.Forms.Label();
            this.pic_PcsImg = new System.Windows.Forms.PictureBox();
            this.timer_Connect1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_PcsImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pgb_Per
            // 
            this.pgb_Per.Location = new System.Drawing.Point(28, 278);
            this.pgb_Per.Margin = new System.Windows.Forms.Padding(4);
            this.pgb_Per.Name = "pgb_Per";
            this.pgb_Per.Size = new System.Drawing.Size(217, 33);
            this.pgb_Per.TabIndex = 1;
            // 
            // lbl_Per
            // 
            this.lbl_Per.AutoSize = true;
            this.lbl_Per.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Per.Location = new System.Drawing.Point(64, 330);
            this.lbl_Per.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Per.Name = "lbl_Per";
            this.lbl_Per.Size = new System.Drawing.Size(145, 21);
            this.lbl_Per.TabIndex = 2;
            this.lbl_Per.Text = "PercentageText";
            // 
            // lbl_PcsName
            // 
            this.lbl_PcsName.AutoSize = true;
            this.lbl_PcsName.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_PcsName.Location = new System.Drawing.Point(13, 10);
            this.lbl_PcsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PcsName.Name = "lbl_PcsName";
            this.lbl_PcsName.Size = new System.Drawing.Size(163, 21);
            this.lbl_PcsName.TabIndex = 3;
            this.lbl_PcsName.Tag = "PcsCode";
            this.lbl_PcsName.Text = "ProcessNameText";
            // 
            // pic_PcsImg
            // 
            this.pic_PcsImg.Image = global::POPDisplay.Properties.Resources.ProcessImgSample;
            this.pic_PcsImg.Location = new System.Drawing.Point(42, 51);
            this.pic_PcsImg.Margin = new System.Windows.Forms.Padding(4);
            this.pic_PcsImg.Name = "pic_PcsImg";
            this.pic_PcsImg.Size = new System.Drawing.Size(188, 218);
            this.pic_PcsImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PcsImg.TabIndex = 0;
            this.pic_PcsImg.TabStop = false;
            // 
            // timer_Connect1
            // 
            this.timer_Connect1.Interval = 1000;
            this.timer_Connect1.Tick += new System.EventHandler(this.timer_Connect_Tick);
            // 
            // ProcessInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_PcsName);
            this.Controls.Add(this.lbl_Per);
            this.Controls.Add(this.pgb_Per);
            this.Controls.Add(this.pic_PcsImg);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProcessInfo";
            this.Size = new System.Drawing.Size(273, 373);
            this.Load += new System.EventHandler(this.ProcessInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_PcsImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_PcsImg;
        public System.Windows.Forms.ProgressBar pgb_Per;
        private System.Windows.Forms.Label lbl_Per;
        private System.Windows.Forms.Label lbl_PcsName;
        private System.Windows.Forms.Timer timer_Connect1;
    }
}
