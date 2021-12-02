using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ханойские_башни
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox8.Visible = false;
            button2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public bool victori;
        public int pb1 = 1;
        public int pb2 = 1;
        public int pb3 = 1;
        public int pb4 = 0;
        public int pb5 = 2;
        public int pb6 = 2;
        public int pb7 = 2;
        public void vin()
        {
            if (pb1 == 2 && pb2 == 2 && pb3 == 2 && pb4 == 0 && pb5 == 1 && pb6 == 1 && pb7 == 1)
            {
                victori = true;
                pictureBox8.Image = Properties.Resources.полный_самбади;
                pictureBox8.Visible = true;
                button2.Visible = true;
                button2.Text = ("победа вместа обеда");
                this.button2.BringToFront();
            }

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            switch (pb7)
            {
                case 2:
                    {
                        if (pb6 == 0)
                        {
                            pictureBox6.Image = Properties.Resources.istockphoto_1007665770_1024x1024_removebg_preview;
                            pictureBox7.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb6 = 2;
                            pb7 = 0;
                            vin();
                        }
                        else if (pb5 == 0)
                        {
                            pictureBox5.Image = Properties.Resources.istockphoto_1007665770_1024x1024_removebg_preview;
                            pictureBox7.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb5 = 2;
                            pb7 = 0;
                            vin();
                        }
                        else
                        {
                            MessageBox.Show("Выберите другое действие");
                        }
                        break;
                    }
                case 1:
                    {
                        if (pb7 == 1)
                        {
                            MessageBox.Show("Выберите другое действие");
                        }
                        break;
                    }
                case 0:
                    {
                        MessageBox.Show("Выберите другое действие");
                        break;
                    }
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            switch (pb6)
            {
                case 2:
                    {
                        if (pb5 == 0)
                        {
                            pictureBox5.Image = Properties.Resources.istockphoto_1007665770_1024x1024_removebg_preview;
                            pictureBox6.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb5 = 2;
                            pb6 = 0;
                            vin();
                        }
                        else if (pb4 == 0)
                        {
                            pictureBox4.Image = Properties.Resources.istockphoto_1007665770_1024x1024_removebg_preview;
                            pictureBox6.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb4 = 2;
                            pb6 = 0;
                            vin();
                        }
                        else
                        {
                            MessageBox.Show("Выберите другое действие");
                        }
                        break;
                    }
                case 1:
                    {
                        if (pb7 == 0)
                        {
                            pictureBox7.Image = Properties.Resources.imgonline_com_ua_Mirror_7aw2rkZWOd1_removebg_preview;
                            pictureBox6.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb7 = 1;
                            pb6 = 0;
                            vin();
                        }
                        else
                        {
                            MessageBox.Show("Выберите другое действие");
                        }
                        break;
                    }
                case 0:
                    {
                        MessageBox.Show("Выберите другое действие");
                        break;
                    }
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            switch (pb5)
            {
                case 2:
                    {
                        if (pb4 == 0)
                        {
                            pictureBox4.Image = Properties.Resources.istockphoto_1007665770_1024x1024_removebg_preview;
                            pictureBox5.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb4 = 2;
                            pb5 = 0;
                            vin();
                        }
                        else if (pb3 == 0)
                        {
                            pictureBox3.Image = Properties.Resources.istockphoto_1007665770_1024x1024_removebg_preview;
                            pictureBox5.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb3 = 2;
                            pb5 = 0;
                            vin();
                        }
                        else
                        {
                            MessageBox.Show("Выберите другое действие");
                        }
                        break;
                    }
                case 1:
                    {
                        if (pb6 == 0)
                        {
                            pictureBox6.Image = Properties.Resources.imgonline_com_ua_Mirror_7aw2rkZWOd1_removebg_preview;
                            pictureBox5.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb6 = 1;
                            pb5 = 0;
                            vin();
                        }
                        else if (pb7 == 0)
                        {
                            pictureBox7.Image = Properties.Resources.imgonline_com_ua_Mirror_7aw2rkZWOd1_removebg_preview;
                            pictureBox5.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb7 = 1;
                            pb5 = 0;
                            vin();
                        }
                        else
                        {
                            MessageBox.Show("Выберите другое действие");
                        }
                        break;
                    }
                case 0:
                    {
                        MessageBox.Show("Выберите другое действие");
                        break;
                    }
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            switch (pb4)
            {
                case 2:
                    {
                        if (pb3 == 0)
                        {
                            pictureBox3.Image = Properties.Resources.istockphoto_1007665770_1024x1024_removebg_preview;
                            pictureBox4.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb3 = 2;
                            pb4 = 0;
                            vin();
                        }
                        else if (pb2 == 0)
                        {
                            pictureBox2.Image = Properties.Resources.istockphoto_1007665770_1024x1024_removebg_preview;
                            pictureBox4.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb2 = 2;
                            pb4 = 0;
                            vin();
                        }
                        else
                        {
                            MessageBox.Show("Выберите другое действие");
                        }
                        break;
                    }
                case 1:
                    {
                        if (pb5 == 0)
                        {
                            pictureBox5.Image = Properties.Resources.imgonline_com_ua_Mirror_7aw2rkZWOd1_removebg_preview;
                            pictureBox4.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb5 = 1;
                            pb4 = 0;
                            vin();
                        }
                        else if (pb6 == 0)
                        {
                            pictureBox6.Image = Properties.Resources.imgonline_com_ua_Mirror_7aw2rkZWOd1_removebg_preview;
                            pictureBox4.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb6 = 1;
                            pb4 = 0;
                            vin();
                        }
                        else
                        {
                            MessageBox.Show("Выберите другое действие");
                        }
                        break;
                    }
                case 0:
                    {
                        MessageBox.Show("Выберите другое действие");
                        break;
                    }
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            switch (pb3)
            {
                case 2:
                    {
                        if (pb2 == 0)
                        {
                            pictureBox2.Image = Properties.Resources.istockphoto_1007665770_1024x1024_removebg_preview;
                            pictureBox3.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb2 = 2;
                            pb3 = 0;
                            vin();
                        }
                        else if (pb1 == 0)
                        {
                            pictureBox1.Image = Properties.Resources.istockphoto_1007665770_1024x1024_removebg_preview;
                            pictureBox3.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb1 = 2;
                            pb3 = 0;
                            vin();
                        }
                        else
                        {
                            MessageBox.Show("Выберите другое действие");
                        }
                        break;
                    }
                case 1:
                    {
                        if (pb4 == 0)
                        {
                            pictureBox4.Image = Properties.Resources.imgonline_com_ua_Mirror_7aw2rkZWOd1_removebg_preview;
                            pictureBox3.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb4 = 1;
                            pb3 = 0;
                            vin();
                        }
                        else if (pb5 == 0)
                        {
                            pictureBox5.Image = Properties.Resources.imgonline_com_ua_Mirror_7aw2rkZWOd1_removebg_preview;
                            pictureBox3.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb5 = 1;
                            pb3 = 0;
                            vin();
                        }
                        else
                        {
                            MessageBox.Show("Выберите другое действие");
                        }
                        break;
                    }
                case 0:
                    {
                        MessageBox.Show("Выберите другое действие");
                        break;
                    }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            switch (pb2)
            {
                case 2:
                    {
                        if (pb1 == 0)
                        {
                            pictureBox1.Image = Properties.Resources.istockphoto_1007665770_1024x1024_removebg_preview;
                            pictureBox2.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb1 = 2;
                            pb2 = 0;
                            vin();
                        }
                        else
                        {
                            MessageBox.Show("Выберите другое действие");
                        }
                        break;
                    }
                case 1:
                    {
                        if (pb3 == 0)
                        {
                            pictureBox3.Image = Properties.Resources.imgonline_com_ua_Mirror_7aw2rkZWOd1_removebg_preview;
                            pictureBox2.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb3 = 1;
                            pb2 = 0;
                            vin();
                        }
                        else if (pb4 == 0)
                        {
                            pictureBox4.Image = Properties.Resources.imgonline_com_ua_Mirror_7aw2rkZWOd1_removebg_preview;
                            pictureBox2.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb4 = 1;
                            pb2 = 0;
                            vin();
                        }
                        else
                        {
                            MessageBox.Show("Выберите другое действие");
                        }
                        break;
                    }
                case 0:
                    {
                        MessageBox.Show("Выберите другое действие");
                        break;
                    }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (pb1)
            {
                case 2:
                    {
                        if (pb1 == 2)
                        {

                            MessageBox.Show("Выберите другое действие");
                        }
                        break;
                    }
                case 1:
                    {
                        if (pb2 == 0)
                        {
                            pictureBox2.Image = Properties.Resources.imgonline_com_ua_Mirror_7aw2rkZWOd1_removebg_preview;
                            pictureBox1.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb2 = 1;
                            pb1 = 0;
                            vin();
                        }
                        else if (pb3 == 0)
                        {
                            pictureBox3.Image = Properties.Resources.imgonline_com_ua_Mirror_7aw2rkZWOd1_removebg_preview;
                            pictureBox1.Image = Properties.Resources.кувшинка2_removebg_preview;
                            pb3 = 1;
                            pb1 = 0;
                            vin();
                        }
                        else
                        {
                            MessageBox.Show("Выберите другое действие");
                        }
                        break;
                    }
                case 0:
                    {
                        MessageBox.Show("Выберите другое действие");
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         pb1 = 1;
         pb2 = 1;
         pb3 = 1;
         pb4 = 0;
         pb5 = 2;
         pb6 = 2;
         pb7 = 2;
            pictureBox7.Image = Properties.Resources.istockphoto_1007665770_1024x1024_removebg_preview;
            pictureBox6.Image = Properties.Resources.istockphoto_1007665770_1024x1024_removebg_preview;
            pictureBox5.Image = Properties.Resources.istockphoto_1007665770_1024x1024_removebg_preview;
            pictureBox4.Image = Properties.Resources.кувшинка2_removebg_preview;
            pictureBox3.Image = Properties.Resources.imgonline_com_ua_Mirror_7aw2rkZWOd1_removebg_preview;
            pictureBox2.Image = Properties.Resources.imgonline_com_ua_Mirror_7aw2rkZWOd1_removebg_preview;
            pictureBox1.Image = Properties.Resources.imgonline_com_ua_Mirror_7aw2rkZWOd1_removebg_preview;
            pictureBox8.Visible = true;
            button2.Visible = true;
            this.button2.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (victori ==  true)
            {
                this.Close();
            }
            else
            {
                pictureBox8.Visible = false;
                button2.Visible = false;
            }
        }
    }
    
}