using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
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

        public string Player;

        private void btnAdd_Click(object sender, EventArgs e)
        {

            ctrlBilliardTable[] ctrlBilliardTableArray = { ctrlBilliardTable1, ctrlBilliardTable2, ctrlBilliardTable3 };

            for (int i = 0; i < ctrlBilliardTableArray.Length; i++)
            {

                if (ctrlBilliardTableArray[i].Tag == "0")
                {
                    ctrlBilliardTableArray[i].Tag = "1";
                    ctrlBilliardTableArray[i].ChangePlayerName(textBox1.Text);
                    ctrlBilliardTableArray[i].CurrentPlayer();
                    Player = ctrlBilliardTableArray[i].Player;


                    return;
                }

                if (ctrlBilliardTableArray[i].Tag == "0")
                {
                    ctrlBilliardTableArray[i].Tag = "1";
                    ctrlBilliardTableArray[i].ChangePlayerName(textBox1.Text);
                    ctrlBilliardTableArray[i].CurrentPlayer();
                    Player = ctrlBilliardTableArray[i].Player;


                    return;

                }

                if (ctrlBilliardTableArray[i].Tag == "0")
                {
                    ctrlBilliardTableArray[i].Tag = "1";
                    ctrlBilliardTableArray[i].ChangePlayerName(textBox1.Text);
                    ctrlBilliardTableArray[i].CurrentPlayer();
                    Player = ctrlBilliardTableArray[i].Player;

                    return;

                }

            }


            }

       
        private void btnDetails_Click(object sender, EventArgs e)
        {
           
            Form4 frm = new Form4(Player,ctrlBilliardTable.Price, ctrlBilliardTable.TableTime);

            frm.ShowDialog();

        }

    }
}
