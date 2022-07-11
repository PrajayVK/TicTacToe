using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Setbool();
        }
        bool[] previouslySelected=new bool[9];
        public void Setbool()
        {
            for(int i=0;i<previouslySelected.Length;i++)
            {
                previouslySelected[i] = false;
            }
        }
        String[] gameboard = new string[9];
        int CurrentTurn = 0;
        
        public String ReturnSymbol(int turn)
        {
            if(turn%2==0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
            
        }
        
        public void CheckForWinner()
        {
            String combination = "";
            for(int i=0; i<8;i++)
            {
                switch(i)
                {
                    case 0:
                        combination = gameboard[0] + gameboard[4] + gameboard[8];
                        break;
                    case 1:
                        combination = gameboard[2] + gameboard[4] + gameboard[6];
                        break;
                    case 2:
                        combination = gameboard[0] + gameboard[1] + gameboard[2];
                        break;
                    case 3:
                        combination = gameboard[3] + gameboard[4] + gameboard[5];
                        break;
                    case 4:
                        combination = gameboard[6] + gameboard[7] + gameboard[8];
                        break;
                    case 5:
                        combination = gameboard[0] + gameboard[3] + gameboard[6]; 
                        break;
                    case 6:
                        combination = gameboard[1] + gameboard[4] + gameboard[7];
                        break;
                    case 7:
                        combination = gameboard[2] + gameboard[5] + gameboard[8];
                        break;
                        
                }
                
                if (combination.Equals("OOO"))
                {
                    MessageBox.Show("O has won the game!","We have a winner.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    reset();
                }
                else if(combination.Equals("XXX"))
                {
                    MessageBox.Show("X has won the game!", "We have a winner.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    reset();
                }
                checkDraw();
            }
        }
        public void checkDraw()
        {
            int counter=0;
            for(int i=0;i<gameboard.Length;i++)
            {
                if (gameboard[i] != null) { counter++; }
                if(counter==9)
                {
                    reset();
                    MessageBox.Show("Draw!", "No Winner.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }
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
            gameboard = new string[9];
            CurrentTurn = 0;
            Setbool();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (!previouslySelected[0])
            {
                CurrentTurn++;
                gameboard[0] = ReturnSymbol(CurrentTurn);
                button1.Text = gameboard[0];
                CheckForWinner();
                previouslySelected[0] = true;
            }   
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!previouslySelected[1])
            {
                CurrentTurn++;
                gameboard[1] = ReturnSymbol(CurrentTurn);
                button2.Text = gameboard[1];
                CheckForWinner();
                previouslySelected[1] = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!previouslySelected[2])
            {
                CurrentTurn++;
                gameboard[2] = ReturnSymbol(CurrentTurn);
                button3.Text = gameboard[2];
                CheckForWinner();
                previouslySelected[2] = true;
            }        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!previouslySelected[3])
            {
                CurrentTurn++;
                gameboard[3] = ReturnSymbol(CurrentTurn);
                button4.Text = gameboard[3];
                CheckForWinner();
                previouslySelected[3] = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!previouslySelected[4])
            {
                CurrentTurn++;
                gameboard[4] = ReturnSymbol(CurrentTurn);
                button5.Text = gameboard[4];
                CheckForWinner();
                previouslySelected[4] = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!previouslySelected[5])
            {
                CurrentTurn++;
                gameboard[5] = ReturnSymbol(CurrentTurn);
                button6.Text = gameboard[5];
                CheckForWinner();
                previouslySelected[5] = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!previouslySelected[6])
            {
                CurrentTurn++;
                gameboard[6] = ReturnSymbol(CurrentTurn);
                button7.Text = gameboard[6];
                CheckForWinner();
                previouslySelected[6]=true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!previouslySelected[7])
            {
                CurrentTurn++;
                gameboard[7] = ReturnSymbol(CurrentTurn);
                button8.Text = gameboard[7];
                CheckForWinner();
                previouslySelected[7] = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!previouslySelected[8])
            {
                CurrentTurn++;
                gameboard[8] = ReturnSymbol(CurrentTurn);
                button9.Text = gameboard[8];
                CheckForWinner();
                previouslySelected[8] = true;
            }
        }
    }
}
