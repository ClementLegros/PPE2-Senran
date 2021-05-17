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
    public partial class AccueilAdmin : Form
    {
        public AccueilAdmin()
        {
            InitializeComponent();
        }

        private void buttonPersonnage_Click(object sender, EventArgs e)
        {
            adminPersonnage ap = new adminPersonnage();
            this.Hide();
            ap.Show();
        }

        private void buttonCarte_Click(object sender, EventArgs e)
        {
            adminCarte ac = new adminCarte();
            this.Hide();
            ac.Show();
        }
    }
}
