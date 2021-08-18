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
        public Form1()
        {
            InitializeComponent();
        }

        //Different color for different player
        public System.Drawing.Color BgColor(string symbol)
        {
            if (symbol.Equals("0"))
            {
                return System.Drawing.Color.DarkSeaGreen;
            }
            else
                return System.Drawing.Color.CadetBlue;
        }

        //Winning Condition check
        public void checkWinner()
        {
            for(int i=0; i<8; i++)
            {
                String combination = "";
                int one=0, two=0, three=0;

                switch(i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        one = 0;
                        two = 4;
                        three = 8;
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        one = 2;
                        two = 4;
                        three = 6;
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        one = 0;
                        two = 1;
                        three = 2;
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        one = 3;
                        two = 4;
                        three = 5;
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        one = 6;
                        two = 7;
                        three = 8;
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        one = 0;
                        two = 3;
                        three = 6;
                        break;
                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        one = 1;
                        two = 4;
                        three = 7;
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        one = 2;
                        two = 5;
                        three = 8;
                        break;
                }

                //winning stack
                if(combination.Equals("000"))
                {
                    changeColor(one);
                    changeColor(two);
                    changeColor(three);

                    MessageBox.Show("2nd Player won the game", "We Have a Winner!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (combination.Equals("XXX"))
                {
                    changeColor(one);
                    changeColor(two);
                    changeColor(three);

                    MessageBox.Show("1st Player won the game", "We Have a Winner!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            checkDraw();
        }

        //Winning line changes color
        public void changeColor(int number)
        {
            switch(number)
            {
                case 0:
                    button1.BackColor = System.Drawing.Color.Firebrick;
                    break;
                case 1:
                    button2.BackColor = System.Drawing.Color.Firebrick;
                    break;
                case 2:
                    button3.BackColor = System.Drawing.Color.Firebrick;
                    break;
                case 3:
                    button4.BackColor = System.Drawing.Color.Firebrick;
                    break;
                case 4:
                    button5.BackColor = System.Drawing.Color.Firebrick;
                    break;
                case 5:
                    button6.BackColor = System.Drawing.Color.Firebrick;
                    break;
                case 6:
                    button7.BackColor = System.Drawing.Color.Firebrick;
                    break;
                case 7:
                    button8.BackColor = System.Drawing.Color.Firebrick;
                    break;
                case 8:
                    button9.BackColor = System.Drawing.Color.Firebrick;
                    break;
            }
        }

        //Draw finder
        public void checkDraw()
        {
            int counter = 0;
            for(int i=0; i<gameBoard.Length; i++)
            {
                if(gameBoard[i] != null)
                {
                    counter++;
                }
                if(counter == 9)
                {
                    MessageBox.Show("Match Drawn", "No Winner :(",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //Reset all values
        public void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = System.Drawing.Color.WhiteSmoke;
            button2.BackColor = System.Drawing.Color.WhiteSmoke;
            button3.BackColor = System.Drawing.Color.WhiteSmoke;
            button4.BackColor = System.Drawing.Color.WhiteSmoke;
            button5.BackColor = System.Drawing.Color.WhiteSmoke;
            button6.BackColor = System.Drawing.Color.WhiteSmoke;
            button7.BackColor = System.Drawing.Color.WhiteSmoke;
            button8.BackColor = System.Drawing.Color.WhiteSmoke;
            button9.BackColor = System.Drawing.Color.WhiteSmoke;

            gameBoard = new string[9];
            cur_turn = 0;

        }

        string[] gameBoard = new string[9];
        int cur_turn = 0;

        //Symbol
        public string returnSymbol(int turn)
        {
            if(turn % 2 == 0)
            {
                return "0";
            }
            else
            {
                return "X";
            }
        }

        // Nine Buttons for Game Board
        private void button1_Click(object sender, EventArgs e)
        {
            cur_turn++;
            gameBoard[0] = returnSymbol(cur_turn);
            Color btn_clr = BgColor(gameBoard[0]);
            button1.BackColor = btn_clr;
            button1.Text = gameBoard[0];
            checkWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cur_turn++;
            gameBoard[1] = returnSymbol(cur_turn);
            Color btn_clr = BgColor(gameBoard[1]);
            button2.BackColor = btn_clr;
            button2.Text = gameBoard[1];
            checkWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cur_turn++;
            gameBoard[2] = returnSymbol(cur_turn);
            Color btn_clr = BgColor(gameBoard[2]);
            button3.BackColor = btn_clr;
            button3.Text = gameBoard[2];
            checkWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cur_turn++;
            gameBoard[3] = returnSymbol(cur_turn);
            Color btn_clr = BgColor(gameBoard[3]);
            button4.BackColor = btn_clr;
            button4.Text = gameBoard[3];
            checkWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cur_turn++;
            gameBoard[4] = returnSymbol(cur_turn);
            Color btn_clr = BgColor(gameBoard[4]);
            button5.BackColor = btn_clr;
            button5.Text = gameBoard[4];
            checkWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cur_turn++;
            gameBoard[5] = returnSymbol(cur_turn);
            Color btn_clr = BgColor(gameBoard[5]);
            button6.BackColor = btn_clr;
            button6.Text = gameBoard[5];
            checkWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cur_turn++;
            gameBoard[6] = returnSymbol(cur_turn);
            Color btn_clr = BgColor(gameBoard[6]);
            button7.BackColor = btn_clr;
            button7.Text = gameBoard[6];
            checkWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cur_turn++;
            gameBoard[7] = returnSymbol(cur_turn);
            Color btn_clr = BgColor(gameBoard[7]);
            button8.BackColor = btn_clr;
            button8.Text = gameBoard[7];
            checkWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cur_turn++;
            gameBoard[8] = returnSymbol(cur_turn);
            Color btn_clr = BgColor(gameBoard[8]);
            button9.BackColor = btn_clr;
            button9.Text = gameBoard[8];
            checkWinner();
        }

        //Restart button
        private void button10_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
