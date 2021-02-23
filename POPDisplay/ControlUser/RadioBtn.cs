using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POPDisplay.ControlUser
{
    public partial class RadioBtn : UserControl
    {
        public event EventHandler Checkevent;
        public event EventHandler FrmSizeSet;

        bool thisChecked = false;
        public string thisText{ get { return lbl_txt.Text; } set { lbl_txt.Text = value; } }
        public bool thisCheck { get { return thisChecked; } set { thisChecked = value; } }
        public PictureBox thisPic { get { return pic_Check; } }
        public Size frmSize { set { this.Size = value; } }

        public RadioBtn()
        {
            InitializeComponent();
        }

        private void pic_Check_Click(object sender, EventArgs e)
        {
            Checkevent?.Invoke(this, e);
        }

        private void RadioBtn_Load(object sender, EventArgs e)
        {
            pic_Check.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lbl_txt_Click(object sender, EventArgs e)
        {
            Checkevent?.Invoke(this, e);
        }

        private void lbl_txt_TextChanged(object sender, EventArgs e)
        {
            FrmSizeSet?.Invoke(this, e);
        }
    }
}
