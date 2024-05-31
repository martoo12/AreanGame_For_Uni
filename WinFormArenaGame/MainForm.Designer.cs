namespace WinFormArenaGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnNewGame = new Button();
            tbKnight = new TextBox();
            tbAssassin = new TextBox();
            imgFight = new PictureBox();
            lbWinner = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgFight).BeginInit();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(599, 26);
            btnNewGame.Margin = new Padding(3, 2, 3, 2);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(82, 22);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // tbKnight
            // 
            tbKnight.Location = new Point(20, 26);
            tbKnight.Margin = new Padding(3, 2, 3, 2);
            tbKnight.Multiline = true;
            tbKnight.Name = "tbKnight";
            tbKnight.Size = new Size(490, 329);
            tbKnight.TabIndex = 1;
            // 
            // tbAssassin
            // 
            tbAssassin.Location = new Point(769, 33);
            tbAssassin.Margin = new Padding(3, 2, 3, 2);
            tbAssassin.Multiline = true;
            tbAssassin.Name = "tbAssassin";
            tbAssassin.Size = new Size(490, 329);
            tbAssassin.TabIndex = 2;
            // 
            // imgFight
            // 
            imgFight.Enabled = false;
            imgFight.Image = (Image)resources.GetObject("imgFight.Image");
            imgFight.Location = new Point(552, 189);
            imgFight.Margin = new Padding(3, 2, 3, 2);
            imgFight.Name = "imgFight";
            imgFight.Size = new Size(180, 100);
            imgFight.TabIndex = 3;
            imgFight.TabStop = false;
            // 
            // lbWinner
            // 
            lbWinner.Location = new Point(558, 295);
            lbWinner.Name = "lbWinner";
            lbWinner.Size = new Size(180, 67);
            lbWinner.TabIndex = 4;
            lbWinner.Visible = false;
            lbWinner.Click += lbWinner_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(769, 14);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Assassin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 7);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Knight:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(663, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(663, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Assassin", "Knight", "Magician", "Viking" });
            comboBox1.Location = new Point(516, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Assassin", "Knight", "Magician", "Viking" });
            comboBox2.Location = new Point(516, 151);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(516, 76);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 11;
            label3.Text = "Left Hero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(516, 133);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 12;
            label4.Text = "Right Hero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(663, 76);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 13;
            label5.Text = "Special Weapon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(663, 133);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 14;
            label6.Text = "Special Weapon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(552, 315);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 15;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 378);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbWinner);
            Controls.Add(imgFight);
            Controls.Add(tbAssassin);
            Controls.Add(tbKnight);
            Controls.Add(btnNewGame);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Arena Game";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)imgFight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewGame;
        private TextBox tbKnight;
        private TextBox tbAssassin;
        private PictureBox imgFight;
        private Label lbWinner;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}