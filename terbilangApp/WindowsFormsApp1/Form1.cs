using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HurufClassLibrary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        terbilang terbilang = new terbilang();   

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(angka.Text);
            richTextBox1.Text = Convert.ToString(terbilang.ToInd(a));
        }
    }
}
