using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace UWeekBoxGame
{
    public partial class Game : Form
    {
        private const int Rows = 5;
        private const int Columns = 5;
        private const int TotalBoxes = Rows * Columns;
        private const int MaxAttempts = 3;
        private const int TotalBombs = 24;
        private const int TotalPrize = 1;

        private int remainingBombs;
        private int remainingPrize;
        private int remainingAttempts;
        private List<Box> boxes;

        public Game()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            remainingAttempts = MaxAttempts;
            remainingBombs = TotalBombs;
            remainingPrize = TotalPrize;

            UpdateAttempts();
            UpdateBombsLeft();
            UpdatePrizeLeft();
            CreateBoxes();
            MapButtonsToPrizes();
        }

        private void CreateBoxes()
        {
            tableBoxes.Controls.Clear();
            
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    var box = new Box();
                    box.BoxClickedWin += BoxClickedWin;
                    box.BoxClickedLose += BoxClickedLose;
                    tableBoxes.Controls.Add(box, j, i);
                }
            }
        }

        private void MapButtonsToPrizes()
        {
            boxes = tableBoxes.Controls.OfType<Box>().ToList();
            var random = new Random();
            var prizeIndex = random.Next(TotalBoxes - 1);
            boxes[prizeIndex].IsPrize = true;
        }

        private void BoxClickedWin(object sender, EventArgs e)
        {
            remainingPrize--;
            remainingAttempts--;
            UpdatePrizeLeft();
            UpdateAttempts();
            DisableBoxes();
            MessageDialog.Show(this, "Congratulations! You've won a major prize! Now, let's see what's in store for you...",
                    "Better Luck Next Time!", MessageDialogButtons.OK, MessageDialogIcon.None, MessageDialogStyle.Light);
        }

        private void BoxClickedLose(object sender, EventArgs e)
        {
            remainingAttempts--;
            remainingBombs--;

            UpdateAttempts();
            UpdateBombsLeft();

            if (remainingAttempts <= 0)
            {
                MessageDialog.Show(this, "Don't be sad! You've earned a consolation prize for giving it your best shot!",
                    "Better Luck Next Time!", MessageDialogButtons.OK, MessageDialogIcon.None, MessageDialogStyle.Light);
                DisableBoxes();
            }
        }

        private void DisableBoxes()
        {
            boxes.ForEach(box => box.Enabled = false);
        }

        private void UpdateAttempts()
        {
            lblAttempts.Text = remainingAttempts.ToString();
        }

        private void UpdateBombsLeft()
        {
            lblBomb.Text = remainingBombs.ToString();
        }

        private void UpdatePrizeLeft()
        {
            lblPrize.Text = remainingPrize.ToString();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }
    }
}
