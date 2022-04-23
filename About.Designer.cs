
namespace Tic_Tac_Toe
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DeveloperPictureBox = new System.Windows.Forms.PictureBox();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NGM = new System.Windows.Forms.ToolStripMenuItem();
            this.RST = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ABT = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DeveloperPictureBox)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
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
            this.CloseButton.TabIndex = 4;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DeveloperPictureBox
            // 
            this.DeveloperPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeveloperPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.DeveloperPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeveloperPictureBox.Image = global::Tic_Tac_Toe.Properties.Resources.Karan;
            this.DeveloperPictureBox.Location = new System.Drawing.Point(75, 150);
            this.DeveloperPictureBox.Name = "DeveloperPictureBox";
            this.DeveloperPictureBox.Size = new System.Drawing.Size(250, 250);
            this.DeveloperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeveloperPictureBox.TabIndex = 5;
            this.DeveloperPictureBox.TabStop = false;
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeadingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeadingLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeadingLabel.ForeColor = System.Drawing.Color.Black;
            this.HeadingLabel.Location = new System.Drawing.Point(425, 150);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(300, 50);
            this.HeadingLabel.TabIndex = 6;
            this.HeadingLabel.Text = "Karan Jaiswal";
            this.HeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.DescriptionLabel.Location = new System.Drawing.Point(425, 200);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(300, 200);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = resources.GetString("DescriptionLabel.Text");
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(250, 75);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(300, 50);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "About Developer";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // MenuStrip
            // 
            this.MenuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.MenuStrip.AutoSize = false;
            this.MenuStrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.MenuStrip.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NGM,
            this.RST,
            this.ABT});
            this.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(2);
            this.MenuStrip.Size = new System.Drawing.Size(800, 50);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "MenuStrip";
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            this.MenuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuStrip_MouseDown);
            this.MenuStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStrip_MouseMove);
            this.MenuStrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuStrip_MouseUp);
            // 
            // ABT
            // 
            this.ABT.ForeColor = System.Drawing.Color.White;
            this.ABT.Name = "ABT";
            this.ABT.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.ABT.Size = new System.Drawing.Size(104, 46);
            this.ABT.Text = "About";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.HeadingLabel);
            this.Controls.Add(this.DeveloperPictureBox);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MenuStrip);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.DeveloperPictureBox)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox DeveloperPictureBox;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ToolStripMenuItem NGM;
        private System.Windows.Forms.ToolStripMenuItem RST;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ABT;
    }
}