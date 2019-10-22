using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace js.s.p0124
{
    public partial class Form1 : Form
    {
        Graphics g;
        
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;



        public Form1()
        {
            InitializeComponent();
            g = pnlMain.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 2);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

       

        private void PnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            pnlMain.Cursor = Cursors.Cross;
        }

        private void PnlMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving==true && x != -1 && y != -1) 
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void PnlMain_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            pnlMain.Cursor = Cursors.Default;
        }

        private void Black_Click_1(object sender, EventArgs e)
        {
            Button p = (Button)sender;
            pen.Color = p.BackColor;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }
    }
}
