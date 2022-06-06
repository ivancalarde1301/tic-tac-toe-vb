using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        char turn = 'X';
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (btnOne.Text == "")
            {
                btnOne.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
                if (btnOne.Text == btnTwo.Text)
                {
                    if (btnOne.Text == btnThree.Text)
                    {
                        MessageBox.Show("Winner! " + btnOne.Text);
                    }
                }
                if (btnOne.Text == btnFour.Text)
                {
                    if (btnOne.Text == btnSeven.Text)
                    {
                        MessageBox.Show("Winner! " + btnOne.Text);
                    }
                }
                if (btnOne.Text == btnFive.Text)
                {
                    if (btnOne.Text == btnNine.Text)
                    {
                        MessageBox.Show("Winner! " + btnOne.Text);
                    }
                }
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (btnTwo.Text == "")
            {
                btnTwo.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
                if (btnTwo.Text == btnOne.Text)
                {
                    if (btnTwo.Text == btnThree.Text)
                    {
                        MessageBox.Show("Winner! " + btnTwo.Text);
                    }
                }
                if (btnTwo.Text == btnFive.Text)
                {
                    if (btnTwo.Text == btnEight.Text)
                    {
                        MessageBox.Show("Winner! " + btnTwo.Text);
                    }
                }
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (btnThree.Text == "")
            {
                btnThree.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
                if (btnThree.Text == btnTwo.Text)
                {
                    if (btnThree.Text == btnOne.Text)
                    {
                        MessageBox.Show("Winner! " + btnThree.Text);
                    }
                }
                if (btnThree.Text == btnSix.Text)
                {
                    if (btnThree.Text == btnNine.Text)
                    {
                        MessageBox.Show("Winner! " + btnThree.Text);
                    }
                }
                if (btnThree.Text == btnFive.Text)
                {
                    if (btnThree.Text == btnSeven.Text)
                    {
                        MessageBox.Show("Winner! " + btnThree.Text);
                    }
                }
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (btnFour.Text == "")
            {
                btnFour.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
                if (btnFour.Text == btnOne.Text)
                {
                    if (btnFour.Text == btnSeven.Text)
                    {
                        MessageBox.Show("Winner! " + btnFour.Text);
                    }
                }
                if (btnFour.Text == btnFive.Text)
                {
                    if (btnFour.Text == btnSix.Text)
                    {
                        MessageBox.Show("Winner! " + btnFour.Text);
                    }
                }
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (btnFive.Text == "")
            {
                btnFive.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
                if (btnFive.Text == btnTwo.Text)
                {
                    if (btnFive.Text == btnEight.Text)
                    {
                        MessageBox.Show("Winner! " + btnFive.Text);
                    }
                }
                if (btnFive.Text == btnFour.Text)
                {
                    if (btnFive.Text == btnSix.Text)
                    {
                        MessageBox.Show("Winner! " + btnFive.Text);
                    }
                }
                if (btnFive.Text == btnOne.Text)
                {
                    if (btnFive.Text == btnNine.Text)
                    {
                        MessageBox.Show("Winner! " + btnFive.Text);
                    }
                }
                if (btnFive.Text == btnThree.Text)
                {
                    if (btnFive.Text == btnSeven.Text)
                    {
                         MessageBox.Show("Winner! " + btnFive.Text);
                    }
                }
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (btnSix.Text == "")
            {
                btnSix.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
                if (btnSix.Text == btnThree.Text)
                {
                    if (btnSix.Text == btnNine.Text)
                    {
                        MessageBox.Show("Winner! " + btnSix.Text);
                    }
                }
                if (btnSix.Text == btnFive.Text)
                {
                    if (btnSix.Text == btnFour.Text)
                    {
                        MessageBox.Show("Winner! " + btnSix.Text);
                    }
                }
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (btnSeven.Text == "")
            {
                btnSeven.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
                if (btnSeven.Text == btnFour.Text)
                {
                    if (btnSeven.Text == btnOne.Text)
                    {
                        MessageBox.Show("Winner! " + btnSeven.Text);
                    }
                }
                if (btnSeven.Text == btnFive.Text)
                {
                    if (btnSeven.Text == btnThree.Text)
                    {
                        MessageBox.Show("Winner! " + btnSeven.Text);
                    }
                }
                if (btnSeven.Text == btnEight.Text)
                {
                    if (btnSeven.Text == btnNine.Text)
                    {
                        MessageBox.Show("Winner! " + btnSeven.Text);
                    }
                }
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (btnEight.Text == "")
            {
                btnEight.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
                if (btnEight.Text == btnFive.Text)
                {
                    if (btnEight.Text == btnTwo.Text)
                    {
                        MessageBox.Show("Winner! " + btnEight.Text);
                    }
                }
                if (btnEight.Text == btnSeven.Text)
                {
                    if (btnEight.Text == btnNine.Text)
                    {
                        MessageBox.Show("Winner! " + btnEight.Text);
                    }
                }
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (btnNine.Text == "")
            {
                btnNine.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }
    }
}
