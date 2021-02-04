using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private int i;
        private bool isFormDragged;
        private Point offset;
        public int scoreX, scoreO;
        private void Home_Load(object sender, EventArgs e)
        {
            i = 1;
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = true;
            Button4.Enabled = true;
            Button5.Enabled = true;
            Button6.Enabled = true;
            Button7.Enabled = true;
            Button8.Enabled = true;
            Button9.Enabled = true;
            PlayerXScoreLabel.Text = "0";
            PlayerOScoreLabel.Text = "0";
        }

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
            string clickedItem = e.ClickedItem.Name;
            if (clickedItem == "NGM")
            {
                scoreX = 0;
                scoreO = 0;
                ResetBoard();
                PlayerXScoreLabel.Text = Convert.ToString(scoreX);
                PlayerOScoreLabel.Text = Convert.ToString(scoreO);
            }
            else if (clickedItem == "RST")
            {
                ResetBoard();
            }
            else if (clickedItem == "ABT")
            {
                Hide();
                About about = new About();
                about.Show();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = Chance();
            Button1.Enabled = false;
            i += 1;
            Result();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Button2.Text = Chance();
            Button2.Enabled = false;
            i += 1;
            Result();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Button3.Text = Chance();
            Button3.Enabled = false;
            i += 1;
            Result();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            Button4.Text = Chance();
            Button4.Enabled = false;
            i += 1;
            Result();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            Button5.Text = Chance();
            Button5.Enabled = false;
            i += 1;
            Result();
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            Button6.Text = Chance();
            Button6.Enabled = false;
            i += 1;
            Result();
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            Button7.Text = Chance();
            Button7.Enabled = false;
            i += 1;
            Result();
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            Button8.Text = Chance();
            Button8.Enabled = false;
            i += 1;
            Result();
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            Button9.Text = Chance();
            Button9.Enabled = false;
            i += 1;
            Result();
        }

        public void ResetBoard()
        {
            i = 1;
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = true;
            Button4.Enabled = true;
            Button5.Enabled = true;
            Button6.Enabled = true;
            Button7.Enabled = true;
            Button8.Enabled = true;
            Button9.Enabled = true;
            Button1.Text = "";
            Button2.Text = "";
            Button3.Text = "";
            Button4.Text = "";
            Button5.Text = "";
            Button6.Text = "";
            Button7.Text = "";
            Button8.Text = "";
            Button9.Text = "";
            Button1.BackColor = Color.Transparent;
            Button2.BackColor = Color.Transparent;
            Button3.BackColor = Color.Transparent;
            Button4.BackColor = Color.Transparent;
            Button5.BackColor = Color.Transparent;
            Button6.BackColor = Color.Transparent;
            Button7.BackColor = Color.Transparent;
            Button8.BackColor = Color.Transparent;
            Button9.BackColor = Color.Transparent;
            StatusLabel.ForeColor = Color.Black;
            StatusLabel.Text = "";
        }
        private string Chance()
        {
            if (i % 2 == 1)
            {
                StatusLabel.ForeColor = Color.Black;
                StatusLabel.Text = "Player O's Turn!";
                return "X";
            }
            else
            {
                StatusLabel.ForeColor = Color.Black;
                StatusLabel.Text = "Player X's Turn!";
                return "O";
            }
        }
        private void DisableBoard()
        {
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;
            Button7.Enabled = false;
            Button8.Enabled = false;
            Button9.Enabled = false;
        }
        private bool Pair(string button1, string button2, string button3)
        {
            if (button1 == button2 && button2 == button3)
                return true;
            else
                return false;
        }
        private void Score(string player)
        {
            if (player == "X")
            {
                scoreX += 1;
                PlayerXScoreLabel.Text = Convert.ToString(scoreX);
            }
            else if (player == "O")
            {
                scoreO += 1;
                PlayerOScoreLabel.Text = Convert.ToString(scoreO);
            }
        }
        private void Result()
        {
            if (Button1.Text != String.Empty && Pair(Button1.Text, Button2.Text, Button3.Text))
            {
                Button1.BackColor = Color.Green;
                Button2.BackColor = Color.Green;
                Button3.BackColor = Color.Green;
                StatusLabel.ForeColor = Color.Green;
                Score(Button1.Text);
                StatusLabel.Text = "Player " + Button1.Text + " Wins!";
                DisableBoard();
            }

            else if (Button4.Text != String.Empty && Pair(Button4.Text, Button5.Text, Button6.Text))
            {
                Button4.BackColor = Color.Green;
                Button5.BackColor = Color.Green;
                Button6.BackColor = Color.Green;
                StatusLabel.ForeColor = Color.Green;
                Score(Button4.Text);
                StatusLabel.Text = "Player " + Button4.Text + " Wins!";
                DisableBoard();
            }
            else if (Button7.Text != String.Empty && Pair(Button7.Text, Button8.Text, Button9.Text))
            {
                Button7.BackColor = Color.Green;
                Button8.BackColor = Color.Green;
                Button9.BackColor = Color.Green;
                StatusLabel.ForeColor = Color.Green;
                Score(Button7.Text);
                StatusLabel.Text = "Player " + Button7.Text + " Wins!";
                DisableBoard();
            }
            else if (Button1.Text != String.Empty && Pair(Button1.Text, Button4.Text, Button7.Text))
            {
                Button1.BackColor = Color.Green;
                Button4.BackColor = Color.Green;
                Button7.BackColor = Color.Green;
                StatusLabel.ForeColor = Color.Green;
                Score(Button1.Text);
                StatusLabel.Text = "Player " + Button1.Text + " Wins!";
                DisableBoard();
            }
            else if (Button2.Text != String.Empty && Pair(Button2.Text, Button5.Text, Button8.Text))
            {
                Button2.BackColor = Color.Green;
                Button5.BackColor = Color.Green;
                Button8.BackColor = Color.Green;
                StatusLabel.ForeColor = Color.Green;
                Score(Button2.Text);
                StatusLabel.Text = "Player " + Button2.Text + " Wins!";
                DisableBoard();
            }
            else if (Button3.Text != String.Empty && Pair(Button3.Text, Button6.Text, Button9.Text))
            {
                Button3.BackColor = Color.Green;
                Button6.BackColor = Color.Green;
                Button9.BackColor = Color.Green;
                StatusLabel.ForeColor = Color.Green;
                Score(Button3.Text);
                StatusLabel.Text = "Player " + Button3.Text + " Wins!";
                DisableBoard();
            }
            else if (Button1.Text != String.Empty && Pair(Button1.Text, Button5.Text, Button9.Text))
            {
                Button1.BackColor = Color.Green;
                Button5.BackColor = Color.Green;
                Button9.BackColor = Color.Green;
                StatusLabel.ForeColor = Color.Green;
                Score(Button1.Text);
                StatusLabel.Text = "Player " + Button1.Text + " Wins!";
                DisableBoard();
            }
            else if (Button3.Text != String.Empty && Pair(Button3.Text, Button5.Text, Button7.Text))
            {
                Button3.BackColor = Color.Green;
                Button5.BackColor = Color.Green;
                Button7.BackColor = Color.Green;
                StatusLabel.ForeColor = Color.Green;
                Score(Button3.Text);
                StatusLabel.Text = "Player " + Button3.Text + " Wins!";
                DisableBoard();
            }
            else if (i > 9)
            {
                Button1.BackColor = Color.Red;
                Button2.BackColor = Color.Red;
                Button3.BackColor = Color.Red;
                Button4.BackColor = Color.Red;
                Button5.BackColor = Color.Red;
                Button6.BackColor = Color.Red;
                Button7.BackColor = Color.Red;
                Button8.BackColor = Color.Red;
                Button9.BackColor = Color.Red;
                StatusLabel.ForeColor = Color.Red;
                StatusLabel.Text = "Its a tie!";
            }
        }


    }
}
