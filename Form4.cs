using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billiards_Club
{
    public partial class Form4 : Form
    {
        private string _Player;
        private int _Price;
        private string _TableTime;


        public Form4(string Player, int Price, string TableTime)
        {
            InitializeComponent();
            _Player = Player;
            _Price = Price;
            _TableTime = TableTime;
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            lblPlayer.Text     = _Player;
            lblTotalPrice.Text = _Price + "$";
            lblTotalTime.Text  = _TableTime;

        }
    }
}
