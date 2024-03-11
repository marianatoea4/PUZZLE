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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void play(object sender, EventArgs e)
        { 
            Close();
           // Button b = (Button)sender;
            Form3 frm = new Form3();
            frm.ShowDialog();
           
        }
    }
}
