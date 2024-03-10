using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UWeekBoxGame
{
    public partial class Box : UserControl
    {
        public event EventHandler BoxClickedWin;
        public event EventHandler BoxClickedLose;
        public bool IsPrize { get; set; } = false;

        public Box()
        {
            InitializeComponent();
        }

        private void btnBox_Click(object sender, EventArgs e)
        {
            if (IsPrize)
            {
                DisplayWin();
                BoxClickedWin?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                DisplayLose();
                BoxClickedLose?.Invoke(this, EventArgs.Empty);
            }
        }

        private void DisplayWin()
        {
            btnBox.Image = Image.FromFile("./assets/win.png");
            btnBox.FillColor = Color.FromArgb(250, 169, 25);
            btnBox.BorderColor = Color.FromArgb(215, 138, 0);

            btnBox.Enabled = false;
            btnBox.DisabledState.FillColor = Color.FromArgb(250, 169, 25);
            btnBox.DisabledState.BorderColor = Color.FromArgb(215, 138, 0);
            btnBox.DisabledState.Image = Image.FromFile("./assets/win.png");
        }

        private void DisplayLose()
        {
            btnBox.Image = Image.FromFile("./assets/lose.png");
            btnBox.FillColor = Color.FromArgb(146, 25, 36);
            btnBox.BorderColor = Color.FromArgb(106, 0, 0);

            btnBox.Enabled = false;
            btnBox.DisabledState.FillColor = Color.FromArgb(146, 25, 36);
            btnBox.DisabledState.BorderColor = Color.FromArgb(106, 0, 0);
            btnBox.DisabledState.Image = Image.FromFile("./assets/lose.png");
        }
    }
}
