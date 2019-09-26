namespace js.s.p0124
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
        ///// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Black = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.Fuchsia = new System.Windows.Forms.Button();
            this.Aqua = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(665, 7);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(135, 58);
            this.Black.TabIndex = 8;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Black_Click_1);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(665, 59);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(135, 58);
            this.Red.TabIndex = 16;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Black_Click_1);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(665, 385);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(135, 58);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(665, 329);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(135, 58);
            this.yellow.TabIndex = 10;
            this.yellow.UseVisualStyleBackColor = false;
            this.yellow.Click += new System.EventHandler(this.Black_Click_1);
            // 
            // Fuchsia
            // 
            this.Fuchsia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Fuchsia.Location = new System.Drawing.Point(665, 274);
            this.Fuchsia.Name = "Fuchsia";
            this.Fuchsia.Size = new System.Drawing.Size(135, 58);
            this.Fuchsia.TabIndex = 11;
            this.Fuchsia.UseVisualStyleBackColor = false;
            this.Fuchsia.Click += new System.EventHandler(this.Black_Click_1);
            // 
            // Aqua
            // 
            this.Aqua.BackColor = System.Drawing.Color.Aqua;
            this.Aqua.Location = new System.Drawing.Point(665, 224);
            this.Aqua.Name = "Aqua";
            this.Aqua.Size = new System.Drawing.Size(135, 58);
            this.Aqua.TabIndex = 12;
            this.Aqua.UseVisualStyleBackColor = false;
            this.Aqua.Click += new System.EventHandler(this.Black_Click_1);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(665, 169);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(135, 58);
            this.Blue.TabIndex = 15;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Black_Click_1);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Green.Location = new System.Drawing.Point(665, 114);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(135, 58);
            this.Green.TabIndex = 14;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Black_Click_1);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 7);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(669, 436);
            this.pnlMain.TabIndex = 13;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMain_Paint);
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlMain_MouseDown);
            this.pnlMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlMain_MouseMove);
            this.pnlMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlMain_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.Fuchsia);
            this.Controls.Add(this.Aqua);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.pnlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button Fuchsia;
        private System.Windows.Forms.Button Aqua;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Panel pnlMain;
    }
}

