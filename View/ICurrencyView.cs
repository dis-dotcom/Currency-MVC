using System;

namespace Currency_MVC.View
{
    public interface ICurrencyView
    {
        event Action StartTrackClick;
        event Action StopTrackClick;
        
        void SetValue(string value);
    }
}
