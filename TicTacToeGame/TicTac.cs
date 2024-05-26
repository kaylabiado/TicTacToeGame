using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public abstract class TicTac
    {
        protected char[,] board;
        protected bool playerX;
        protected bool gameEnded;

        public TicTac()
        {
            board = new char[3, 3];
            playerX = true;
            gameEnded = false;
            InitializeBoard();
        }

        public char[,] Board => board;

        public bool GameEnded => gameEnded;

        public bool PlayerX => playerX;

        public abstract void MakeMove(int row, int col);

        public event EventHandler GameOver;

        protected virtual void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }

        protected void CheckWinner()
        {
            // Check for winner logic here

            // If there's a winner or the board is full, set gameEnded to true
            gameEnded = true;

            // Raise GameOver event
            OnGameOver();
        }

        protected virtual void OnGameOver()
        {
            GameOver?.Invoke(this, EventArgs.Empty);
        }
    }   
}
