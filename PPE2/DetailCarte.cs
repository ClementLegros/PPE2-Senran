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
    public partial class DetailCarte : Form
    {
        public string nom;
        public string ecole;
        public string aptLeader;
        public string aptPassif;
        public string couleur;
        public string type;
        public int pvpRating;
        public int nestRating;
        public int invasionRating;

        public DetailCarte()
        {
            InitializeComponent();
            
        
        }

        private void DetailCarte_Load(object sender, EventArgs e)
        {
            MessageBox.Show(nom);
        }
    }
}
