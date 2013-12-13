using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTRO
{
    public class ColorScreencast:IScreencast
    {
        public int ButtonID { get; set; }

        Color Farbe { get; set; }
        public ColorScreencast(int buttonID,Color farbe) {
            this.ButtonID = buttonID;
            this.Farbe = farbe;

        }
        

        public void showScreencast(FrmMain buehne)
        {
            buehne.clearScreen();
            buehne.BackColor = Farbe;
        }
    }
}
