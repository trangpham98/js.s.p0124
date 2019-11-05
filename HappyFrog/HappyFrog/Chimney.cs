using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyFrog
{
    class Chimney
    {
        public int xLocationChimney;
        public int SpaceNull;
        public int yLocationChimneyTop, yLocationChimneyBot;
       

        public int Leave(int oldXLocation)
        {
            xLocationChimney = oldXLocation - 5;
            return xLocationChimney;
        }

        public void CreateNewChimey(int XLocation, int YLocation, int width, int heigth, int widthForm, int spaceNull)
        {
            //khi ống khói chưa chạy hết thì sẽ tiếp tục chạy về bên trái,khi ống khói  chạy hết form sẽ vòng lặp xuất hiện ở đầu bên phải
            if (XLocation + width > 0)
            {
                xLocationChimney = XLocation;
                yLocationChimneyTop = YLocation;
                yLocationChimneyBot = YLocation+ heigth+ spaceNull;
                SpaceNull = spaceNull;

            }
            else
            {
                Random rd = new Random();
                XLocation = widthForm;
                YLocation = rd.Next(-250, -50);
                SpaceNull = rd.Next(130, 170);
                xLocationChimney = XLocation;
                yLocationChimneyTop = YLocation;
                yLocationChimneyBot = YLocation + heigth + SpaceNull;
            }

        }
    }
}
