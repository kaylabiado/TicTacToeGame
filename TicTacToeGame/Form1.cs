using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        private TicToe ticToe;

        public Form1()
        {
            InitializeComponent();
            Button[,] buttons = new Button[3, 3] { { button1, button2, button3 }, { button4, button5, button6 }, { button7, button8, button9 } };
            ticToe = new TicToe(buttons);
            AttachButtonClickEvents();
        }

        private void AttachButtonClickEvents()
        {
            foreach (Button button in Controls)
            {
                if (button.Name.StartsWith("button"))
                {
                    button.Click += ButtonClick;
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int row = (int)char.GetNumericValue(button.Name[button.Name.Length - 2]) - 1;
            int col = (int)char.GetNumericValue(button.Name[button.Name.Length - 1]) - 1;
            ticToe.MakeMove(row, col);
            ticToe.UpdateUI(); // Update the UI after each move
        }

        private void NewGameButtonClick(object sender, EventArgs e)
        {
            // Implement logic for new game button click
            ticToe = new TicToe(new Button[3, 3] { { button1, button2, button3 }, { button4, button5, button6 }, { button7, button8, button9 } });
            ticToe.UpdateUI();
        }
    }



}
