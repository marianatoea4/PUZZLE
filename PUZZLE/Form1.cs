using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = false;    
            button5.Visible=false;
            button6.Visible=false;
            textBox5.Visible = false;
            label7.Visible = false;
        }

        private void login(object sender, EventArgs e)
        {
            
        }

        private void cont_jucator(object sender, EventArgs e)
        {
            if (textBox1.Text == "jucator" && textBox2.Text == "jucator")
            {
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                textBox5.Visible = true;
                label7.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            else
                MessageBox.Show("Nume utilizator sau parolă gresită!! Vă rugăm reluati!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cont_admin(object sender, EventArgs e)
        {
            if (textBox3.Text == "administrator" && textBox4.Text == "administrator")
            {
                button6.Visible = true;
                button5.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            else
                MessageBox.Show("Nume utilizator sau parolă gresită!! Vă rugăm reluati!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void iesire(object sender, EventArgs e)
        {
            Close();
        }

        private void start_joc(object sender, EventArgs e)
        {
            //Button b = (Button)sender;
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void clasament(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
        }
    }
}
