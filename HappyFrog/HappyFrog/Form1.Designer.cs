namespace HappyFrog
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
            this.timerRunChimney = new System.Windows.Forms.Timer(this.components);
            this.ptbTop1 = new System.Windows.Forms.PictureBox();
            this.ptbTop2 = new System.Windows.Forms.PictureBox();
            this.ptbBot1 = new System.Windows.Forms.PictureBox();
            this.ptbBot2 = new System.Windows.Forms.PictureBox();
            this.ptbFrog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFrog)).BeginInit();
            this.SuspendLayout();
            // 
            // timerRunChimney
            // 
            this.timerRunChimney.Interval = 1;
            this.timerRunChimney.Tick += new System.EventHandler(this.timerRunChimney_Tick);
            // 
            // ptbTop1
            // 
            this.ptbTop1.Location = new System.Drawing.Point(192, 0);
            this.ptbTop1.Name = "ptbTop1";
            this.ptbTop1.Size = new System.Drawing.Size(100, 50);
            this.ptbTop1.TabIndex = 0;
            this.ptbTop1.TabStop = false;
            this.ptbTop1.Click += new System.EventHandler(this.ptbTop1_Click);
            // 
            // ptbTop2
            // 
            this.ptbTop2.Location = new System.Drawing.Point(470, -12);
            this.ptbTop2.Name = "ptbTop2";
            this.ptbTop2.Size = new System.Drawing.Size(100, 50);
            this.ptbTop2.TabIndex = 1;
            this.ptbTop2.TabStop = false;
            // 
            // ptbBot1
            // 
            this.ptbBot1.Location = new System.Drawing.Point(192, 380);
            this.ptbBot1.Name = "ptbBot1";
            this.ptbBot1.Size = new System.Drawing.Size(100, 50);
            this.ptbBot1.TabIndex = 2;
            this.ptbBot1.TabStop = false;
            // 
            // ptbBot2
            // 
            this.ptbBot2.Location = new System.Drawing.Point(470, 380);
            this.ptbBot2.Name = "ptbBot2";
            this.ptbBot2.Size = new System.Drawing.Size(100, 50);
            this.ptbBot2.TabIndex = 3;
            this.ptbBot2.TabStop = false;
            // 
            // ptbFrog
            // 
            this.ptbFrog.Location = new System.Drawing.Point(-2, 181);
            this.ptbFrog.Name = "ptbFrog";
            this.ptbFrog.Size = new System.Drawing.Size(100, 50);
            this.ptbFrog.TabIndex = 4;
            this.ptbFrog.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyFrog.Properties.Resources.backgroud___Copy;
            this.ClientSize = new System.Drawing.Size(660, 431);
            this.Controls.Add(this.ptbFrog);
            this.Controls.Add(this.ptbBot2);
            this.Controls.Add(this.ptbBot1);
            this.Controls.Add(this.ptbTop2);
            this.Controls.Add(this.ptbTop1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFrog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerRunChimney;
        private System.Windows.Forms.PictureBox ptbTop1;
        private System.Windows.Forms.PictureBox ptbTop2;
        private System.Windows.Forms.PictureBox ptbBot1;
        private System.Windows.Forms.PictureBox ptbBot2;
        private System.Windows.Forms.PictureBox ptbFrog;
    }
}

