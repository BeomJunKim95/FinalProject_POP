namespace POPWareHouse.MainForm
{
    partial class OrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv_Order = new POPWareHouse.CustomDataGridView();
            this.dgv_OrderDetail = new POPWareHouse.CustomDataGridView();
            this.pnl_All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(122, 31);
            this.lbl_Title.Text = "배송 목록";
            // 
            // pnl_All
            // 
            this.pnl_All.Controls.Add(this.splitContainer1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv_Order);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_OrderDetail);
            this.splitContainer1.Size = new System.Drawing.Size(1278, 828);
            this.splitContainer1.SplitterDistance = 569;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgv_Order
            // 
            this.dgv_Order.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Order.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Order.GridColor = System.Drawing.Color.Black;
            this.dgv_Order.IsChkVisible = false;
            this.dgv_Order.IsEditVisible = false;
            this.dgv_Order.Location = new System.Drawing.Point(0, 0);
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.RowTemplate.Height = 23;
            this.dgv_Order.Size = new System.Drawing.Size(569, 828);
            this.dgv_Order.TabIndex = 0;
            this.dgv_Order.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Order_CellDoubleClick);
            // 
            // dgv_OrderDetail
            // 
            this.dgv_OrderDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgv_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_OrderDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_OrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_OrderDetail.GridColor = System.Drawing.Color.Black;
            this.dgv_OrderDetail.IsChkVisible = false;
            this.dgv_OrderDetail.IsEditVisible = false;
            this.dgv_OrderDetail.Location = new System.Drawing.Point(0, 0);
            this.dgv_OrderDetail.Name = "dgv_OrderDetail";
            this.dgv_OrderDetail.RowTemplate.Height = 23;
            this.dgv_OrderDetail.Size = new System.Drawing.Size(705, 828);
            this.dgv_OrderDetail.TabIndex = 0;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Name = "OrdersForm";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.pnl_All.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private CustomDataGridView dgv_Order;
        private CustomDataGridView dgv_OrderDetail;
    }
}
