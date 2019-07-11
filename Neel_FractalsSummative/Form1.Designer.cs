namespace Neel_FractalsSummative
{
    partial class SierpinskiFractalsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SierpinskiFractalsForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SummativeLabel = new System.Windows.Forms.Label();
            this.SchoolYearLabel = new System.Windows.Forms.Label();
            this.InfoLabel1 = new System.Windows.Forms.Label();
            this.DrawSierpinskiTriangleButton = new System.Windows.Forms.Button();
            this.DrawSierpinskiCarpetButton = new System.Windows.Forms.Button();
            this.RecursionDepthLabel = new System.Windows.Forms.Label();
            this.UserRecursionDepthTextbox = new System.Windows.Forms.TextBox();
            this.rgbLabel = new System.Windows.Forms.Label();
            this.RedLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.UserRedTextbox = new System.Windows.Forms.TextBox();
            this.UserGreenTextbox = new System.Windows.Forms.TextBox();
            this.UserBlueTextbox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SierpinskiFractalsPictureBox = new System.Windows.Forms.PictureBox();
            this.RandomRecursionDepthButton = new System.Windows.Forms.Button();
            this.RandomRGBValuesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SierpinskiFractalsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TitleLabel.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(72, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(650, 39);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Sierpinski Fractals Generator";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(707, 716);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(65, 15);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Neel Shah";
            // 
            // SummativeLabel
            // 
            this.SummativeLabel.AutoSize = true;
            this.SummativeLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummativeLabel.Location = new System.Drawing.Point(721, 731);
            this.SummativeLabel.Name = "SummativeLabel";
            this.SummativeLabel.Size = new System.Drawing.Size(51, 15);
            this.SummativeLabel.TabIndex = 2;
            this.SummativeLabel.Text = "ICS4U0";
            // 
            // SchoolYearLabel
            // 
            this.SchoolYearLabel.AutoSize = true;
            this.SchoolYearLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchoolYearLabel.Location = new System.Drawing.Point(712, 746);
            this.SchoolYearLabel.Name = "SchoolYearLabel";
            this.SchoolYearLabel.Size = new System.Drawing.Size(60, 15);
            this.SchoolYearLabel.TabIndex = 3;
            this.SchoolYearLabel.Text = "2018-2019";
            // 
            // InfoLabel1
            // 
            this.InfoLabel1.AutoSize = true;
            this.InfoLabel1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel1.Location = new System.Drawing.Point(83, 54);
            this.InfoLabel1.Name = "InfoLabel1";
            this.InfoLabel1.Size = new System.Drawing.Size(630, 32);
            this.InfoLabel1.TabIndex = 5;
            this.InfoLabel1.Text = resources.GetString("InfoLabel1.Text");
            // 
            // DrawSierpinskiTriangleButton
            // 
            this.DrawSierpinskiTriangleButton.Location = new System.Drawing.Point(438, 591);
            this.DrawSierpinskiTriangleButton.Name = "DrawSierpinskiTriangleButton";
            this.DrawSierpinskiTriangleButton.Size = new System.Drawing.Size(133, 31);
            this.DrawSierpinskiTriangleButton.TabIndex = 6;
            this.DrawSierpinskiTriangleButton.Text = "Draw Sierpinski Triangle";
            this.DrawSierpinskiTriangleButton.UseVisualStyleBackColor = true;
            this.DrawSierpinskiTriangleButton.Click += new System.EventHandler(this.DrawSierpinskiTriangleButton_Click);
            // 
            // DrawSierpinskiCarpetButton
            // 
            this.DrawSierpinskiCarpetButton.Location = new System.Drawing.Point(586, 591);
            this.DrawSierpinskiCarpetButton.Name = "DrawSierpinskiCarpetButton";
            this.DrawSierpinskiCarpetButton.Size = new System.Drawing.Size(133, 31);
            this.DrawSierpinskiCarpetButton.TabIndex = 7;
            this.DrawSierpinskiCarpetButton.Text = "Draw Sierpinski Carpet";
            this.DrawSierpinskiCarpetButton.UseVisualStyleBackColor = true;
            this.DrawSierpinskiCarpetButton.Click += new System.EventHandler(this.DrawSierpinskiCarpetButton_Click);
            // 
            // RecursionDepthLabel
            // 
            this.RecursionDepthLabel.AutoSize = true;
            this.RecursionDepthLabel.Location = new System.Drawing.Point(84, 591);
            this.RecursionDepthLabel.Name = "RecursionDepthLabel";
            this.RecursionDepthLabel.Size = new System.Drawing.Size(162, 13);
            this.RecursionDepthLabel.TabIndex = 8;
            this.RecursionDepthLabel.Text = "Enter Recursion Depth (from 1-5)";
            // 
            // UserRecursionDepthTextbox
            // 
            this.UserRecursionDepthTextbox.Location = new System.Drawing.Point(87, 607);
            this.UserRecursionDepthTextbox.Name = "UserRecursionDepthTextbox";
            this.UserRecursionDepthTextbox.Size = new System.Drawing.Size(112, 20);
            this.UserRecursionDepthTextbox.TabIndex = 9;
            // 
            // rgbLabel
            // 
            this.rgbLabel.AutoSize = true;
            this.rgbLabel.Location = new System.Drawing.Point(258, 592);
            this.rgbLabel.Name = "rgbLabel";
            this.rgbLabel.Size = new System.Drawing.Size(152, 13);
            this.rgbLabel.TabIndex = 10;
            this.rgbLabel.Text = "Enter RGB Values (from 0-255)";
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Location = new System.Drawing.Point(258, 614);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(30, 13);
            this.RedLabel.TabIndex = 11;
            this.RedLabel.Text = "Red:";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Location = new System.Drawing.Point(258, 640);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(39, 13);
            this.GreenLabel.TabIndex = 12;
            this.GreenLabel.Text = "Green:";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Location = new System.Drawing.Point(257, 666);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(31, 13);
            this.BlueLabel.TabIndex = 13;
            this.BlueLabel.Text = "Blue:";
            // 
            // UserRedTextbox
            // 
            this.UserRedTextbox.Location = new System.Drawing.Point(307, 611);
            this.UserRedTextbox.Name = "UserRedTextbox";
            this.UserRedTextbox.Size = new System.Drawing.Size(71, 20);
            this.UserRedTextbox.TabIndex = 14;
            // 
            // UserGreenTextbox
            // 
            this.UserGreenTextbox.Location = new System.Drawing.Point(307, 637);
            this.UserGreenTextbox.Name = "UserGreenTextbox";
            this.UserGreenTextbox.Size = new System.Drawing.Size(71, 20);
            this.UserGreenTextbox.TabIndex = 15;
            // 
            // UserBlueTextbox
            // 
            this.UserBlueTextbox.Location = new System.Drawing.Point(307, 663);
            this.UserBlueTextbox.Name = "UserBlueTextbox";
            this.UserBlueTextbox.Size = new System.Drawing.Size(71, 20);
            this.UserBlueTextbox.TabIndex = 16;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(438, 637);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(133, 31);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(586, 637);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(133, 31);
            this.QuitButton.TabIndex = 22;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // SierpinskiFractalsPictureBox
            // 
            this.SierpinskiFractalsPictureBox.Location = new System.Drawing.Point(79, 104);
            this.SierpinskiFractalsPictureBox.Name = "SierpinskiFractalsPictureBox";
            this.SierpinskiFractalsPictureBox.Size = new System.Drawing.Size(640, 480);
            this.SierpinskiFractalsPictureBox.TabIndex = 4;
            this.SierpinskiFractalsPictureBox.TabStop = false;
            this.SierpinskiFractalsPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SierpinskiFractalsPictureBox_Paint);
            // 
            // RandomRecursionDepthButton
            // 
            this.RandomRecursionDepthButton.Location = new System.Drawing.Point(86, 631);
            this.RandomRecursionDepthButton.Name = "RandomRecursionDepthButton";
            this.RandomRecursionDepthButton.Size = new System.Drawing.Size(112, 42);
            this.RandomRecursionDepthButton.TabIndex = 23;
            this.RandomRecursionDepthButton.Text = "Generate a Random Recursion Depth?";
            this.RandomRecursionDepthButton.UseVisualStyleBackColor = true;
            this.RandomRecursionDepthButton.Click += new System.EventHandler(this.RandomRecursionDepthButton_Click);
            // 
            // RandomRGBValuesButton
            // 
            this.RandomRGBValuesButton.Location = new System.Drawing.Point(260, 689);
            this.RandomRGBValuesButton.Name = "RandomRGBValuesButton";
            this.RandomRGBValuesButton.Size = new System.Drawing.Size(118, 42);
            this.RandomRGBValuesButton.TabIndex = 24;
            this.RandomRGBValuesButton.Text = "Generate Random RGB Values?";
            this.RandomRGBValuesButton.UseVisualStyleBackColor = true;
            this.RandomRGBValuesButton.Click += new System.EventHandler(this.RandomRGBValuesButton_Click);
            // 
            // SierpinskiFractalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 770);
            this.Controls.Add(this.RandomRGBValuesButton);
            this.Controls.Add(this.RandomRecursionDepthButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UserBlueTextbox);
            this.Controls.Add(this.UserGreenTextbox);
            this.Controls.Add(this.UserRedTextbox);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.GreenLabel);
            this.Controls.Add(this.RedLabel);
            this.Controls.Add(this.rgbLabel);
            this.Controls.Add(this.UserRecursionDepthTextbox);
            this.Controls.Add(this.RecursionDepthLabel);
            this.Controls.Add(this.DrawSierpinskiCarpetButton);
            this.Controls.Add(this.DrawSierpinskiTriangleButton);
            this.Controls.Add(this.InfoLabel1);
            this.Controls.Add(this.SierpinskiFractalsPictureBox);
            this.Controls.Add(this.SchoolYearLabel);
            this.Controls.Add(this.SummativeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "SierpinskiFractalsForm";
            this.Text = "Sierpinski Fractals";
            ((System.ComponentModel.ISupportInitialize)(this.SierpinskiFractalsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SummativeLabel;
        private System.Windows.Forms.Label SchoolYearLabel;
        private System.Windows.Forms.PictureBox SierpinskiFractalsPictureBox;
        private System.Windows.Forms.Label InfoLabel1;
        private System.Windows.Forms.Button DrawSierpinskiTriangleButton;
        private System.Windows.Forms.Button DrawSierpinskiCarpetButton;
        private System.Windows.Forms.Label RecursionDepthLabel;
        private System.Windows.Forms.TextBox UserRecursionDepthTextbox;
        private System.Windows.Forms.Label rgbLabel;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.TextBox UserRedTextbox;
        private System.Windows.Forms.TextBox UserGreenTextbox;
        private System.Windows.Forms.TextBox UserBlueTextbox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button RandomRecursionDepthButton;
        private System.Windows.Forms.Button RandomRGBValuesButton;
    }
}

