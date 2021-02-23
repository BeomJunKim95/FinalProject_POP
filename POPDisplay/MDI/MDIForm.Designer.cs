namespace POPDisplay.MDI
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
            this.lbl_WorkOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_StartWork = new System.Windows.Forms.Button();
            this.btn_ = new System.Windows.Forms.Button();
            this.pcb_Minmax = new System.Windows.Forms.PictureBox();
            this.pcb_Close = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ProductCheck = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_WrokOrderForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Minmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_WorkOrder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Stop);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_StartWork);
            this.panel1.Controls.Add(this.btn_);
            this.panel1.Controls.Add(this.pcb_Minmax);
            this.panel1.Controls.Add(this.pcb_Close);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_ProductCheck);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_WrokOrderForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1300, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 900);
            this.panel1.TabIndex = 1;
            // 
            // lbl_WorkOrder
            // 
            this.lbl_WorkOrder.AutoSize = true;
            this.lbl_WorkOrder.Location = new System.Drawing.Point(3, 123);
            this.lbl_WorkOrder.Name = "lbl_WorkOrder";
            this.lbl_WorkOrder.Size = new System.Drawing.Size(0, 19);
            this.lbl_WorkOrder.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "선택 작업 코드";
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(0, 372);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(200, 76);
            this.btn_Stop.TabIndex = 9;
            this.btn_Stop.Text = "작업 멈춤";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 802);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 76);
            this.button2.TabIndex = 8;
            this.button2.Text = "작업 종료";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_StartWork
            // 
            this.btn_StartWork.Location = new System.Drawing.Point(0, 286);
            this.btn_StartWork.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StartWork.Name = "btn_StartWork";
            this.btn_StartWork.Size = new System.Drawing.Size(200, 76);
            this.btn_StartWork.TabIndex = 7;
            this.btn_StartWork.Text = "작업 시작";
            this.btn_StartWork.UseVisualStyleBackColor = true;
            this.btn_StartWork.Click += new System.EventHandler(this.btn_StartWork_Click);
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(0, 544);
            this.btn_.Margin = new System.Windows.Forms.Padding(5);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(200, 76);
            this.btn_.TabIndex = 6;
            this.btn_.Text = "설비 조회";
            this.btn_.UseVisualStyleBackColor = true;
            this.btn_.Click += new System.EventHandler(this.btn__Click);
            // 
            // pcb_Minmax
            // 
            this.pcb_Minmax.Image = global::POPDisplay.Properties.Resources.Remove_32x32;
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
            this.pcb_Close.Image = global::POPDisplay.Properties.Resources.Cancel_32x32;
            this.pcb_Close.Location = new System.Drawing.Point(136, 12);
            this.pcb_Close.Name = "pcb_Close";
            this.pcb_Close.Size = new System.Drawing.Size(50, 50);
            this.pcb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Close.TabIndex = 4;
            this.pcb_Close.TabStop = false;
            this.pcb_Close.Click += new System.EventHandler(this.pcb_Close_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 716);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 76);
            this.button1.TabIndex = 3;
            this.button1.Text = "실적 등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ProductCheck
            // 
            this.btn_ProductCheck.Location = new System.Drawing.Point(0, 630);
            this.btn_ProductCheck.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ProductCheck.Name = "btn_ProductCheck";
            this.btn_ProductCheck.Size = new System.Drawing.Size(200, 76);
            this.btn_ProductCheck.TabIndex = 2;
            this.btn_ProductCheck.Text = "물품 검사";
            this.btn_ProductCheck.UseVisualStyleBackColor = true;
            this.btn_ProductCheck.Click += new System.EventHandler(this.btn_ProductCheck_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(0, 458);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(200, 76);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "작업 프로세스 조회";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_WrokOrderForm
            // 
            this.btn_WrokOrderForm.Location = new System.Drawing.Point(0, 200);
            this.btn_WrokOrderForm.Margin = new System.Windows.Forms.Padding(5);
            this.btn_WrokOrderForm.Name = "btn_WrokOrderForm";
            this.btn_WrokOrderForm.Size = new System.Drawing.Size(200, 76);
            this.btn_WrokOrderForm.TabIndex = 0;
            this.btn_WrokOrderForm.Text = "작업지시 조회";
            this.btn_WrokOrderForm.UseVisualStyleBackColor = true;
            this.btn_WrokOrderForm.Click += new System.EventHandler(this.btn_WrokOrderForm_Click);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Minmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ProductCheck;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_WrokOrderForm;
        private System.Windows.Forms.PictureBox pcb_Minmax;
        private System.Windows.Forms.PictureBox pcb_Close;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.Button btn_StartWork;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label lbl_WorkOrder;
        private System.Windows.Forms.Label label1;
    }
}