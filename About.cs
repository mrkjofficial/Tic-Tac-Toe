using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        private bool isFormDragged;
        private Point offset;
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MenuStrip_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isFormDragged = true;
                offset.X = e.X;
                offset.Y = e.Y;
            }
        }
        private void MenuStrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (isFormDragged)
            {
                Point curScrPos = PointToScreen(e.Location);
                Location = new Point(curScrPos.X - offset.X, curScrPos.Y - offset.Y);
            }
        }
        private void MenuStrip_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isFormDragged = false;
        }
        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Home home = new Home();
            string clickedItem = e.ClickedItem.Name;
            if (clickedItem == "NGM")
            {
                home.scoreX = 0;
                home.scoreO = 0;
                home.ResetBoard();
                home.PlayerXScoreLabel.Text = Convert.ToString(home.scoreX);
                home.PlayerOScoreLabel.Text = Convert.ToString(home.scoreO);
                home.StatusLabel.Text = "";
                home.Show();
                Hide();
            }
            else if (clickedItem == "RST")
            {
                home.ResetBoard();
                home.Show();
                Hide();
            }
        }
    }
}
