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
            }
        }

        private void btnNine_Click(
            object sender, EventArgs e)
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
