
namespace POPDisplay.ControlUser
{
    partial class RadioBtn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadioBtn));
            this.pic_Check = new System.Windows.Forms.PictureBox();
            this.lbl_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Check)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Check
            // 
            this.pic_Check.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_Check.Image = ((System.Drawing.Image)(resources.GetObject("pic_Check.Image")));
            this.pic_Check.Location = new System.Drawing.Point(0, 0);
            this.pic_Check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_Check.Name = "pic_Check";
            this.pic_Check.Size = new System.Drawing.Size(26, 24);
            this.pic_Check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Check.TabIndex = 0;
            this.pic_Check.TabStop = false;
            this.pic_Check.Click += new System.EventHandler(this.pic_Check_Click);
            // 
            // lbl_txt
            // 
            this.lbl_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_txt.AutoSize = true;
            this.lbl_txt.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_txt.Location = new System.Drawing.Point(31, 4);
            this.lbl_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_txt.Name = "lbl_txt";
            this.lbl_txt.Size = new System.Drawing.Size(38, 19);
            this.lbl_txt.TabIndex = 1;
            this.lbl_txt.Text = "text";
            this.lbl_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_txt.TextChanged += new System.EventHandler(this.lbl_txt_TextChanged);
            this.lbl_txt.Click += new System.EventHandler(this.lbl_txt_Click);
            // 
            // RadioBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_txt);
            this.Controls.Add(this.pic_Check);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RadioBtn";
            this.Size = new System.Drawing.Size(70, 26);
            this.Load += new System.EventHandler(this.RadioBtn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Check;
        private System.Windows.Forms.Label lbl_txt;
    }
}
