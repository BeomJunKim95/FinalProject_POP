using POPDisplay.ControlUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace POPDisplay.MainForm
{
    public partial class FacilityInfo : POPDisplay.BaseForm.BaseForm
    {
        frmPLCTask frm;
        public string Task_ID = string.Empty;
        public string Task_IP = "127.0.0.1";
        public string Task_Port = "8800";
        FacilityVO vo;
        ProcessInfo info;

        public bool IsTaskEnable
        {
            get
            {
                return btnStop.Enabled;
            }
            set
            {
                if (value)
                {
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                }
                else
                {
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                }
            }
        }
        public FacilityInfo(FacilityVO vo, int EstimatedQuantity)
        {
            InitializeComponent();
            this.vo = vo;
            info = new ProcessInfo(vo);
            info.Location = new Point(33, 14);
            info.Size = new Size(286, 372);
            List<Label> labels = new List<Label> { label3, label5 };
            info.Tag = labels;
            info.WO_EstimatedQuantity = EstimatedQuantity;
            panel1.Controls.Add(info);
            info.BackColorChanged += Info_BackColorChanged;
            Task_ID = vo.Fac_Code;
            label2.Text = EstimatedQuantity.ToString();
        }

        private void Info_BackColorChanged(object sender, EventArgs e)
        {
            if(info.BackColor == Color.LightPink)
            {
                btnStart.Enabled = btnStop.Enabled = button3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info.StartThread();
            IsTaskEnable = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            info.StopThread();
            IsTaskEnable = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (info.BackColor != Color.LightPink)
            {
                if(MessageBox.Show("아직 작업이 끝나지 않았습니다.\n작업을 끝내시겠습니까? ", "작업종료", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    info.StopThread();
                    info.BackColor = Color.LightPink;
                }
            }
        }
    }
}
