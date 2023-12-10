using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toc.Properties;

namespace Tic_Tac_Toc
{
    public partial class Form1 : Form
    {

        stGameStatus Gamestatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer {Player1, Player2};
        enum enWinner
        {
            player1,
            player2,
            draw,
            GameinProgress
        }
        struct stGameStatus
        {
           public  bool GameOver;
           public short GameCount;
           public enWinner Winner;   
        }

        private void EndOfGame()
        {
            lblPlayerTurn.Text = "Game Over";

            switch (Gamestatus.Winner)
            {
                case enWinner.player1:
                    lblWinner.Text = "Player 1";
                    break;
                case enWinner.player2:
                    lblWinner.Text = "Player 2";
                    break;
                default:
                    lblWinner.Text = "Draw";
                    break;
            }
            MessageBox.Show("Game over", "Game Over",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void RestButtom(Button btm)
        {
            btm.Tag = "?";
            btm.Image = Resources.question_mark_96;
            btm.BackColor = Color.Transparent;
        }

        private void RestartGame()
        {
            RestButtom(btm1);
            RestButtom(btm2);
            RestButtom(btm3);
            RestButtom(btm4);
            RestButtom(btm5);
            RestButtom(btm6);
            RestButtom(btm7);
            RestButtom(btm8);
            RestButtom(btm9);

            Gamestatus.GameOver = false;
            Gamestatus.GameCount = 0;
            PlayerTurn = enPlayer.Player1;
            lblWinner.Text = "In Progress";
            lblPlayerTurn.Text = "Player 1";
            Gamestatus.Winner = enWinner.GameinProgress;
        }


        private bool CheckValue(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                Gamestatus.GameOver = true;

                if (btn1.Tag.ToString() == "X")
                {
                    Gamestatus.Winner = enWinner.player1;
                    EndOfGame();
                    return (true);
                }
                else
                {
                    Gamestatus.Winner = enWinner.player2;
                    EndOfGame();
                    return (true);
                }
                
            }
            Gamestatus.GameOver = false;
            return (false);
        }

        private void CheckWinner()
        {
            //horizontal
            if (CheckValue(btm1, btm2, btm3))
                return;

            if (CheckValue(btm4, btm5, btm6))
                return;

            if (CheckValue(btm7, btm8, btm9))
                return;

            //vertical

            if (CheckValue(btm1, btm4, btm7))
                return;

            if (CheckValue(btm2, btm5, btm8))
                return;

            if (CheckValue(btm3, btm6, btm9))
                return;

            //diagonal

            if (CheckValue(btm1, btm5, btm9))
                return;

            if (CheckValue(btm3, btm5, btm7))
                return;
        }


        private void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        btn.Tag = "X";
                        PlayerTurn = enPlayer.Player2;
                        lblPlayerTurn.Text = "Player 2";
                        Gamestatus.GameCount++;
                        CheckWinner();
                        break;
                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        btn.Tag = "O";
                        PlayerTurn = enPlayer.Player1;
                        lblPlayerTurn.Text = "Player 1";
                        Gamestatus.GameCount++;
                        CheckWinner();
                        break;
                }
            }
            else
                MessageBox.Show("Wrong choice", "Wrong",MessageBoxButtons.OK,MessageBoxIcon.Information);

            if (Gamestatus.GameCount == 9)
            {
                Gamestatus.Winner = enWinner.draw;
                Gamestatus.GameOver = true;
                EndOfGame();
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        

        
        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen pen = new Pen(White);
            pen.Width = 7;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //Vertical
            e.Graphics.DrawLine(pen, 420, 100,420,400);
            e.Graphics.DrawLine(pen, 600, 100, 600, 400);

            //Horizental
            e.Graphics.DrawLine(pen, 280, 190, 740, 190);
            e.Graphics.DrawLine(pen, 280, 300, 740, 300);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttom_Click(object sender, EventArgs e)
        {
            ChangeImage((Button) sender);
        }
        private void btmRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
