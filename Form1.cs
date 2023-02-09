using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int summa = Int32.Parse(txtA.Text) *
               Int32.Parse(txtB.Text);
            txtSumma.Text = summa.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int summa2 = 2*(Int32.Parse(txtA.Text) +
               Int32.Parse(txtB.Text));
            txtSumma2.Text = summa2.ToString();
        }

        private void txtSumma2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSumma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
