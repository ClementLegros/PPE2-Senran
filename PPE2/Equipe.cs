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

        private void Equipe_Load(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string modeDeJeux = "";

            if(checkBoxInvasion.Checked)
            {
                checkBoxNest.Enabled = false;
                checkBoxPvp.Enabled = false;
                modeDeJeux = "INVASION";
            }
            if (checkBoxPvp.Checked)
            {
                checkBoxNest.Enabled = false;
                checkBoxInvasion.Enabled = false;
                modeDeJeux = "PVP";
            }
            if (checkBoxNest.Checked)
            {
                checkBoxInvasion.Enabled = false;
                checkBoxPvp.Enabled = false;
                modeDeJeux = "NEST";
            }

            string triTypePrincipale = (string)listBoxConditionPrincipaleType.SelectedItem;
            string triCouleurPrincipale = (string)listBoxConditionPrincipaleCouleur.SelectedItem;

            string triTypeSecondaire = (string)listBoxConditionSecondaireType.SelectedItem;
            string triCouleurSecondaire = (string)listBoxConditionSecondaireCouleur.SelectedItem;

            List<Carte> listCarte = Connection.getListCarteForTeam(triTypePrincipale,triCouleurPrincipale,triTypeSecondaire,triCouleurSecondaire,modeDeJeux);
            //if(listCarte.Count < 5)
            //{
            //    MessageBox.Show("Vous n'avez pas assez de personnage pour composer une équipe");
            //}
            //else
            //{
                pictureBoxFormationAuto1.Load(listCarte[0].getLogo());
                pictureBoxFormationAuto2.Load(listCarte[1].getLogo());
                //pictureBoxFormationAuto3.Load(listCarte[2].getLogo());
                //pictureBoxFormationAuto4.Load(listCarte[3].getLogo());
                //pictureBoxFormationAuto5.Load(listCarte[4].getLogo());

            //    DialogResult dialogResult = MessageBox.Show("Voulez vous sauvegarder votre équipe ? ", "Sauvegarder", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        //do something
            //    }
            //    else if (dialogResult == DialogResult.No)
            //    {
            //        //do something else
            //    }
            //}
        }
    }
}
