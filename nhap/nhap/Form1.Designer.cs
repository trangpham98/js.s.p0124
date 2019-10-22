namespace nhap
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
            this.pnl = new System.Windows.Forms.Panel();
            this.lblNoOfMove = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.timePlayGame = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(12, 2);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(273, 239);
            this.pnl.TabIndex = 0;
            // 
            // lblNoOfMove
            // 
            this.lblNoOfMove.AutoSize = true;
            this.lblNoOfMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfMove.Location = new System.Drawing.Point(64, 277);
            this.lblNoOfMove.Name = "lblNoOfMove";
            this.lblNoOfMove.Size = new System.Drawing.Size(108, 20);
            this.lblNoOfMove.TabIndex = 1;
            this.lblNoOfMove.Text = "Move Count: ";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(67, 350);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(143, 44);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // cboLevel
            // 
            this.cboLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "4 x 4",
            "3 x 3"});
            this.cboLevel.Location = new System.Drawing.Point(127, 313);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(83, 28);
            this.cboLevel.TabIndex = 15;
            this.cboLevel.SelectedIndexChanged += new System.EventHandler(this.CboLevel_SelectedIndexChanged);
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(63, 316);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(58, 20);
            this.lbSize.TabIndex = 14;
            this.lbSize.Text = "Size :";
            this.lbSize.Click += new System.EventHandler(this.LbSize_Click);
            // 
            // lblElapsed
            // 
            this.lblElapsed.AutoSize = true;
            this.lblElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsed.Location = new System.Drawing.Point(64, 245);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(79, 20);
            this.lblElapsed.TabIndex = 16;
            this.lblElapsed.Text = "Elapsed: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 17;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(138, 248);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(0, 17);
            this.lblSecond.TabIndex = 18;
            // 
            // timePlayGame
            // 
            this.timePlayGame.Enabled = true;
            this.timePlayGame.Interval = 1000;
            this.timePlayGame.Tick += new System.EventHandler(this.TimePlayGame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 414);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblElapsed);
            this.Controls.Add(this.cboLevel);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblNoOfMove);
            this.Controls.Add(this.pnl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblNoOfMove;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Timer timePlayGame;
    }
}

