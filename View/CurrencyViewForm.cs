using System;
using System.Windows.Forms;

namespace Currency_MVC.View
{
    public partial class CurrencyView : Form, ICurrencyView
    {
        public event Action StartTrackClick;
        public event Action StopTrackClick;

        private bool _canClick;

        public CurrencyView()
        {
            InitializeComponent();
        }

        public void SetValue(string value)
        {
            usdValueLabel.Invoke(new Action(() => usdValueLabel.Text = value ));
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!_canClick)
                return;

            _canClick = false;
            StartTrackClick?.Invoke();
            SetStopState();
            _canClick = true;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (!_canClick)
                return;

            _canClick = false;
            StopTrackClick?.Invoke();
            SetStartState();
            _canClick = true;
        }

        private void CurrencyView_Shown(object sender, EventArgs e)
        {
            _canClick = true;
            SetStartState();
        }

        private void SetStartState() 
        {
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
        }

        private void SetStopState()
        {
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
        }
    }
}
