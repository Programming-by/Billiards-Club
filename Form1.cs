using System;
using System.Windows.Forms;
using System.Threading;

namespace Billiards_Club
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;


            for (int i = 1; i <= 10; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(500);
                    progressBar1.Value += 10;
                    lblProgress.Text = ((float)progressBar1.Value / progressBar1.Maximum * 100 + "%");
                    progressBar1.Refresh();
                    lblProgress.Refresh();
                }
            }

            Form2 frm = new Form2();
            frm.ShowDialog();

        }
    }
}
