using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTRO
{
    public interface IScreencast
    {
        int ButtonID{get;set;}
        void showScreencast(FrmMain buehne);

    }
}
