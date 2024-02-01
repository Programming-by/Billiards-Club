using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billiards_Club
{
    public partial class ctrlBilliardTable : UserControl
    {
        public ctrlBilliardTable()
        {
            InitializeComponent();

            
        }
      
        private float _HourlyRate = 10.00F;
        [
      Category("Pool Config"),
      Description("Rate Per Hour")
        ]
        public float HourlyRate 
        {
            get
            {
                return _HourlyRate;
            } 
            set
            {
                _HourlyRate = value;
            }
        }

        private string _TablePlayer = "Player";
        [
              Category("Pool Config"),
              Description("The Player Name")

        ]
        public string TablePlayer
        {
            get { return _TablePlayer; }

            set
            {
                 _TablePlayer = value;
                lblPlayerName.Text = value;
                Invalidate();


            }
        }
      
        private string _TableTitle = "Table";
        [
             Category("Pool Config") ,
             Description("The Table Name")
         ]
        public string TableTitle
        {
            get { return _TableTitle; }

            set
            {
                _TableTitle = value;
                grpTable.Text = value;
                Invalidate();
            }
        }

        int _Seconds;

        public class TableCompletedEventArgs : EventArgs
        {
            public string TimeText { get; }
            public int TimeInSeconds { get; }
            public float RatePerHour { get; }
            public float TotalFees { get; }
            public TableCompletedEventArgs(string TimeText, int TimeInSeconds, float RatePerHour, float TotalFees)
            {
                this.TimeText = TimeText;
                this.TimeInSeconds = TimeInSeconds;
                this.RatePerHour = RatePerHour;
                this.TotalFees = TotalFees;
            }
        }

        public event EventHandler<TableCompletedEventArgs> OnTableComplete;

        public void RaiseOnTableComplete(string TimeText ,int TimeInSeconds,float RatePerHour,float TotalFees)
        {
            RaiseOnTableComplete(new TableCompletedEventArgs(TimeText,TimeInSeconds,RatePerHour,TotalFees));
        }

        protected virtual void RaiseOnTableComplete(TableCompletedEventArgs e)
        {
            OnTableComplete?.Invoke(this, e);
        }
        private void ctrlBilliardTable_Load(object sender, EventArgs e)
        {
            grpTable.Text = _TableTitle;
            lblPlayerName.Text = _TablePlayer;
        }

        public void frm_DataBackEvent(object sender , string PlayerName)
        {
            lblPlayerName.Text = PlayerName;
            TableTimer.Start();
            btnStartStop.Text = "Stop";
            grpTable.BackColor = Color.Gray;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ++_Seconds;
            TimeSpan time = TimeSpan.FromSeconds(_Seconds);
            string str = time.ToString(@"hh\:mm\:ss");
            lblTime1.Text = str;
            lblTime1.Refresh();
        }
        public void btnStart1_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Stop")
            {
                btnStartStop.Text = "Start";
                TableTimer.Stop();

            }
            else
            {
                if (_Seconds == 0)
                {
                frmAddNewPlayer frm = new frmAddNewPlayer();
                frm.DataBack += frm_DataBackEvent;
                frm.ShowDialog();
                }
                btnStartStop.Text = "Stop";
                TableTimer.Start();
            }


        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            TableTimer.Stop();
            float TotalFees = (float) _Seconds / 60 / 60 * HourlyRate;
            RaiseOnTableComplete(lblTime1.Text ,_Seconds , _HourlyRate , TotalFees);
            grpTable.Text = "Table";
            lblPlayerName.Text = "Player";
            lblTime1.Text = "00:00:00";
            btnStartStop.Text = "Start";
            _Seconds = 0;
            grpTable.BackColor = Color.White;
        }

    }
}
