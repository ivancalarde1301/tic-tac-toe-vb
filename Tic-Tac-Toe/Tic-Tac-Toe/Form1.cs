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
                    btnOne.BackColor = Color.PaleVioletRed;
                    turn = 'O';
                }
                else
                {
                    btnOne.BackColor = Color.LightBlue;
                    turn = 'X';
                }
                if (btnOne.Text == btnTwo.Text)
                {
                    if (btnOne.Text == btnThree.Text)
                    {
                        btnOne.BackColor = Color.LightGreen;
                        btnTwo.BackColor = Color.LightGreen;
                        btnThree.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnOne.Text == btnFour.Text)
                {
                    if (btnOne.Text == btnSeven.Text)
                    {
                        btnOne.BackColor = Color.LightGreen;
                        btnFour.BackColor = Color.LightGreen;
                        btnSeven.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnOne.Text == btnFive.Text)
                {
                    if (btnOne.Text == btnNine.Text)
                    {
                        btnOne.BackColor = Color.LightGreen;
                        btnFive.BackColor = Color.LightGreen;
                        btnNine.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
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
                    btnTwo.BackColor = Color.PaleVioletRed;
                    turn = 'O';
                }
                else
                {
                    btnTwo.BackColor = Color.LightBlue;
                    turn = 'X';
                }
                if (btnTwo.Text == btnOne.Text)
                {
                    if (btnTwo.Text == btnThree.Text)
                    {
                        btnTwo.BackColor = Color.LightGreen;
                        btnOne.BackColor = Color.LightGreen;
                        btnThree.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnTwo.Text == btnFive.Text)
                {
                    if (btnTwo.Text == btnEight.Text)
                    {
                        btnTwo.BackColor = Color.LightGreen;
                        btnFive.BackColor = Color.LightGreen;
                        btnEight.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
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
                    btnThree.BackColor = Color.PaleVioletRed;
                    turn = 'O';
                }
                else
                {
                    btnThree.BackColor = Color.LightBlue;
                    turn = 'X';
                }
                if (btnThree.Text == btnTwo.Text)
                {
                    if (btnThree.Text == btnOne.Text)
                    {
                        btnThree.BackColor = Color.Green;
                        btnTwo.BackColor = Color.Green;
                        btnOne.BackColor = Color.Green;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnThree.Text == btnSix.Text)
                {
                    if (btnThree.Text == btnNine.Text)
                    {
                        btnThree.BackColor = Color.LightGreen;
                        btnSix.BackColor = Color.LightGreen;
                        btnNine.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnThree.Text == btnFive.Text)
                {
                    if (btnThree.Text == btnSeven.Text)
                    {
                        btnThree.BackColor = Color.LightGreen;
                        btnFive.BackColor = Color.LightGreen;
                        btnSeven.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
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
                    btnFour.BackColor = Color.PaleVioletRed;
                    turn = 'O';
                }
                else
                {
                    btnFour.BackColor = Color.LightBlue;
                    turn = 'X';
                }
                if (btnFour.Text == btnOne.Text)
                {
                    if (btnFour.Text == btnSeven.Text)
                    {
                        btnFour.BackColor = Color.LightGreen;
                        btnOne.BackColor = Color.LightGreen;
                        btnSeven.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnFour.Text == btnFive.Text)
                {
                    if (btnFour.Text == btnSix.Text)
                    {
                        btnFour.BackColor = Color.LightGreen;
                        btnFive.BackColor = Color.LightGreen;
                        btnSix.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
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
                    btnFive.BackColor = Color.PaleVioletRed;
                    turn = 'O';
                }
                else
                {
                    btnFive.BackColor = Color.LightBlue;
                    turn = 'X';
                }
                if (btnFive.Text == btnTwo.Text)
                {
                    if (btnFive.Text == btnEight.Text)
                    {
                        btnFive.BackColor = Color.LightGreen;
                        btnTwo.BackColor = Color.LightGreen;
                        btnEight.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnFive.Text == btnFour.Text)
                {
                    if (btnFive.Text == btnSix.Text)
                    {
                        btnFive.BackColor = Color.LightGreen;
                        btnFour.BackColor = Color.LightGreen;
                        btnSix.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnFive.Text == btnOne.Text)
                {
                    if (btnFive.Text == btnNine.Text)
                    {
                        btnFive.BackColor = Color.LightGreen;
                        btnOne.BackColor = Color.LightGreen;
                        btnNine.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnFive.Text == btnThree.Text)
                {
                    if (btnFive.Text == btnSeven.Text)
                    {
                        btnFive.BackColor = Color.LightGreen;
                        btnThree.BackColor = Color.LightGreen;
                        btnSeven.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
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
                    btnSix.BackColor = Color.PaleVioletRed;
                    turn = 'O';
                }
                else
                {
                    btnSix.BackColor = Color.LightBlue;
                    turn = 'X';
                }
                if (btnSix.Text == btnThree.Text)
                {
                    if (btnSix.Text == btnNine.Text)
                    {
                        btnSix.BackColor = Color.LightGreen;
                        btnThree.BackColor = Color.LightGreen;
                        btnNine.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnSix.Text == btnFive.Text)
                {
                    if (btnSix.Text == btnFour.Text)
                    {
                        btnSix.BackColor = Color.LightGreen;
                        btnFive.BackColor = Color.LightGreen;
                        btnFour.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
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
                    btnSeven.BackColor = Color.PaleVioletRed;
                    turn = 'O';
                }
                else
                {
                    btnSeven.BackColor = Color.LightBlue;
                    turn = 'X';
                }
                if (btnSeven.Text == btnFour.Text)
                {
                    if (btnSeven.Text == btnOne.Text)
                    {
                        btnSeven.BackColor = Color.LightGreen;
                        btnFour.BackColor = Color.LightGreen;
                        btnOne.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnSeven.Text == btnFive.Text)
                {
                    if (btnSeven.Text == btnThree.Text)
                    {
                        btnSeven.BackColor = Color.LightGreen;
                        btnFive.BackColor = Color.LightGreen;
                        btnThree.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnSeven.Text == btnEight.Text)
                {
                    if (btnSeven.Text == btnNine.Text)
                    {
                        btnSeven.BackColor = Color.LightGreen;
                        btnEight.BackColor = Color.LightGreen;
                        btnNine.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
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
                    btnEight.BackColor = Color.PaleVioletRed;
                    turn = 'O';
                }
                else
                {
                    btnEight.BackColor = Color.LightBlue;
                    turn = 'X';
                }
                if (btnEight.Text == btnFive.Text)
                {
                    if (btnEight.Text == btnTwo.Text)
                    {
                        btnEight.BackColor = Color.LightGreen;
                        btnFive.BackColor = Color.LightGreen;
                        btnTwo.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnEight.Text == btnSeven.Text)
                {
                    if (btnEight.Text == btnNine.Text)
                    {
                        btnEight.BackColor = Color.LightGreen;
                        btnSeven.BackColor = Color.LightGreen;
                        btnNine.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
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
                    btnNine.BackColor = Color.PaleVioletRed;
                    turn = 'O';
                }
                else
                {
                    btnNine.BackColor = Color.LightBlue;
                    turn = 'X';
                }
                if (btnNine.Text == btnSix.Text)
                {
                    if (btnNine.Text == btnThree.Text)
                    {
                        btnNine.BackColor = Color.LightGreen;
                        btnSix.BackColor = Color.LightGreen;
                        btnThree.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnNine.Text == btnEight.Text)
                {
                    if (btnNine.Text == btnSeven.Text)
                    {
                        btnNine.BackColor = Color.LightGreen;
                        btnEight.BackColor = Color.LightGreen;
                        btnSeven.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
                if (btnNine.Text == btnFive.Text)
                {
                    if (btnNine.Text == btnOne.Text)
                    {
                        btnNine.BackColor = Color.LightGreen;
                        btnFive.BackColor = Color.LightGreen;
                        btnOne.BackColor = Color.LightGreen;
                        MessageBox.Show("Winner!", "Game Over!");
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnOne.Enabled = true;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;

            btnOne.Text = "";
            btnTwo.Text = "";
            btnThree.Text = "";
            btnFour.Text = "";
            btnFive.Text = "";
            btnSix.Text = "";
            btnSeven.Text = "";
            btnEight.Text = "";
            btnNine.Text = "";

                turn = 'X';

            btnOne.BackColor = Color.White;
            btnTwo.BackColor = Color.White;
            btnThree.BackColor = Color.White;
            btnFour.BackColor = Color.White;
            btnFive.BackColor = Color.White;
            btnSix.BackColor = Color.White;
            btnSeven.BackColor = Color.White;
            btnEight.BackColor = Color.White;
            btnNine.BackColor = Color.White;
        }
    }
}
