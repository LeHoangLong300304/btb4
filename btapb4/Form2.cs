using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btapb4
{
    public partial class Form2 : Form
    {
        public delegate void truyen1(string ma, string ten, string luong);
        public truyen1 truyendata;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string ma, string ten, string luong)
        {
            InitializeComponent();
            txtMSNV.Text = ma;
            txtTenNV.Text = ten;
            txtLuongCB.Text = luong;
        }
        private void btn_Dongy_Click(object sender, EventArgs e)
        {
            if (truyendata != null)
            {
                truyendata(txtMSNV.Text, txtTenNV.Text, txtLuongCB.Text);
                this.Close();
            }

        }
        private void btn_Boqua_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
