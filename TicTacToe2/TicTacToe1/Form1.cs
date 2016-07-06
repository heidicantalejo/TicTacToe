using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe1
{
    public partial class Form1 : Form
    {

        string userTurn = "X";
        string compTurn = "O";

        public Form1()
        {
            InitializeComponent();            
        }
        public void chkX_CheckedChanged(object sender, EventArgs e)
        {   
            if (chkX.Checked)
            {
                userTurn = "X";
                compTurn = "O";
            }
            else
            {
                userTurn = "O";
                compTurn = "X";
            }
            chkX.Enabled = false;
            computerMove();
        }
        private void btnA1_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender; //tells the program that the sender is a button, so we can access all of the button functions
            clickedButton.Text = userTurn;
            clickedButton.Enabled = false;
            chkX.Enabled = false;

            if (checkVictory(userTurn))
            {
                lblWinner.Text = "You win!";
                endGame();
            }
            else
            {
                computerMove();
            }
        }

        public void endGame()
        {
            btnA1.Enabled = false;
            btnA2.Enabled = false;
            btnA3.Enabled = false;
            btnB1.Enabled = false;
            btnB2.Enabled = false;
            btnB3.Enabled = false;
            btnC1.Enabled = false;
            btnC2.Enabled = false;
            btnC3.Enabled = false;
        }

        private void computerMove()
        {
            int milliseconds = 1000;
            Thread.Sleep(milliseconds);

            if (findWin())
            {
                lblWinner.Text = "You lose!";
                endGame();
            }
            else
            {
                if (!blockWin())
                {
                    findVacant();
                }
                //check for win
                if (checkVictory(compTurn))
                {
                    lblWinner.Text = "You lose!";
                    endGame();
                }
                else if (btnA1.Enabled == false &&
                        btnA2.Enabled == false &&
                        btnA3.Enabled == false &&
                        btnB1.Enabled == false &&
                        btnB2.Enabled == false &&
                        btnB3.Enabled == false &&
                        btnC1.Enabled == false &&
                        btnC2.Enabled == false &&
                        btnC3.Enabled == false)
                {
                    lblWinner.Text = "It's a tie!";
                }
            }
        }
        private void findVacant()
        {
            if (btnA1.Text == "")
            {
                btnA1.Text = compTurn;
                btnA1.Enabled = false;
            }
            else if (btnA2.Text == "")
            {
                btnA2.Text = compTurn;
                btnA2.Enabled = false;
            }
            else if (btnA3.Text == "")
            {
                btnA3.Text = compTurn;
                btnA3.Enabled = false;
            }
            else if (btnB1.Text == "")
            {
                btnB1.Text = compTurn;
                btnB1.Enabled = false;
            }
            else if (btnB2.Text == "")
            {
                btnB2.Text = compTurn;
                btnB2.Enabled = false;
            }
            else if (btnB3.Text == "")
            {
                btnB3.Text = compTurn;
                btnB3.Enabled = false;
            }
            else if (btnC1.Text == "")
            {
                btnC1.Text = compTurn;
                btnC1.Enabled = false;
            }
            else if (btnC2.Text == "")
            {
                btnC2.Text = compTurn;
                btnC2.Enabled = false;
            }
            else if (btnC3.Text == "")
            {
                btnC3.Text = compTurn;
                btnC3.Enabled = false;
            }
        }


        private bool blockWin()
        {
            if(btnA1.Text == userTurn && btnB1.Text == userTurn && btnC1.Enabled == true)
            {
                btnC1.Text = compTurn;
                btnC1.Enabled = false;
                return true;
            }
            else if (btnB1.Text == userTurn && btnC1.Text == userTurn && btnA1.Enabled == true)
            {
                btnA1.Text = compTurn;
                btnA1.Enabled = false;
                return true;
            }
            else if (btnA1.Text == userTurn && btnC1.Text == userTurn && btnB1.Enabled == true)
            {
                btnB1.Text = compTurn;
                btnB1.Enabled = false;
                return true;
            }
            else if (btnA2.Text == userTurn && btnB2.Text == userTurn && btnC2.Enabled == true)
            {
                btnC2.Text = compTurn;
                btnC2.Enabled = false;
                return true;
            }
            else if (btnB2.Text == userTurn && btnC2.Text == userTurn && btnA2.Enabled == true)
            {
                btnA2.Text = compTurn;
                btnA2.Enabled = false;
                return true;
            }
            else if (btnA2.Text == userTurn && btnC2.Text == userTurn && btnB2.Enabled == true)
            {
                btnB2.Text = compTurn;
                btnB2.Enabled = false;
                return true;
            }
            else if (btnA3.Text == userTurn && btnB3.Text == userTurn && btnC3.Enabled == true)
            {
                btnC3.Text = compTurn;
                btnC3.Enabled = false;
                return true;
            }
            else if (btnB3.Text == userTurn && btnC3.Text == userTurn && btnA3.Enabled == true)
            {
                btnA3.Text = compTurn;
                btnA3.Enabled = false;
                return true;
            }
            else if (btnA3.Text == userTurn && btnC3.Text == userTurn && btnB3.Enabled == true)
            {
                btnB3.Text = compTurn;
                btnB3.Enabled = false;
                return true;
            }
            else if (btnA1.Text == userTurn && btnA2.Text == userTurn && btnA3.Enabled == true)
            {
                btnA3.Text = compTurn;
                btnA3.Enabled = false;
                return true;
            }
            else if (btnA2.Text == userTurn && btnA3.Text == userTurn && btnA1.Enabled == true)
            {
                btnA1.Text = compTurn;
                btnA1.Enabled = false;
                return true;
            }
            else if (btnA1.Text == userTurn && btnA3.Text == userTurn && btnA2.Enabled == true)
            {
                btnA2.Text = compTurn;
                btnA2.Enabled = false;
                return true;
            }
            else if (btnB1.Text == userTurn && btnB2.Text == userTurn && btnB3.Enabled == true)
            {
                btnB3.Text = compTurn;
                btnB3.Enabled = false;
                return true;
            }
            else if (btnB2.Text == userTurn && btnB3.Text == userTurn && btnB1.Enabled == true)
            {
                btnB1.Text = compTurn;
                btnB1.Enabled = false;
                return true;
            }
            else if (btnB1.Text == userTurn && btnB3.Text == userTurn && btnB2.Enabled == true)
            {
                btnB2.Text = compTurn;
                btnB2.Enabled = false;
                return true;
            }
            else if (btnC1.Text == userTurn && btnC2.Text == userTurn && btnC3.Enabled == true)
            {
                btnC3.Text = compTurn;
                btnC3.Enabled = false;
                return true;
            }
            else if (btnC2.Text == userTurn && btnC3.Text == userTurn && btnC1.Enabled == true)
            {
                btnC1.Text = compTurn;
                btnC1.Enabled = false;
                return true;
            }
            else if (btnC1.Text == userTurn && btnC3.Text == userTurn && btnC2.Enabled == true)
            {
                btnC2.Text = compTurn;
                btnC2.Enabled = false;
                return true;
            }
            else if (btnA1.Text == userTurn && btnB2.Text == userTurn && btnC3.Enabled == true)
            {
                btnC3.Text = compTurn;
                btnC3.Enabled = false;
                return true;
            }
            else if (btnB2.Text == userTurn && btnC3.Text == userTurn && btnA1.Enabled == true)
            {
                btnA1.Text = compTurn;
                btnA1.Enabled = false;
                return true;
            }
            else if (btnA1.Text == userTurn && btnC3.Text == userTurn && btnB2.Enabled == true)
            {
                btnB2.Text = compTurn;
                btnB2.Enabled = false;
                return true;
            }
            else if (btnA3.Text == userTurn && btnB2.Text == userTurn && btnC1.Enabled == true)
            {
                btnC1.Text = compTurn;
                btnC1.Enabled = false;
                return true;
            }
            else if (btnB2.Text == userTurn && btnC1.Text == userTurn && btnA3.Enabled == true)
            {
                btnA3.Text = compTurn;
                btnA3.Enabled = false;
                return true;
            }
            else if (btnA3.Text == userTurn && btnC1.Text == userTurn && btnB2.Enabled == true)
            {
                btnB2.Text = compTurn;
                btnB2.Enabled = false;
                return true;
            }            
            return false;
        }

        private bool findWin()
        {
            if (btnA1.Text == compTurn && btnB1.Text == compTurn && btnC1.Enabled == true)
            {
                btnC1.Text = compTurn;
                return true;
            }
            else if (btnB1.Text == compTurn && btnC1.Text == compTurn && btnA1.Enabled == true)
            {
                btnA1.Text = compTurn;
                return true;
            }
            else if (btnA1.Text == compTurn && btnC1.Text == compTurn && btnB1.Enabled == true)
            {
                btnB1.Text = compTurn;
                return true;
            }
            else if (btnA2.Text == compTurn && btnB2.Text == compTurn && btnC2.Enabled == true)
            {
                btnC2.Text = compTurn;
                return true;
            }
            else if (btnB2.Text == compTurn && btnC2.Text == compTurn && btnA2.Enabled == true)
            {
                btnA2.Text = compTurn;
                return true;
            }
            else if (btnA2.Text == compTurn && btnC2.Text == compTurn && btnB2.Enabled == true)
            {
                btnB2.Text = compTurn;
                return true;
            }
            else if (btnA3.Text == compTurn && btnB3.Text == compTurn && btnC3.Enabled == true)
            {
                btnC3.Text = compTurn;
                return true;
            }
            else if (btnB3.Text == compTurn && btnC3.Text == compTurn && btnA3.Enabled == true)
            {
                btnA3.Text = compTurn;
                return true;
            }
            else if (btnA3.Text == compTurn && btnC3.Text == compTurn && btnB3.Enabled == true)
            {
                btnB3.Text = compTurn;
                return true;
            }
            else if (btnA1.Text == compTurn && btnA2.Text == compTurn && btnA3.Enabled == true)
            {
                btnA3.Text = compTurn;
                return true;
            }
            else if (btnA2.Text == compTurn && btnA3.Text == compTurn && btnA1.Enabled == true)
            {
                btnA1.Text = compTurn;
                return true;
            }
            else if (btnA1.Text == compTurn && btnA3.Text == compTurn && btnA2.Enabled == true)
            {
                btnA2.Text = compTurn;
                return true;
            }
            else if (btnB1.Text == compTurn && btnB2.Text == compTurn && btnB3.Enabled == true)
            {
                btnB3.Text = compTurn;
                return true;
            }
            else if (btnB2.Text == compTurn && btnB3.Text == compTurn && btnB1.Enabled == true)
            {
                btnB1.Text = compTurn;
                return true;
            }
            else if (btnB1.Text == compTurn && btnB3.Text == compTurn && btnB2.Enabled == true)
            {
                btnB2.Text = compTurn;
                return true;
            }
            else if (btnC1.Text == compTurn && btnC2.Text == compTurn && btnC3.Enabled == true)
            {
                btnC3.Text = compTurn;
                return true;
            }
            else if (btnC2.Text == compTurn && btnC3.Text == compTurn && btnC1.Enabled == true)
            {
                btnC1.Text = compTurn;
                return true;
            }
            else if (btnC1.Text == compTurn && btnC3.Text == compTurn && btnC2.Enabled == true)
            {
                btnC2.Text = compTurn;
                return true;
            }
            else if (btnA1.Text == compTurn && btnB2.Text == compTurn && btnC3.Enabled == true)
            {
                btnC3.Text = compTurn;
                return true;
            }
            else if (btnB2.Text == compTurn && btnC3.Text == compTurn && btnA1.Enabled == true)
            {
                btnA1.Text = compTurn;
                return true;
            }
            else if (btnA1.Text == compTurn && btnC3.Text == compTurn && btnB2.Enabled == true)
            {
                btnB2.Text = compTurn;
                return true;
            }
            else if (btnA3.Text == compTurn && btnB2.Text == compTurn && btnC1.Enabled == true)
            {
                btnC1.Text = compTurn;
                return true;
            }
            else if (btnB2.Text == compTurn && btnC1.Text == compTurn && btnA3.Enabled == true)
            {
                btnA3.Text = compTurn;
                return true;
            }
            else if (btnA3.Text == compTurn && btnC1.Text == compTurn && btnB2.Enabled == true)
            {
                btnB2.Text = compTurn;
                return true;
            }
            return false;
        }

        private bool checkVictory(string Turn)
        {
            if (btnA1.Text == Turn && btnA2.Text == Turn && btnA3.Text == Turn)
            {
                return true;
            }
            else if (btnB1.Text == Turn && btnB2.Text == Turn && btnB3.Text == Turn)
            {
                return true;
            }
            else if (btnC1.Text == Turn && btnC2.Text == Turn && btnC3.Text == Turn)
            {
                return true;
            }
            else if (btnA1.Text == Turn && btnB1.Text == Turn && btnC1.Text == Turn)
            {
                return true;
            }
            else if (btnA2.Text == Turn && btnB2.Text == Turn && btnC2.Text == Turn)
            {
                return true;
            }
            else if (btnA3.Text == Turn && btnB3.Text == Turn && btnC3.Text == Turn)
            {
                return true;
            }
            else if (btnA1.Text == Turn && btnB2.Text == Turn && btnC3.Text == Turn)
            {
                return true;
            }
            else if (btnA3.Text == Turn && btnB2.Text == Turn && btnC1.Text == Turn)
            {
                return true;
            }
            return false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnA1.Text = string.Empty;
            btnA1.Enabled = true;
            btnA2.Text = string.Empty;
            btnA2.Enabled = true;
            btnA3.Text = string.Empty;
            btnA3.Enabled = true;
            btnB1.Text = string.Empty;
            btnB1.Enabled = true;
            btnB2.Text = string.Empty;
            btnB2.Enabled = true;
            btnB3.Text = string.Empty;
            btnB3.Enabled = true;
            btnC1.Text = string.Empty;
            btnC1.Enabled = true;
            btnC2.Text = string.Empty;
            btnC2.Enabled = true;
            btnC3.Text = string.Empty;
            btnC3.Enabled = true;

            chkX.Enabled = true;
            string userTurn = "X";
            string compTurn = "O";

            lblWinner.Text = "";
        }
    }
}
