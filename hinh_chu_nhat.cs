
using System.Windows.Forms;
using System;

sing System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HinhChuNhat_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void btnDientich_Click(object sender, EventArgs e)
        {
            hinh_chu_nhat hcn = new hinh_chu_nhat();
            hcn.chieucao = Double.Parse(txtCao.Text);
            hcn.chieurong = Double.Parse(txtRong.Text);

            txtKQ.Text = hcn.tinhchuvi().ToString();
        }
    }
}