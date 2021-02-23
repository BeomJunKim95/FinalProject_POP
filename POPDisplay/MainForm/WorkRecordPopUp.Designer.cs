namespace POPDisplay.MainForm
{
    partial class WorkRecordPopUp
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbx_BadQuantity = new System.Windows.Forms.TextBox();
            this.tbx_GoodsQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_All.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(122, 31);
            this.lbl_Title.Text = "실적 등록";
            // 
            // pnl_All
            // 
            this.pnl_All.BackColor = System.Drawing.Color.Silver;
            this.pnl_All.Controls.Add(this.button2);
            this.pnl_All.Controls.Add(this.btn_Add);
            this.pnl_All.Controls.Add(this.panel1);
            this.pnl_All.Size = new System.Drawing.Size(1127, 428);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.tbx_BadQuantity);
            this.panel1.Controls.Add(this.tbx_GoodsQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 277);
            this.panel1.TabIndex = 0;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Snow;
            this.button13.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button13.Location = new System.Drawing.Point(1008, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(96, 66);
            this.button13.TabIndex = 13;
            this.button13.Text = "<-";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Snow;
            this.button12.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button12.Location = new System.Drawing.Point(1008, 86);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(96, 66);
            this.button12.TabIndex = 12;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.NUMbutton_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Snow;
            this.button11.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button11.Location = new System.Drawing.Point(890, 167);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(96, 66);
            this.button11.TabIndex = 11;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.NUMbutton_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Snow;
            this.button10.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.Location = new System.Drawing.Point(766, 167);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 66);
            this.button10.TabIndex = 10;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.NUMbutton_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Snow;
            this.button9.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(646, 167);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 66);
            this.button9.TabIndex = 9;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.NUMbutton_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Snow;
            this.button8.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(890, 86);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 66);
            this.button8.TabIndex = 8;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.NUMbutton_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Snow;
            this.button7.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(766, 86);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 66);
            this.button7.TabIndex = 7;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NUMbutton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Snow;
            this.button6.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(646, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 66);
            this.button6.TabIndex = 6;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NUMbutton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Snow;
            this.button5.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(890, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 66);
            this.button5.TabIndex = 5;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.NUMbutton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Snow;
            this.button4.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(766, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 66);
            this.button4.TabIndex = 4;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.NUMbutton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(646, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.NUMbutton_Click);
            // 
            // tbx_BadQuantity
            // 
            this.tbx_BadQuantity.Font = new System.Drawing.Font("나눔고딕", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbx_BadQuantity.Location = new System.Drawing.Point(30, 167);
            this.tbx_BadQuantity.Name = "tbx_BadQuantity";
            this.tbx_BadQuantity.Size = new System.Drawing.Size(406, 48);
            this.tbx_BadQuantity.TabIndex = 3;
            this.tbx_BadQuantity.Text = "0";
            this.tbx_BadQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_BadQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbx_MouseClick);
            // 
            // tbx_GoodsQuantity
            // 
            this.tbx_GoodsQuantity.Font = new System.Drawing.Font("나눔고딕", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbx_GoodsQuantity.Location = new System.Drawing.Point(30, 66);
            this.tbx_GoodsQuantity.Name = "tbx_GoodsQuantity";
            this.tbx_GoodsQuantity.Size = new System.Drawing.Size(406, 48);
            this.tbx_GoodsQuantity.TabIndex = 2;
            this.tbx_GoodsQuantity.Text = "0";
            this.tbx_GoodsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_GoodsQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbx_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(24, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "불량품";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "양품 갯수";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Snow;
            this.btn_Add.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Add.Location = new System.Drawing.Point(30, 315);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(292, 66);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "추가";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(812, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WorkRecordPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.ClientSize = new System.Drawing.Size(1149, 500);
            this.Name = "WorkRecordPopUp";
            this.pnl_All.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbx_BadQuantity;
        private System.Windows.Forms.TextBox tbx_GoodsQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
