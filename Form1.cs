using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullanıciadi.Text=="1234" && sifre.Text=="1234" )
            {
                new Form2().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                kullanıciadi.Clear();
                sifre.Clear();
                kullanıciadi.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            kullanıciadi.Clear();
            sifre.Clear();
            kullanıciadi.Focus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            kullanıciadi.Clear();
            kullanıciadi.Focus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            sifre.Clear();
            kullanıciadi.Focus();
        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {
            
            // The password character is an asterisk.
            sifre.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            sifre.MaxLength = 14;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullanıciadi_TextChanged(object sender, EventArgs e)
        {

        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kullanıciadi_Click(object sender, EventArgs e)
        {
            kullanıciadi.Text = "";
        }

        private void sifre_Click(object sender, EventArgs e)
        {
            sifre.Text = "";
        }
    }
}
