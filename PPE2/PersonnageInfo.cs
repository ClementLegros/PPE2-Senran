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
    public partial class PersonnageInfo : Form
    {
        public PersonnageInfo()
        {
            InitializeComponent();
        }

        private void PersonnageInfo_Load(object sender, EventArgs e)
        {
            listBoxPersonnage.Items.Clear();
            listBoxPersonnage.Items.AddRange(Connection.getPersonnage().ToArray());

        }

        private void listBoxPersonnage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On récupère et ajoute les informations
            Personnage perso = (Personnage)listBoxPersonnage.SelectedItem;
            pictureBoxChibiPersonnage.Load(perso.getLogoChibi());
            labelNomPersonnage.Text = perso.getNomPersonnage();
            labelAge.Text = Convert.ToString(perso.getAge());
            labelEcole.Text = perso.getEcole();
            labelTaille.Text = Convert.ToString(perso.getTaille()) + "cm";

            //On rend visible les controls
            pictureBoxChibiPersonnage.Visible = true;
            labelNomPersonnage.Visible = true;
            labelTaille.Visible = true;
            labelAge.Visible = true;
            labelTaille.Visible = true;
        }
    }
}
