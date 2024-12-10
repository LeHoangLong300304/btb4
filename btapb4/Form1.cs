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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.truyendata = new Form2.truyen1(datGiatri);
            frm.ShowDialog();

        }
        private void datGiatri(string ma, string ten, string luong)
        {
            ListViewItem it = new ListViewItem(ma);
            it.SubItems.Add(ten);
            it.SubItems.Add(luong);
            lsv.Items.Add(it);
        }
   
        private void suaGiaTri(string ma, string ten, string luong)
        {
            ListViewItem item = lsv.SelectedItems[0];
            item.SubItems[0].Text = ma;
            item.SubItems[1].Text = ten;
            item.SubItems[2].Text = luong;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (lsv.SelectedItems.Count > 0)

            {
                lsv.Items.RemoveAt(lsv.SelectedItems[0].Index);
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (lsv.SelectedItems.Count > 0)
            {

                ListViewItem item = lsv.SelectedItems[0];
                Form2 form2 = new Form2(item.SubItems[0].Text, item.SubItems[1].Text,
                    item.SubItems[2].Text);
                form2.truyendata = new Form2.truyen1(suaGiaTri);
                form2.ShowDialog();
            }
        }
    }
}
