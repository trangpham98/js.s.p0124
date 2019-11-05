using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HappyFrog
{
    class Frog
    {
        
        public int yLocation;
        public int xLocation;

        //frog jumps 50 pixel
        public int Jump(int OldYLocation)
        {
            yLocation = OldYLocation - 50;
            return yLocation;
        }

        //Compare the impact of frog
        public bool Impact(int xLocationChimney, int yLocationChimneyTop, int spaceNull, int widthFrog, int widthChimney, int heightFrog, int heightChimney, int height)
        {
            int Xf = xLocation + widthFrog;
            int Yf = yLocation + heightFrog;
            int Xcm1 = xLocationChimney + widthChimney;
            int Ycmt1 = yLocationChimneyTop + heightChimney;
            int Ycmb1 = yLocationChimneyTop + heightChimney + spaceNull;

            //when the frog hit the chimney
            if (((yLocation <= Ycmt1) || (Yf >= Ycmb1)) && (Xcm1 >= Xf) && (Xf >= xLocationChimney))
            {
                return true;
            }

            //when the frog touches the floor
            if (Yf >= height)
            {
                return true;
            }
            return false;
        }


        //Frog falls
        public int Fall(int OldYLocation)
        {
            yLocation = OldYLocation + 3;
            return yLocation;
        }



    }
}
