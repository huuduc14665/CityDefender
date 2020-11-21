namespace Game_CityDefender
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.tmTankMove = new System.Windows.Forms.Timer(this.components);
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.pbControl = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.btNewGame = new System.Windows.Forms.Button();
            this.lbPause = new System.Windows.Forms.Label();
            this.lbGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tm
            // 
            this.tm.Enabled = true;
            this.tm.Interval = 40;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // tmTankMove
            // 
            this.tmTankMove.Interval = 30;
            this.tmTankMove.Tick += new System.EventHandler(this.tmTankMove_Tick);
            // 
            // pbGame
            // 
            this.pbGame.BackColor = System.Drawing.Color.AliceBlue;
            this.pbGame.Location = new System.Drawing.Point(1, 2);
            this.pbGame.Margin = new System.Windows.Forms.Padding(4);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(1561, 849);
            this.pbGame.TabIndex = 2;
            this.pbGame.TabStop = false;
            this.pbGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGame_Paint);
            this.pbGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbGame_MouseDown);
            // 
            // pbControl
            // 
            this.pbControl.Location = new System.Drawing.Point(1563, 2);
            this.pbControl.Margin = new System.Windows.Forms.Padding(4);
            this.pbControl.Name = "pbControl";
            this.pbControl.Size = new System.Drawing.Size(240, 896);
            this.pbControl.TabIndex = 3;
            this.pbControl.TabStop = false;
            this.pbControl.Click += new System.EventHandler(this.pbControl_Click);
            this.pbControl.Paint += new System.Windows.Forms.PaintEventHandler(this.pbControl_Paint);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.Navy;
            this.lbScore.Location = new System.Drawing.Point(1671, 207);
            this.lbScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(101, 36);
            this.lbScore.TabIndex = 5;
            this.lbScore.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(1583, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Score";
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(1640, 741);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(117, 57);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btPause
            // 
            this.btPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPause.ForeColor = System.Drawing.Color.Blue;
            this.btPause.Location = new System.Drawing.Point(1604, 521);
            this.btPause.Margin = new System.Windows.Forms.Padding(4);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(180, 58);
            this.btPause.TabIndex = 8;
            this.btPause.Text = "Pause";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // btNewGame
            // 
            this.btNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewGame.ForeColor = System.Drawing.Color.Blue;
            this.btNewGame.Location = new System.Drawing.Point(1604, 612);
            this.btNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btNewGame.Name = "btNewGame";
            this.btNewGame.Size = new System.Drawing.Size(180, 58);
            this.btNewGame.TabIndex = 9;
            this.btNewGame.Text = "New Game";
            this.btNewGame.UseVisualStyleBackColor = true;
            this.btNewGame.Click += new System.EventHandler(this.btNewGame_Click);
            // 
            // lbPause
            // 
            this.lbPause.AutoSize = true;
            this.lbPause.BackColor = System.Drawing.Color.Red;
            this.lbPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPause.Location = new System.Drawing.Point(647, 405);
            this.lbPause.Name = "lbPause";
            this.lbPause.Size = new System.Drawing.Size(291, 85);
            this.lbPause.TabIndex = 10;
            this.lbPause.Text = "PAUSE";
            // 
            // lbGameOver
            // 
            this.lbGameOver.AutoSize = true;
            this.lbGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lbGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameOver.ForeColor = System.Drawing.Color.Coral;
            this.lbGameOver.Location = new System.Drawing.Point(349, 331);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(794, 132);
            this.lbGameOver.TabIndex = 11;
            this.lbGameOver.Text = "GAME OVER!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.lbGameOver);
            this.Controls.Add(this.lbPause);
            this.Controls.Add(this.btNewGame);
            this.Controls.Add(this.btPause);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.pbGame);
            this.Controls.Add(this.pbControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CityDefender";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGame;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Timer tmTankMove;
        private System.Windows.Forms.PictureBox pbControl;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Button btNewGame;
        private System.Windows.Forms.Label lbPause;
        private System.Windows.Forms.Label lbGameOver;
    }
}

