
namespace Tic_Tac_Toe
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.NGM = new System.Windows.Forms.ToolStripMenuItem();
            this.RST = new System.Windows.Forms.ToolStripMenuItem();
            this.ABT = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ScoresGroupBox = new System.Windows.Forms.GroupBox();
            this.PlayerOScoreLabel = new System.Windows.Forms.Label();
            this.PlayerXScoreLabel = new System.Windows.Forms.Label();
            this.PlayerOLabel = new System.Windows.Forms.Label();
            this.PlayerXLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.ScoresGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.MenuStrip.AutoSize = false;
            this.MenuStrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.MenuStrip.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NGM,
            this.RST,
            this.ABT});
            this.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(2);
            this.MenuStrip.Size = new System.Drawing.Size(800, 50);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            this.MenuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuStrip_MouseDown);
            this.MenuStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStrip_MouseMove);
            this.MenuStrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuStrip_MouseUp);
            // 
            // NGM
            // 
            this.NGM.ForeColor = System.Drawing.Color.White;
            this.NGM.Name = "NGM";
            this.NGM.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.NGM.Size = new System.Drawing.Size(162, 46);
            this.NGM.Text = "New Game";
            // 
            // RST
            // 
            this.RST.ForeColor = System.Drawing.Color.White;
            this.RST.Name = "RST";
            this.RST.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.RST.Size = new System.Drawing.Size(94, 46);
            this.RST.Text = "Reset";
            // 
            // ABT
            // 
            this.ABT.ForeColor = System.Drawing.Color.White;
            this.ABT.Name = "ABT";
            this.ABT.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.ABT.Size = new System.Drawing.Size(104, 46);
            this.ABT.Text = "About";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatAppearance.BorderSize = 2;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CloseButton.Location = new System.Drawing.Point(758, 10);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 32);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Button1.FlatAppearance.BorderSize = 2;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Button1.Location = new System.Drawing.Point(30, 80);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 100);
            this.Button1.TabIndex = 3;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button4
            // 
            this.Button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button4.BackColor = System.Drawing.Color.Transparent;
            this.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Button4.FlatAppearance.BorderSize = 2;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Button4.Location = new System.Drawing.Point(30, 200);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(100, 100);
            this.Button4.TabIndex = 6;
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button7
            // 
            this.Button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button7.BackColor = System.Drawing.Color.Transparent;
            this.Button7.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Button7.FlatAppearance.BorderSize = 2;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Button7.Location = new System.Drawing.Point(30, 320);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(100, 100);
            this.Button7.TabIndex = 9;
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button2.BackColor = System.Drawing.Color.Transparent;
            this.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Button2.FlatAppearance.BorderSize = 2;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Button2.Location = new System.Drawing.Point(160, 80);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 100);
            this.Button2.TabIndex = 4;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button5
            // 
            this.Button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button5.BackColor = System.Drawing.Color.Transparent;
            this.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Button5.FlatAppearance.BorderSize = 2;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Button5.Location = new System.Drawing.Point(160, 200);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(100, 100);
            this.Button5.TabIndex = 7;
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button8
            // 
            this.Button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button8.BackColor = System.Drawing.Color.Transparent;
            this.Button8.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Button8.FlatAppearance.BorderSize = 2;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Button8.Location = new System.Drawing.Point(160, 320);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(100, 100);
            this.Button8.TabIndex = 10;
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button3
            // 
            this.Button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button3.BackColor = System.Drawing.Color.Transparent;
            this.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Button3.FlatAppearance.BorderSize = 2;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Button3.Location = new System.Drawing.Point(290, 80);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(100, 100);
            this.Button3.TabIndex = 5;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button6
            // 
            this.Button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button6.BackColor = System.Drawing.Color.Transparent;
            this.Button6.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Button6.FlatAppearance.BorderSize = 2;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Button6.Location = new System.Drawing.Point(290, 200);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(100, 100);
            this.Button6.TabIndex = 8;
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button9
            // 
            this.Button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button9.BackColor = System.Drawing.Color.Transparent;
            this.Button9.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Button9.FlatAppearance.BorderSize = 2;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Button9.Location = new System.Drawing.Point(290, 320);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(100, 100);
            this.Button9.TabIndex = 11;
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinimizeButton.BackColor = System.Drawing.Color.Orange;
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MinimizeButton.FlatAppearance.BorderSize = 2;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimizeButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MinimizeButton.Location = new System.Drawing.Point(716, 10);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(32, 32);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(445, 80);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(300, 50);
            this.TitleLabel.TabIndex = 12;
            this.TitleLabel.Text = "Tic-Tac-Toe";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoresGroupBox
            // 
            this.ScoresGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScoresGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ScoresGroupBox.Controls.Add(this.PlayerOScoreLabel);
            this.ScoresGroupBox.Controls.Add(this.PlayerXScoreLabel);
            this.ScoresGroupBox.Controls.Add(this.PlayerOLabel);
            this.ScoresGroupBox.Controls.Add(this.PlayerXLabel);
            this.ScoresGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoresGroupBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoresGroupBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ScoresGroupBox.Location = new System.Drawing.Point(445, 220);
            this.ScoresGroupBox.Name = "ScoresGroupBox";
            this.ScoresGroupBox.Size = new System.Drawing.Size(300, 200);
            this.ScoresGroupBox.TabIndex = 13;
            this.ScoresGroupBox.TabStop = false;
            this.ScoresGroupBox.Text = "Score:";
            // 
            // PlayerOScoreLabel
            // 
            this.PlayerOScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerOScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerOScoreLabel.Location = new System.Drawing.Point(200, 120);
            this.PlayerOScoreLabel.Name = "PlayerOScoreLabel";
            this.PlayerOScoreLabel.Size = new System.Drawing.Size(50, 50);
            this.PlayerOScoreLabel.TabIndex = 3;
            this.PlayerOScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerXScoreLabel
            // 
            this.PlayerXScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerXScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerXScoreLabel.Location = new System.Drawing.Point(200, 50);
            this.PlayerXScoreLabel.Name = "PlayerXScoreLabel";
            this.PlayerXScoreLabel.Size = new System.Drawing.Size(50, 50);
            this.PlayerXScoreLabel.TabIndex = 2;
            this.PlayerXScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerOLabel
            // 
            this.PlayerOLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerOLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerOLabel.Location = new System.Drawing.Point(20, 120);
            this.PlayerOLabel.Name = "PlayerOLabel";
            this.PlayerOLabel.Size = new System.Drawing.Size(150, 50);
            this.PlayerOLabel.TabIndex = 1;
            this.PlayerOLabel.Text = "Player O:";
            this.PlayerOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerXLabel
            // 
            this.PlayerXLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerXLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerXLabel.Location = new System.Drawing.Point(20, 50);
            this.PlayerXLabel.Name = "PlayerXLabel";
            this.PlayerXLabel.Size = new System.Drawing.Size(150, 50);
            this.PlayerXLabel.TabIndex = 0;
            this.PlayerXLabel.Text = "Player X:";
            this.PlayerXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.Lime;
            this.StatusLabel.Location = new System.Drawing.Point(445, 150);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(300, 50);
            this.StatusLabel.TabIndex = 14;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ScoresGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ScoresGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NGM;
        private System.Windows.Forms.ToolStripMenuItem RST;
        private System.Windows.Forms.ToolStripMenuItem ABT;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox ScoresGroupBox;
        private System.Windows.Forms.Label PlayerOLabel;
        private System.Windows.Forms.Label PlayerXLabel;
        public System.Windows.Forms.Label PlayerOScoreLabel;
        public System.Windows.Forms.Label PlayerXScoreLabel;
        public System.Windows.Forms.Label StatusLabel;
    }
}

