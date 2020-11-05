namespace Final_Project
{
    partial class frmMain
    {

        private System.ComponentModel.IContainer components = null;
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
            this.txtBoard = new System.Windows.Forms.TextBox();
            this.lblScoreBoard = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblTetris = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.txtScoreArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoard
            // 
            this.txtBoard.BackColor = System.Drawing.Color.DimGray;
            this.txtBoard.Location = new System.Drawing.Point(984, 520);
            this.txtBoard.Multiline = true;
            this.txtBoard.Name = "txtBoard";
            this.txtBoard.Size = new System.Drawing.Size(435, 410);
            this.txtBoard.TabIndex = 1;
            // 
            // lblScoreBoard
            // 
            this.lblScoreBoard.AutoSize = true;
            this.lblScoreBoard.BackColor = System.Drawing.Color.Black;
            this.lblScoreBoard.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Bold);
            this.lblScoreBoard.ForeColor = System.Drawing.Color.White;
            this.lblScoreBoard.Location = new System.Drawing.Point(985, 431);
            this.lblScoreBoard.Name = "lblScoreBoard";
            this.lblScoreBoard.Size = new System.Drawing.Size(434, 63);
            this.lblScoreBoard.TabIndex = 2;
            this.lblScoreBoard.Text = "SCORE BOARD";
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPause.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.btnPause.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPause.Location = new System.Drawing.Point(996, 832);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(191, 56);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Gold;
            this.btnNewGame.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btnNewGame.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnNewGame.Location = new System.Drawing.Point(1200, 831);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(211, 57);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblTetris
            // 
            this.lblTetris.AutoSize = true;
            this.lblTetris.BackColor = System.Drawing.Color.Black;
            this.lblTetris.Font = new System.Drawing.Font("OCR A Extended", 44F, System.Drawing.FontStyle.Bold);
            this.lblTetris.ForeColor = System.Drawing.Color.White;
            this.lblTetris.Location = new System.Drawing.Point(917, 66);
            this.lblTetris.Name = "lblTetris";
            this.lblTetris.Size = new System.Drawing.Size(543, 136);
            this.lblTetris.TabIndex = 5;
            this.lblTetris.Text = "TETRIS";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBackground.Location = new System.Drawing.Point(94, 94);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(711, 988);
            this.pnlBackground.TabIndex = 7;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.Font = new System.Drawing.Font("OCR A Extended", 18F);
            this.lblGameStatus.ForeColor = System.Drawing.Color.Red;
            this.lblGameStatus.Location = new System.Drawing.Point(979, 235);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(410, 107);
            this.lblGameStatus.TabIndex = 8;
            this.lblGameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScoreArea
            // 
            this.txtScoreArea.BackColor = System.Drawing.Color.DarkGray;
            this.txtScoreArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtScoreArea.Location = new System.Drawing.Point(1064, 591);
            this.txtScoreArea.Multiline = true;
            this.txtScoreArea.Name = "txtScoreArea";
            this.txtScoreArea.Size = new System.Drawing.Size(279, 109);
            this.txtScoreArea.TabIndex = 6;
            this.txtScoreArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1523, 1222);
            this.Controls.Add(this.lblGameStatus);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.txtScoreArea);
            this.Controls.Add(this.lblTetris);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblScoreBoard);
            this.Controls.Add(this.txtBoard);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp_1);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmMain_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoard;
        private System.Windows.Forms.Label lblScoreBoard;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblTetris;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblGameStatus;
        private System.Windows.Forms.TextBox txtScoreArea;
    }
}

