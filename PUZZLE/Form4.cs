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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            richTextBox1.Text += '\n';
            richTextBox1.Text += "Vasile 07:23 9";
            richTextBox1.Text += '\n';
            richTextBox1.Text += "Ilie 12:44 9";
        }
    }
}
