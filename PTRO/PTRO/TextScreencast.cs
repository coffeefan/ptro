using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTRO
{
    public class TextScreencast:IScreencast
    {
        public int ButtonID { get; set; }

        String ScreenText { get; set; }

        public TextScreencast(int buttonID, String screenText)
        {
            this.ButtonID = buttonID;
            this.ScreenText = screenText;
        }
        

        public void showScreencast(FrmMain buehne)
        {
            buehne.clearScreen();
            buehne.getTextLabel().Text = ScreenText;
            buehne.getTextLabel().Top = (int)((buehne.Height / 2) - (buehne.getTextLabel().Height / 2));
            buehne.getTextLabel().Left = (int)((buehne.Width / 2) - (buehne.getTextLabel().Width / 2));
            buehne.getTextLabel().Visible = true;
        }
    }
}
