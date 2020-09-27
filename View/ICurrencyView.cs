using System;

namespace Currency_MVC.View
{
    internal interface ICurrencyView
    {
        event Action StartTrackClick;
        event Action StopTrackClick;
        
        void SetValue(string value);
    }
}
