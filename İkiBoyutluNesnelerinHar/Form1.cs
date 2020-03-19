using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İkiBoyutluNesnelerinHar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 36)
            {
                panel1.BackColor = Color.Red;
                timer1.Stop();
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 730)
            {
                panel7.BackColor = Color.Red;
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 420)
            {
                panel4.BackColor = Color.Red;
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 179)
            {
                panel8.BackColor = Color.Red;

                timer4.Stop();
                timer5.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 139)
            {
                panel2.BackColor = Color.Red;

                timer5.Stop();
                timer6.Start();
            }

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Red;

            pictureBox1.Left += 5;
            timer6.Stop();
            timer7.Start();

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 580)
            {
                panel5.BackColor = Color.Red;

                timer7.Stop();
                timer8.Start();
            }

        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 315)
            {
                panel6.BackColor = Color.Red;

                timer8.Stop();
                timer9.Start();
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 280)
            {
                panel10.BackColor = Color.Red;

                timer9.Stop();
                timer10.Start();
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 230)
            {
                panel9.BackColor = Color.Red;

                timer10.Stop();
                timer11.Start();
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 470)
            {
                panel11.BackColor = Color.Red;
                panel12.BackColor = Color.Red;
                timer11.Stop();
                BackColor = Color.LightPink;
                MessageBox.Show("Tebrikler Çıkışı Bulabildiniz :)", "Bilgi");
            }
        }
    }
}
