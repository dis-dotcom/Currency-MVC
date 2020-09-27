using Currency_MVC.View;
using System;
using System.Windows.Forms;

namespace Currency_MVC
{
    public partial class CurrencyView : Form, ICurrencyView
    {
        public event Action StartTrackClick;
        public event Action StopTrackClick;

        private bool canClick;

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
            if (!canClick)
                return;

            canClick = false;
            StartTrackClick?.Invoke();
            SetStopState();
            canClick = true;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (!canClick)
                return;

            canClick = false;
            StopTrackClick?.Invoke();
            SetStartState();
            canClick = true;
        }

        private void CurrencyView_Shown(object sender, EventArgs e)
        {
            canClick = true;
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
