using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE2
{
    public partial class Equipe : Form
    {
        public Equipe()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
   
        }

        private void checkBoxNest_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxNest.Checked)
            {
                checkBoxInvasion.Enabled = false;
                checkBoxPvp.Enabled = false;
            }
            else
            {
                checkBoxInvasion.Enabled = true;
                checkBoxPvp.Enabled = true;
            }
        }

        private void checkBoxPvp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPvp.Checked)
            {
                checkBoxInvasion.Enabled = false;
                checkBoxNest.Enabled = false;
            }
            else
            {
                checkBoxInvasion.Enabled = true;
                checkBoxNest.Enabled = true;
            }
        }

        private void checkBoxInvasion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInvasion.Checked)
            {
                checkBoxNest.Enabled = false;
                checkBoxPvp.Enabled = false;
            }
            else
            {
                checkBoxNest.Enabled = true;
                checkBoxPvp.Enabled = true;
            }
        }
    }
}
