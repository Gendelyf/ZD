using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace informationtest
{
    public partial class helloworld : Form
    {
        public helloworld()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            zd1 z1 = new zd1();
            this.Hide();
            z1.ShowDialog();
            this.Show();
            helloworld hell = new helloworld();
            hell.Hide();

        }
    }
}
