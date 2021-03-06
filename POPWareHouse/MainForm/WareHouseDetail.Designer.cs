﻿namespace POPWareHouse.MainForm
{
    partial class WareHouseDetail
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
            this.dgv_WareHouseDetail = new POPWareHouse.CustomDataGridView();
            this.pnl_All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WareHouseDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(114, 31);
            this.lbl_Title.Text = "재고확인";
            // 
            // pnl_All
            // 
            this.pnl_All.Controls.Add(this.dgv_WareHouseDetail);
            // 
            // dgv_WareHouseDetail
            // 
            this.dgv_WareHouseDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgv_WareHouseDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_WareHouseDetail.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_WareHouseDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_WareHouseDetail.GridColor = System.Drawing.Color.Black;
            this.dgv_WareHouseDetail.IsChkVisible = false;
            this.dgv_WareHouseDetail.IsEditVisible = false;
            this.dgv_WareHouseDetail.Location = new System.Drawing.Point(0, 0);
            this.dgv_WareHouseDetail.Name = "dgv_WareHouseDetail";
            this.dgv_WareHouseDetail.RowTemplate.Height = 23;
            this.dgv_WareHouseDetail.Size = new System.Drawing.Size(1278, 828);
            this.dgv_WareHouseDetail.TabIndex = 0;
            this.dgv_WareHouseDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_WareHouseDetail_CellContentClick);
            // 
            // WareHouseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Name = "WareHouseDetail";
            this.Load += new System.EventHandler(this.WareHouseDetail_Load);
            this.pnl_All.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WareHouseDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGridView dgv_WareHouseDetail;
    }
}
