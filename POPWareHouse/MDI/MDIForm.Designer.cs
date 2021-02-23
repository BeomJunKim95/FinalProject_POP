namespace POPWareHouse.MDI
{
    partial class MDIForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_SelectOrke = new System.Windows.Forms.Label();
            this.lbl_WHName = new System.Windows.Forms.Label();
            this.btn_WareHouseIn = new System.Windows.Forms.Button();
            this.pcb_Minmax = new System.Windows.Forms.PictureBox();
            this.pcb_Close = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Minmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_SelectOrke);
            this.panel1.Controls.Add(this.lbl_WHName);
            this.panel1.Controls.Add(this.btn_WareHouseIn);
            this.panel1.Controls.Add(this.pcb_Minmax);
            this.panel1.Controls.Add(this.pcb_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1300, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 900);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 61);
            this.button1.TabIndex = 16;
            this.button1.Text = "발주 목록 확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_SelectOrke
            // 
            this.lbl_SelectOrke.AutoSize = true;
            this.lbl_SelectOrke.Location = new System.Drawing.Point(3, 104);
            this.lbl_SelectOrke.Name = "lbl_SelectOrke";
            this.lbl_SelectOrke.Size = new System.Drawing.Size(0, 19);
            this.lbl_SelectOrke.TabIndex = 15;
            // 
            // lbl_WHName
            // 
            this.lbl_WHName.AutoSize = true;
            this.lbl_WHName.Location = new System.Drawing.Point(3, 80);
            this.lbl_WHName.Name = "lbl_WHName";
            this.lbl_WHName.Size = new System.Drawing.Size(107, 19);
            this.lbl_WHName.TabIndex = 14;
            this.lbl_WHName.Text = "선택 발주 코드";
            // 
            // btn_WareHouseIn
            // 
            this.btn_WareHouseIn.Location = new System.Drawing.Point(0, 164);
            this.btn_WareHouseIn.Name = "btn_WareHouseIn";
            this.btn_WareHouseIn.Size = new System.Drawing.Size(200, 61);
            this.btn_WareHouseIn.TabIndex = 12;
            this.btn_WareHouseIn.Text = "재고 목록 확인";
            this.btn_WareHouseIn.UseVisualStyleBackColor = true;
            this.btn_WareHouseIn.Click += new System.EventHandler(this.btn_WareHouseIn_Click);
            // 
            // pcb_Minmax
            // 
            this.pcb_Minmax.Image = global::POPWareHouse.Properties.Resources.Remove_32x32;
            this.pcb_Minmax.Location = new System.Drawing.Point(34, 12);
            this.pcb_Minmax.Name = "pcb_Minmax";
            this.pcb_Minmax.Size = new System.Drawing.Size(50, 50);
            this.pcb_Minmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Minmax.TabIndex = 5;
            this.pcb_Minmax.TabStop = false;
            this.pcb_Minmax.Click += new System.EventHandler(this.pcb_Minmax_Click);
            // 
            // pcb_Close
            // 
            this.pcb_Close.Image = global::POPWareHouse.Properties.Resources.Cancel_32x32;
            this.pcb_Close.Location = new System.Drawing.Point(136, 12);
            this.pcb_Close.Name = "pcb_Close";
            this.pcb_Close.Size = new System.Drawing.Size(50, 50);
            this.pcb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Close.TabIndex = 4;
            this.pcb_Close.TabStop = false;
            this.pcb_Close.Click += new System.EventHandler(this.pcb_Close_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 61);
            this.button2.TabIndex = 17;
            this.button2.Text = "발주 처리 및 바코드 출력";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MDIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MDIForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIForm_FormClosing);
            this.Load += new System.EventHandler(this.MDIForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Minmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcb_Minmax;
        private System.Windows.Forms.PictureBox pcb_Close;
        private System.Windows.Forms.Button btn_WareHouseIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_SelectOrke;
        private System.Windows.Forms.Label lbl_WHName;
        private System.Windows.Forms.Button button2;
    }
}