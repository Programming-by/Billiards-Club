using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billiards_Club
{
    public partial class Form3 : Form
    {
        public Form3()
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
        stCounter Counter2 = new stCounter();
        stCounter Counter3 = new stCounter();
        stCounter Counter4 = new stCounter();

        private int Price;
        private string Player;
        private string TableTime;

        private void ResetCounter (ref stCounter Counter )
        {

            Counter.CountSeconds = 0;
            Counter.CountMinutes = 0;
            Counter.CountHours = 0;

        }
        private void IncreaseTime( ref stCounter Counter)
        {
            if (Counter.CountSeconds > 59) {

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
                Counter.CountHours   = 0;
            }

        }

        private void ChangeTimerFormat(  ref stCounter Counter, Label lbl)
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

            TableTime = lbl.Text.ToString();
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

        private void ChangePrice(Label lbl)
        {

            lbl.Text = Price + "$";

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter1.CountSeconds++;
            IncreasePrice(Counter1);

            IncreaseTime(ref Counter1);
            ChangeTimerFormat(ref Counter1,lblTime1);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Counter2.CountSeconds++;
            IncreasePrice(Counter2);

            IncreaseTime(ref Counter2);
            ChangeTimerFormat(ref Counter2, lblTime2);


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Counter3.CountSeconds++;
            IncreasePrice(Counter3);
            IncreaseTime(ref Counter3);
            ChangeTimerFormat(ref Counter3, lblTime3);


        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Counter4.CountSeconds++;
            IncreasePrice(Counter4);

            IncreaseTime(ref Counter4);
            ChangeTimerFormat(ref Counter4, lblTime4);

        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void btnStart3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void btnStart4_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
       
            ResetCounter(ref Counter1);
            CurrentPlayer(lblPlayer1);
            ChangePrice(lblPrice1);

            btnDetails.Enabled = true;


        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            ResetCounter(ref Counter2);

            CurrentPlayer(lblPlayer2);
            ChangePrice(lblPrice2);
            btnDetails.Enabled = true;

        }

        private void btnStop3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            ResetCounter(ref Counter3);
            CurrentPlayer(lblPlayer3);
            ChangePrice(lblPrice3);
            btnDetails.Enabled = true;


        }

        private void btnStop4_Click(object sender, EventArgs e)
        {
            timer4.Enabled = false;
            ResetCounter(ref Counter4);
            CurrentPlayer(lblPlayer4);
            ChangePrice(lblPrice4);
            btnDetails.Enabled = true;



        }

        private void btnPause1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ChangePrice(lblPrice1);


        }

        private void btnPause2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            ChangePrice(lblPrice1);

        }

        private void btnPause3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            ChangePrice(lblPrice1);

        }

        private void btnPause4_Click(object sender, EventArgs e)
        {
            timer4.Enabled = false;
            ChangePrice(lblPrice1);

        }

        private void CurrentPlayer(Label lbl)
        {
            Player = lbl.Text.ToString();   
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
         if (lblPlayer1.Text == "Player1")
            {
                lblPlayer1.Text = textBox1.Text;
            } else if (lblPlayer2.Text == "Player2")
            {
                lblPlayer2.Text = textBox1.Text;
            } else if (lblPlayer3.Text == "Player3")
            {
                lblPlayer3.Text = textBox1.Text;
            } else if (lblPlayer4.Text == "Player4")
            {
                lblPlayer4.Text = textBox1.Text;
            } else
            {
                MessageBox.Show("No Table Available", "All Tables are Reserved", MessageBoxButtons.OK);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4(Player,Price,TableTime);

            frm.ShowDialog();   


        }
    }
}
