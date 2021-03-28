namespace RocketRace
{
    partial class Form1
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
            this.SukhmanRadioButton = new System.Windows.Forms.RadioButton();
            this.AnilRadioButton = new System.Windows.Forms.RadioButton();
            this.AlRadioButton = new System.Windows.Forms.RadioButton();
            this.Data_Panel = new System.Windows.Forms.Panel();
            this.txtSukhman = new System.Windows.Forms.TextBox();
            this.lblmax = new System.Windows.Forms.Label();
            this.UDSpaceShip = new System.Windows.Forms.NumericUpDown();
            this.UDBet = new System.Windows.Forms.NumericUpDown();
            this.txtAl = new System.Windows.Forms.TextBox();
            this.txtAnil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBettor = new System.Windows.Forms.Label();
            this.btnPlaceBet = new System.Windows.Forms.Button();
            this.btnRace = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.Race_Panel = new System.Windows.Forms.Panel();
            this.Spaceship1 = new System.Windows.Forms.PictureBox();
            this.Spaceship4 = new System.Windows.Forms.PictureBox();
            this.Spaceship2 = new System.Windows.Forms.PictureBox();
            this.Spaceship3 = new System.Windows.Forms.PictureBox();
            this.Data_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDSpaceShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDBet)).BeginInit();
            this.Race_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spaceship1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spaceship4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spaceship2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spaceship3)).BeginInit();
            this.SuspendLayout();
            // 
            // SukhmanRadioButton
            // 
            this.SukhmanRadioButton.AutoSize = true;
            this.SukhmanRadioButton.Location = new System.Drawing.Point(23, 15);
            this.SukhmanRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.SukhmanRadioButton.Name = "SukhmanRadioButton";
            this.SukhmanRadioButton.Size = new System.Drawing.Size(67, 21);
            this.SukhmanRadioButton.TabIndex = 3;
            this.SukhmanRadioButton.TabStop = true;
            this.SukhmanRadioButton.Text = "Sukhman";
            this.SukhmanRadioButton.UseVisualStyleBackColor = true;
            this.SukhmanRadioButton.CheckedChanged += new System.EventHandler(this.AllRadioButton_CheckedChanged);
            // 
            // AnilRadioButton
            // 
            this.AnilRadioButton.AutoSize = true;
            this.AnilRadioButton.Location = new System.Drawing.Point(23, 43);
            this.AnilRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.AnilRadioButton.Name = "AnilRadioButton";
            this.AnilRadioButton.Size = new System.Drawing.Size(52, 21);
            this.AnilRadioButton.TabIndex = 4;
            this.AnilRadioButton.TabStop = true;
            this.AnilRadioButton.Text = "Anil";
            this.AnilRadioButton.UseVisualStyleBackColor = true;
            this.AnilRadioButton.CheckedChanged += new System.EventHandler(this.AllRadioButton_CheckedChanged);
            // 
            // AlRadioButton
            // 
            this.AlRadioButton.AutoSize = true;
            this.AlRadioButton.Location = new System.Drawing.Point(23, 71);
            this.AlRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.AlRadioButton.Name = "AlRadioButton";
            this.AlRadioButton.Size = new System.Drawing.Size(41, 21);
            this.AlRadioButton.TabIndex = 5;
            this.AlRadioButton.TabStop = true;
            this.AlRadioButton.Text = "Al";
            this.AlRadioButton.UseVisualStyleBackColor = true;
            this.AlRadioButton.CheckedChanged += new System.EventHandler(this.AllRadioButton_CheckedChanged);
            // 
            // Data_Panel
            // 
            this.Data_Panel.BackColor = System.Drawing.Color.Ivory;
            this.Data_Panel.Controls.Add(this.txtSukhman);
            this.Data_Panel.Controls.Add(this.lblmax);
            this.Data_Panel.Controls.Add(this.UDSpaceShip);
            this.Data_Panel.Controls.Add(this.UDBet);
            this.Data_Panel.Controls.Add(this.txtAl);
            this.Data_Panel.Controls.Add(this.txtAnil);
            this.Data_Panel.Controls.Add(this.label5);
            this.Data_Panel.Controls.Add(this.label4);
            this.Data_Panel.Controls.Add(this.label3);
            this.Data_Panel.Controls.Add(this.lblBettor);
            this.Data_Panel.Controls.Add(this.AlRadioButton);
            this.Data_Panel.Controls.Add(this.SukhmanRadioButton);
            this.Data_Panel.Controls.Add(this.AnilRadioButton);
            this.Data_Panel.Location = new System.Drawing.Point(16, 15);
            this.Data_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.Data_Panel.Name = "Data_Panel";
            this.Data_Panel.Size = new System.Drawing.Size(815, 121);
            this.Data_Panel.TabIndex = 6;
            // 
            // txtSukhman
            // 
            this.txtSukhman.Location = new System.Drawing.Point(507, 15);
            this.txtSukhman.Margin = new System.Windows.Forms.Padding(4);
            this.txtSukhman.Name = "txtSukhman";
            this.txtSukhman.Size = new System.Drawing.Size(283, 22);
            this.txtSukhman.TabIndex = 22;
            this.txtSukhman.Text = "Place bet...";
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Location = new System.Drawing.Point(85, 43);
            this.lblmax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(57, 17);
            this.lblmax.TabIndex = 21;
            this.lblmax.Text = "Max bet";
            // 
            // UDSpaceShip
            // 
            this.UDSpaceShip.Location = new System.Drawing.Point(355, 68);
            this.UDSpaceShip.Margin = new System.Windows.Forms.Padding(4);
            this.UDSpaceShip.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.UDSpaceShip.Name = "UDSpaceShip";
            this.UDSpaceShip.Size = new System.Drawing.Size(119, 22);
            this.UDSpaceShip.TabIndex = 19;
            this.UDSpaceShip.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UDBet
            // 
            this.UDBet.Location = new System.Drawing.Point(355, 23);
            this.UDBet.Margin = new System.Windows.Forms.Padding(4);
            this.UDBet.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.UDBet.Name = "UDBet";
            this.UDBet.Size = new System.Drawing.Size(119, 22);
            this.UDBet.TabIndex = 18;
            this.UDBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtAl
            // 
            this.txtAl.Location = new System.Drawing.Point(507, 81);
            this.txtAl.Margin = new System.Windows.Forms.Padding(4);
            this.txtAl.Name = "txtAl";
            this.txtAl.Size = new System.Drawing.Size(283, 22);
            this.txtAl.TabIndex = 15;
            this.txtAl.Text = "Place bet...";
            // 
            // txtAnil
            // 
            this.txtAnil.Location = new System.Drawing.Point(507, 48);
            this.txtAnil.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnil.Name = "txtAnil";
            this.txtAnil.Size = new System.Drawing.Size(283, 22);
            this.txtAnil.TabIndex = 14;
            this.txtAnil.Text = "Place bet...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "$";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(207, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 47);
            this.label3.TabIndex = 8;
            this.label3.Text = "Spaceship Number";
            // 
            // lblBettor
            // 
            this.lblBettor.AutoSize = true;
            this.lblBettor.Location = new System.Drawing.Point(208, 26);
            this.lblBettor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBettor.Name = "lblBettor";
            this.lblBettor.Size = new System.Drawing.Size(46, 17);
            this.lblBettor.TabIndex = 7;
            this.lblBettor.Text = "Bettor";
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPlaceBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceBet.ForeColor = System.Drawing.Color.Ivory;
            this.btnPlaceBet.Location = new System.Drawing.Point(911, 15);
            this.btnPlaceBet.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(303, 73);
            this.btnPlaceBet.TabIndex = 11;
            this.btnPlaceBet.Text = "Place Bet";
            this.btnPlaceBet.UseVisualStyleBackColor = false;
            this.btnPlaceBet.Click += new System.EventHandler(this.btnPlaceBet_Click_1);
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.ForeColor = System.Drawing.Color.Ivory;
            this.btnRace.Location = new System.Drawing.Point(109, 553);
            this.btnRace.Margin = new System.Windows.Forms.Padding(4);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(405, 70);
            this.btnRace.TabIndex = 8;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Ivory;
            this.btnReset.Location = new System.Drawing.Point(1031, 560);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(169, 63);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Race_Panel
            // 
            this.Race_Panel.BackgroundImage = global::RocketRace.Properties.Resources.Racetrack;
            this.Race_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Race_Panel.Controls.Add(this.Spaceship1);
            this.Race_Panel.Controls.Add(this.Spaceship4);
            this.Race_Panel.Controls.Add(this.Spaceship2);
            this.Race_Panel.Controls.Add(this.Spaceship3);
            this.Race_Panel.Location = new System.Drawing.Point(5, 158);
            this.Race_Panel.Name = "Race_Panel";
            this.Race_Panel.Size = new System.Drawing.Size(1246, 388);
            this.Race_Panel.TabIndex = 12;
            // 
            // Spaceship1
            // 
            this.Spaceship1.Image = global::RocketRace.Properties.Resources.spaceship;
            this.Spaceship1.Location = new System.Drawing.Point(26, 29);
            this.Spaceship1.Margin = new System.Windows.Forms.Padding(4);
            this.Spaceship1.Name = "Spaceship1";
            this.Spaceship1.Size = new System.Drawing.Size(133, 62);
            this.Spaceship1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Spaceship1.TabIndex = 0;
            this.Spaceship1.TabStop = false;
            // 
            // Spaceship4
            // 
            this.Spaceship4.Image = global::RocketRace.Properties.Resources.orbiter;
            this.Spaceship4.Location = new System.Drawing.Point(26, 298);
            this.Spaceship4.Margin = new System.Windows.Forms.Padding(4);
            this.Spaceship4.Name = "Spaceship4";
            this.Spaceship4.Size = new System.Drawing.Size(133, 62);
            this.Spaceship4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Spaceship4.TabIndex = 10;
            this.Spaceship4.TabStop = false;
            // 
            // Spaceship2
            // 
            this.Spaceship2.Image = global::RocketRace.Properties.Resources.yellowspaceship;
            this.Spaceship2.Location = new System.Drawing.Point(26, 115);
            this.Spaceship2.Margin = new System.Windows.Forms.Padding(4);
            this.Spaceship2.Name = "Spaceship2";
            this.Spaceship2.Size = new System.Drawing.Size(133, 62);
            this.Spaceship2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Spaceship2.TabIndex = 1;
            this.Spaceship2.TabStop = false;
            // 
            // Spaceship3
            // 
            this.Spaceship3.Image = global::RocketRace.Properties.Resources.orbiter1;
            this.Spaceship3.Location = new System.Drawing.Point(26, 211);
            this.Spaceship3.Margin = new System.Windows.Forms.Padding(4);
            this.Spaceship3.Name = "Spaceship3";
            this.Spaceship3.Size = new System.Drawing.Size(133, 62);
            this.Spaceship3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Spaceship3.TabIndex = 2;
            this.Spaceship3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1263, 666);
            this.Controls.Add(this.Race_Panel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.btnPlaceBet);
            this.Controls.Add(this.Data_Panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Spaceship Racing";
            this.Data_Panel.ResumeLayout(false);
            this.Data_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDSpaceShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDBet)).EndInit();
            this.Race_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Spaceship1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spaceship4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spaceship2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spaceship3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Spaceship1;
        private System.Windows.Forms.PictureBox Spaceship2;
        private System.Windows.Forms.PictureBox Spaceship3;
        private System.Windows.Forms.RadioButton SukhmanRadioButton;
        private System.Windows.Forms.RadioButton AnilRadioButton;
        private System.Windows.Forms.RadioButton AlRadioButton;
        private System.Windows.Forms.Panel Data_Panel;
        private System.Windows.Forms.TextBox txtAl;
        private System.Windows.Forms.TextBox txtAnil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBettor;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox Spaceship4;
        private System.Windows.Forms.NumericUpDown UDBet;
        private System.Windows.Forms.NumericUpDown UDSpaceShip;
        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.TextBox txtSukhman;
        private System.Windows.Forms.Panel Race_Panel;
    }
}
