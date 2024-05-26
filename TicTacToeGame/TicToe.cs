using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public class TicToe : TicTac
    {
        private Button[,] buttons;

        public TicToe(Button[,] buttons) : base()
        {
            this.buttons = buttons;
            UpdateUI();
        }

        protected override void InitializeBoard()
        {
            base.InitializeBoard();
            // Additional initialization logic for TicToe
        }

        public void UpdateUI()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = board[i, j].ToString();
                    buttons[i, j].Enabled = !GameEnded && board[i, j] == ' ';
                }
            }
        }

        public override void MakeMove(int row, int col)
        {
            if (!GameEnded && board[row, col] == ' ')
            {
                board[row, col] = PlayerX ? 'X' : 'O';
                playerX = !playerX;
                CheckWinner();
            }
        }

        protected override void OnGameOver()
        {
            MessageBox.Show("Game Over!");
            // Implement additional logic for the end of the game
            base.OnGameOver();
        }
    }
}
