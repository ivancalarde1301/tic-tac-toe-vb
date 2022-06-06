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

        private void btnTwo_Click(object sender, EventArgs e)
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

        private void btnThree_Click(object sender, EventArgs e)
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

        private void btnFour_Click(object sender, EventArgs e)
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

        private void btnFive_Click(object sender, EventArgs e)
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

        private void btnSix_Click(object sender, EventArgs e)
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

        private void btnSeven_Click(object sender, EventArgs e)
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

        private void btnEight_Click(object sender, EventArgs e)
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

        private void btnNine_Click(
            object sender, EventArgs e)
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }
    }
}
