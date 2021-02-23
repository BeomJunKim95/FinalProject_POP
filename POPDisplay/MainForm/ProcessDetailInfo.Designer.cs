namespace POPDisplay.MainForm
{
	partial class ProcessDetailInfo
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
			if(disposing && (components != null))
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
            this.dgv_pcs = new POPDisplay.CustomDataGridView();
            this.pnl_All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pcs)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(155, 31);
            this.lbl_Title.Text = "SearchBase";
            // 
            // pnl_All
            // 
            this.pnl_All.Controls.Add(this.dgv_pcs);
            // 
            // dgv_pcs
            // 
            this.dgv_pcs.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pcs.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pcs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pcs.GridColor = System.Drawing.Color.Black;
            this.dgv_pcs.IsChkVisible = false;
            this.dgv_pcs.IsEditVisible = false;
            this.dgv_pcs.Location = new System.Drawing.Point(0, 0);
            this.dgv_pcs.Name = "dgv_pcs";
            this.dgv_pcs.RowTemplate.Height = 23;
            this.dgv_pcs.Size = new System.Drawing.Size(1278, 828);
            this.dgv_pcs.TabIndex = 0;
            // 
            // ProcessDetailInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Name = "ProcessDetailInfo";
            this.Load += new System.EventHandler(this.ProcessDetailInfo_Load);
            this.pnl_All.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pcs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
		}

        #endregion

        private CustomDataGridView dgv_pcs;
    }
}
