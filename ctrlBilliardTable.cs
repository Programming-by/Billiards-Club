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
        /*
         
         Send Price to Form4
         Send Table Time to Form4
         
         */

        public ctrlBilliardTable()
        {
            InitializeComponent();

            
        }

        struct stCounter
        {
            public int CountSeconds;
            public int CountMinutes;
            public int CountHours;
        }
        stCounter Counter1 = new stCounter();

        public string Player;
        public static int Price;
        public static string TableTime;



        private void ResetCounter(ref stCounter Counter)
        {

            Counter.CountSeconds = 0;
            Counter.CountMinutes = 0;
            Counter.CountHours = 0;

        }
        private void IncreaseTime(ref stCounter Counter)
        {
            if (Counter.CountSeconds > 59)
            {

                Counter.CountMinutes++;
                Counter.CountSeconds = 0;
            }

            if (Counter.CountMinutes > 59)
            {

                Counter.CountHours++;
                Counter.CountMinutes = 0;
            }

            if (Counter.CountHours > 23)
            {
                Counter.CountSeconds = 0;
                Counter.CountMinutes = 0;
                Counter.CountHours = 0;
            }

        }

        private void ChangeTimerFormat(ref stCounter Counter, Label lbl)
        {

            string AddSZero = " :0";
            string AddMZero = " :0";
            string AddHZero = "0";

            if (Counter.CountSeconds > 9)
            {
                AddSZero = " : ";
            }

            if (Counter.CountMinutes > 9)
            {
                AddMZero = " : ";

            }

            if (Counter.CountHours > 9)
            {
                AddHZero = " ";
            }

            lbl.Text = AddHZero + Counter.CountHours.ToString() + AddMZero + Counter.CountMinutes.ToString() + AddSZero + Counter.CountSeconds.ToString();

            TableTime = lblTime1.Text.ToString();
        }

        private void IncreasePrice(stCounter Counter)
        {

            if (Counter.CountMinutes == 1)
            {
                Price = 1;
            }
            if (Counter.CountMinutes == 2)
            {
                Price = 2;
            }

            if (Counter.CountMinutes == 3)
            {
                Price = 3;
            }

            if (Counter.CountMinutes == 5)
            {
                Price = 5;
            }
        }

        private void ChangePrice()
        {

            lblPrice1.Text = Price + "$";

        }

        public void CurrentPlayer()
        {
            Player = lblPlayer1.Text.ToString();


        }

        public void btnStart1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter1.CountSeconds++;
            IncreasePrice(Counter1);

            IncreaseTime(ref Counter1);
            ChangeTimerFormat(ref Counter1, lblTime1);
        }

        private void btnPause1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ChangePrice();
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ResetCounter(ref Counter1);
            CurrentPlayer();
            ChangePrice();

        }

        public void ChangePlayerName(string PlayerName)
        {
                lblPlayer1.Text = PlayerName;

        }

        public static int ShowPrice()
        {
           return Price;
        }
        public static string ShowTableTime()
        {
            return TableTime;
        }


    }
}
