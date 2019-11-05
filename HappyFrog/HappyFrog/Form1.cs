using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HappyFrog
{
    public partial class Form1 : Form
    {
        //// Original Location of chimney 1
        int yLocation1 =-100;
        int xLocation1=500;
        ////  Original Location of chimney 2
        int yLocation2 =-150;
        int xLocation2;
        //Space null  between chimney top 1 and chimney botton 1
        int spaceNull1;
        //Space null  between chimney top 2 and chimney botton 2
        int spaceNull2;
        //  Original Location of frog
        int xLocationFrog =20;
        int yLocationFrog=50;
        
        int scores=0;

        // message
        string msg;

        Random rd = new Random();
        Chimney cm = new Chimney();
        Frog Fg = new Frog();

        public Form1()
        {
            InitializeComponent();
            this.Width = 510;
        }
       

        public void Form1_Load(object sender, EventArgs e)
        {

            Image img = Image.FromFile("F:\\codeVisual\\HappyFrog\\HappyFrog\\Resources\\chimneyTop.png");

            //create top chimney 1 

            ptbTop1.Width = img.Width;
            ptbTop1.Height = img.Height;
            ptbTop1.Location = new Point(xLocation1, yLocation1);

            ptbTop1.ImageLocation = @"F:\codeVisual\HappyFrog\HappyFrog\Resources\chimneyTop.png";
            ptbTop1.BackColor = Color.Transparent;

            //create botton chimney1

            spaceNull1 = rd.Next(130, 170);
            ptbBot1.Width = img.Width;
            ptbBot1.Height = img.Height;
            ptbBot1.Location = new Point(xLocation1, yLocation1 + ptbTop2.Width + spaceNull1);

            ptbBot1.ImageLocation = @"F:\codeVisual\HappyFrog\HappyFrog\Resources\chimneyBotton.png";
            ptbBot1.BackColor = Color.Transparent;


            ////create top chimney 2
            xLocation2 = xLocation1 + 250;
            ptbTop2.Width = img.Width;
            ptbTop2.Height = img.Height;
            ptbTop2.Location = new Point(xLocation2, yLocation2);
           
            ptbTop2.ImageLocation = @"F:\codeVisual\HappyFrog\HappyFrog\Resources\chimneyTop.png";
            ptbTop2.BackColor = Color.Transparent;

            //create botton chimney2
            spaceNull2 = rd.Next(130, 170);
            ptbBot2.Width = img.Width;
            ptbBot2.Height = img.Height;
            ptbBot2.Location = new Point(xLocation2, yLocation2 + ptbTop2.Width + spaceNull2);

            ptbBot2.ImageLocation = @"F:\codeVisual\HappyFrog\HappyFrog\Resources\chimneyBotton.png";
            ptbBot2.BackColor = Color.Transparent;


            //create frog
            Image imgFrog = Image.FromFile("F:\\codeVisual\\HappyFrog\\HappyFrog\\Resources\\frog.png");

            ptbFrog.Width = imgFrog.Width;
            ptbFrog.Height = imgFrog.Height;
            ptbFrog.Location = new Point(xLocationFrog, yLocationFrog);

            ptbFrog.ImageLocation = @"F:\codeVisual\HappyFrog\HappyFrog\Resources\frog.png";
            ptbFrog.BackColor = Color.Transparent;


            timerRunChimney.Start();
        }


        private void timerRunChimney_Tick(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            
            //chimney  leave on the form
            xLocation1 = cm.Leave(xLocation1);
            xLocation2 = cm.Leave(xLocation2);

            
            cm.CreateNewChimey(xLocation1, yLocation1, ptbTop1.Width, ptbTop1.Height, this.Width, spaceNull1);
            xLocation1 = cm.xLocationChimney;
            yLocation1 = cm.yLocationChimneyTop;
            spaceNull1 = cm.SpaceNull;
            ptbTop1.Location = new Point(xLocation1, yLocation1);
            ptbBot1.Location = new Point(xLocation1,cm.yLocationChimneyBot);

            cm.CreateNewChimey(xLocation2, yLocation2, ptbTop2.Width, ptbTop2.Height, this.Width, spaceNull2);
            xLocation2 = cm.xLocationChimney;
            yLocation2 = cm.yLocationChimneyTop;
            spaceNull2 = cm.SpaceNull;
            ptbTop2.Location = new Point(xLocation2, yLocation2);
            ptbBot2.Location = new Point(xLocation2, cm.yLocationChimneyBot);


            //Frog fall
            yLocationFrog = Fg.Fall(yLocationFrog);
            ptbFrog.Location = new Point(xLocationFrog, yLocationFrog);

            Scores();

            //Impact();
            if (Fg.Impact(xLocation1, yLocation1, spaceNull1, ptbFrog.Width, ptbTop1.Width, ptbFrog.Height, ptbTop1.Height, this.Height))
            {
                timerRunChimney.Stop();
                MessageBox.Show("You will with " + scores + " score\nCongratulations on your " + Message(scores));
            }
            if (Fg.Impact(xLocation2, yLocation2, spaceNull2, ptbFrog.Width, ptbTop2.Width, ptbFrog.Height, ptbTop2.Height, this.Height))
            {
                timerRunChimney.Stop();
                MessageBox.Show("You will with " + scores + " score\nCongratulations on your " + Message(scores));
            }

        }



        //calculate the score
        public int Scores()
        {
            // when a frog goes through chimney  will be added a score
            if ((xLocation1 + ptbTop1.Width)==xLocationFrog|| (xLocation2 + ptbTop1.Width) == xLocationFrog)
            {
                scores++;
            }
            return scores;
        }

        public String Message(int score)
        {
            
            if (score < 10)
            {
                msg = "no medal !";
            }
            if(score >= 10 && score < 20)
            {
                msg = "bronze medal !";
            }
            if(score>=20&& score < 30)
            {
                msg = "silver medal !";
            }
            if (score >= 30)
            {
                msg = "gold medal ! ";
            }
            return msg;
        }

        //When you click mouse , frog will jump 50 pixel
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            yLocationFrog = Fg.Jump(yLocationFrog);
            ptbFrog.Location = new Point(xLocationFrog, yLocationFrog);
        }

        private void ptbTop1_Click(object sender, EventArgs e)
        {

        }
    }
}
