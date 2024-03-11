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
    public partial class Form3 : Form
    {

        int inNullSliceIndex;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
       /* public Form3()
        {
            InitializeComponent();
        }*/

        public Form3()
        {
            InitializeComponent();
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._null });
           
            label1.Text = "00:00:00";
        }

        void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });//8 is not present - since it is the last slice.
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)groupBox1.Controls[i]).Image = lstOriginalPictureList[j];
                    if (j == 9) inNullSliceIndex = i;//store empty picture box index
                }
            } while (CheckWin());
        }

        bool CheckWin()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((groupBox1.Controls[i] as PictureBox).Image != lstOriginalPictureList[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }

        public void schimba_imag(object sender, EventArgs e)
        {
            if (label1.Text == "00:00:00")
                timer.Start();
            int inPictureBoxIndex = groupBox1.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int>(new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (FourBrothers.Contains(inNullSliceIndex))
                {
                    ((PictureBox)groupBox1.Controls[inNullSliceIndex]).Image = ((PictureBox)groupBox1.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)groupBox1.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    
                    if (CheckWin())
                    {
                        timer.Stop();
                        (groupBox1.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                        MessageBox.Show("Congratulations...\nYour Rabbit Is Happy\nTime Elapsed : " + timer.Elapsed.ToString().Remove(8));
                       
                        label1.Text = "00:00:00";
                        timer.Reset();
                        Shuffle();
                    }
                }
            }
        }

        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                label1.Text = timer.Elapsed.ToString().Remove(8);
           
            if (timer.Elapsed.Minutes.ToString() == "1")
            {
                timer.Reset();
                
                label1.Text = "00:00:00";
                MessageBox.Show("Time Is Up\nTry Again", "Rabbit Puzzle");
                Shuffle();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Shuffle();
        }
    }
}
