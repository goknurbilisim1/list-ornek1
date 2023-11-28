using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad=Convert.ToString(txtOgrenci.Text);
            list.Add(ad);
            listBox1.DataSource=list.ToList();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            txtOgrenci.Text = "";
            listBox1.DataSource = list.ToList();
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            list.Sort();
            listBox1.DataSource = list.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {   
           
        }
    }
}
