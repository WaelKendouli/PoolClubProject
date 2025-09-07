using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolClubProject
{
    public partial class PoolTable : UserControl
    {
        public PoolTable()
        {
            InitializeComponent();
        }

        private int _Seconds = 0;
        private int _Minutes = 0;
        private int _Hours = 0;

        private float _HourlyRate = 10;

        [
            Category("Pool table config"),
           Description("Rate per Hour")
        ]

        public float HourlyRate {
            get {
                return _HourlyRate;
            }
            set
            {
                _HourlyRate = value;
            }
        }

        private string _PlayerName = "Player";

        [
            Category("Pool table config"),
           Description("Player Name")
        ]

        public string PlayerName
        {
            get
            {
                return _PlayerName;
            }
            set
            {
                _PlayerName = value;
                lbPlayer.Text = _PlayerName;
            }
        }

        private string _TableName = "Table";

        [
            Category("Pool table config"),
           Description("Player Name")
        ]

        public string TableName
        {
            get
            {
                return _TableName;
            }
            set
            {
                _TableName = value;
                groupBox1.Text = _TableName;
            }
        }

        public class PlayTimeEventsArgs : EventArgs
        {
            public string TimeConsumedText { get; }
            public float RatePerHour { get; }
            public int TotalSeconds { get; }
            public float TotalFees { get; }

            public PlayTimeEventsArgs(string timeConsumedText, float ratePerHour, int totalSeconds, float totalFees)
            {
                TimeConsumedText = timeConsumedText;
                RatePerHour = ratePerHour;
                TotalSeconds = totalSeconds;
                TotalFees = totalFees;
            }
        }

        public event EventHandler<PlayTimeEventsArgs> PlayTimeEnded;

        public void RaiseOnPlayTimeEnds()
        {
            string TimeConsumedString = _GetTimeConsumedStringFormat();
            float RatePerHour = _HourlyRate;
            int TotalSeconds = _GetTotalSeconds();
            float TotalFees = _CalculateTotalFees(TotalSeconds);

            RaiseOnPlayTimeEnds(new PlayTimeEventsArgs(TimeConsumedString, RatePerHour, TotalSeconds, TotalFees));

        }
        public void RaiseOnPlayTimeEnds(PlayTimeEventsArgs e)
        {
            PlayTimeEnded?.Invoke(this, e);
            MessageBox.Show($"Time Consumed {e.TimeConsumedText} , Hourly Rate : {e.RatePerHour} , Total Seconds : {e.TotalSeconds} , Total Fees : {e.TotalFees}");
            _Seconds = 0;
            _Hours = 0;
            _Minutes = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private string _GetTimeConsumedStringFormat()
        {
            string TimeFormat = "";
            if (_Hours < 10)
            {
                TimeFormat = "0" + _Hours.ToString() + ":";
            }
            else
            {
                TimeFormat = _Hours.ToString() + ":";
            }

            if (_Minutes < 10)
            {
                TimeFormat += "0" + _Minutes.ToString() + ":";
            }
            else
            {
                TimeFormat += _Minutes.ToString() + ":";
            }

            if (_Seconds < 10)
            {
                TimeFormat += "0" + _Seconds.ToString();
            }
            else
            {
                TimeFormat += _Seconds.ToString();
            }
            return TimeFormat;
        }

        private int _GetTotalSeconds()
        {
             
            return _Hours * 3600 + _Minutes * 60 + _Seconds;

        }

        private float _CalculateTotalFees(int TotalSeconds)
        {
            float TotalFees;
            TotalFees = (TotalSeconds * _HourlyRate) / 3600;
            return TotalFees;
        }

        private void PoolTable_Load(object sender, EventArgs e)
        {
            btnEnd.Enabled = false;
            btnStop.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnStop.Visible = true;
            btnEnd.Enabled = true;

            tmPlayTime.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmPlayTime.Stop();
            btnStart.Visible = true;
            btnStop.Visible = false;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            tmPlayTime.Stop();
            btnStart.Visible = true;
            btnStop.Visible = false;
            RaiseOnPlayTimeEnds();
            btnEnd.Enabled = false;
        }

        private void tmPlayTime_Tick(object sender, EventArgs e)
        {
            _Seconds++;
            if (_Seconds<10)
            {
                lbSecends.Text = "0" + _Seconds.ToString();
            }
            else
            {
             lbSecends.Text = _Seconds.ToString();   
            }
            
            if (_Seconds==59)
            {
                _Minutes++;
                if (_Minutes < 10)
                {
                    lbMinutes.Text = "0" + _Minutes.ToString();
                }
                else
                {
                    lbMinutes.Text = _Minutes.ToString();
                }
                _Seconds = 0;
                lbSecends.Text = "0" + _Seconds.ToString();

            }
            if (_Minutes==59)
            {
                _Hours++;
                if (_Hours < 10)
                {
                    lbHours.Text = "0" + _Hours.ToString();
                }
                else
                {
                    lbHours.Text = _Hours.ToString();

                }
                _Minutes = 0;
                _Seconds = 0;
                lbMinutes.Text = "0" + _Minutes.ToString();
                lbSecends.Text = "0" + _Seconds.ToString();
            }
        }
    }
}
