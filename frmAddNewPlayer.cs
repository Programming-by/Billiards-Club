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
    public partial class frmAddNewPlayer : Form
    {
        public frmAddNewPlayer()
        {
            InitializeComponent();
        }

        public delegate void DataBackHandler(object sender, string PlayerName);

        public event DataBackHandler DataBack;

        private void txtPlayerName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlayerName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPlayerName, "Player Name cannot be empty");
            } else
            {
                errorProvider1.SetError(txtPlayerName, "");
            }
        }

   

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, txtPlayerName.Text);
            this.Close();

        }
    }
}
