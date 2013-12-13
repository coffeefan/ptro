using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTRO
{
    public class FotoScreencast :IScreencast
    {
        private Bitmap bitmap;

        public FotoScreencast(int buttonID, String pfad)
        {
            this.ButtonID = buttonID;
            setPictureBox(pfad);
        }

        public void setPictureBox(String pfad)
        {
            bitmap = new Bitmap(pfad);
        }
        public int ButtonID { get; set; }

        public void showScreencast(FrmMain buehne)
        {
            buehne.clearScreen();
            buehne.getPicBox().Image = bitmap;
            buehne.getPicBox().Width = bitmap.Width;
            buehne.getPicBox().Height = bitmap.Height;
            buehne.getPicBox().Top = (int)((buehne.Height / 2) - (buehne.getPicBox().Height / 2));
            buehne.getPicBox().Left = (int)((buehne.Width / 2) - (buehne.getPicBox().Width / 2));
            buehne.getPicBox().Visible = true;
        }
        

    }
}
