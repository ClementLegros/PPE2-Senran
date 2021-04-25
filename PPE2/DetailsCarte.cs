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
    public partial class DetailsCarte : Form
    {
        public string nomCarte;
        public string imgCarte;
        public DetailsCarte()
        {
            InitializeComponent();
        }

        private void DetailsCarte_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(imgCarte);
            labelNomCarte.Text = "Carte";
            pictureBoxPersonnage.Load(imgCarte);
        }
    }
}
