using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VO;

namespace POPDisplay.MainForm
{
    public partial class Form1 : Form
    {
        ServiceHelp service;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imagedata data = new Imagedata();
            data.image = CommonUtil.ImageToByte(Image.FromFile("C:\\Users\\dydrk\\OneDrive\\바탕 화면\\images.png"));
            data.filename = "images.png";
            service = new ServiceHelp();
            ApiMessage result = service.PostApiCallerNone("Images/Upload", data);
        
        }
    }
}
