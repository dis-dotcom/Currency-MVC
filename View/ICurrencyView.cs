using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_MVC.View
{
    internal interface ICurrencyView
    {
        event Action StartTrackClick;
        event Action StopTrackClick;

        void SetValue(string value);
    }
}
