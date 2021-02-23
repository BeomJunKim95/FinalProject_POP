namespace POPDisplay.MainForm
{
    partial class WorkOrderInfo
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
            this.dgv_WorkOrder = new POPDisplay.CustomDataGridView();
            this.pnl_All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WorkOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(122, 31);
            this.lbl_Title.Text = "작업 정보";
            // 
            // pnl_All
            // 
            this.pnl_All.BackColor = System.Drawing.Color.DimGray;
            this.pnl_All.Controls.Add(this.dgv_WorkOrder);
            this.pnl_All.Size = new System.Drawing.Size(1285, 835);
            // 
            // dgv_WorkOrder
            // 
            this.dgv_WorkOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgv_WorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_WorkOrder.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_WorkOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_WorkOrder.GridColor = System.Drawing.Color.Black;
            this.dgv_WorkOrder.IsChkVisible = false;
            this.dgv_WorkOrder.IsEditVisible = false;
            this.dgv_WorkOrder.Location = new System.Drawing.Point(0, 0);
            this.dgv_WorkOrder.Name = "dgv_WorkOrder";
            this.dgv_WorkOrder.RowTemplate.Height = 23;
            this.dgv_WorkOrder.Size = new System.Drawing.Size(1285, 835);
            this.dgv_WorkOrder.TabIndex = 0;
            this.dgv_WorkOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_WorkOrder_CellClick);
            // 
            // WorkOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Name = "WorkOrderInfo";
            this.Load += new System.EventHandler(this.WorkOrderInfo_Load);
            this.pnl_All.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WorkOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CustomDataGridView dgv_WorkOrder;
    }
}
