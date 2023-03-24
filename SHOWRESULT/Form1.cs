using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOWRESULT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, toplam;
            s1 = Convert.ToInt32(guna2TextBox1.Text);
            s2 = Convert.ToInt32(guna2TextBox2.Text);
            s3 = Convert.ToInt32(guna2TextBox3.Text);
            toplam = (s1 + s2) * s3;
            guna2TextBox4.Text = toplam.ToString();
        }
    }
}
