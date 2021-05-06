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
    public partial class Administrateur : Form
    {
        public Administrateur()
        {
            InitializeComponent();
            //listBoxAdministrateurPersonnage.Items.Clear();
            //List<Personnage> listPerso = Connection.getToutLesPersonnages();
            //listBoxAdministrateurPersonnage.Items.AddRange(listPerso.ToArray());
        }

        private void buttonAjouterPersonnage_Click(object sender, EventArgs e)
        {
            //Regarde si une textBox n'a pas était laissé vide et affiche un messagae d'erreur si une ou plusieurs on était laissé vide

            if (string.IsNullOrEmpty(textBoxAjouterNomPersonnage.Text) ||  string.IsNullOrEmpty(textBoxAjouterCouleur.Text) || string.IsNullOrEmpty(textBoxAjouterType.Text) || string.IsNullOrEmpty(textBoxAjouterForcePhy.Text) || string.IsNullOrEmpty(textBoxAjouterPuissanceOff.Text) || string.IsNullOrEmpty(textBoxAjouterDefense.Text) || string.IsNullOrEmpty(textBoxAjouterAgilite.Text) || string.IsNullOrEmpty(textBoxAjouterLienImageCarte.Text) || string.IsNullOrEmpty(textBoxAjouterLogoCarte.Text) || string.IsNullOrEmpty(textBoxAjouterNinja.Text) || string.IsNullOrEmpty(textBoxAjouterNinjaSecret.Text) || string.IsNullOrEmpty(textBoxAjouterEcole.Text) || string.IsNullOrEmpty(textBoxAjouterPtdLeader.Text) || string.IsNullOrEmpty(textBoxAjouterPassif.Text) || string.IsNullOrEmpty(textBoxAjouterRankPVP.Text) || string.IsNullOrEmpty(textBoxAjouterRankNest.Text) || string.IsNullOrEmpty(textBoxAjouterRankInvasion.Text))
            {
                MessageBox.Show("Une ou plusieurs cases à été laissé vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Personnage persoCree = new Personnage(Convert.ToInt32(null), textBoxAjouterNomPersonnage.Text, textBoxAjouterEcole.Text, Convert.ToInt32(textBoxAjouterForcePhy.Text), Convert.ToInt32(textBoxAjouterPuissanceOff.Text), Convert.ToInt32(textBoxAjouterDefense.Text), Convert.ToInt32(textBoxAjouterAgilite.Text), textBoxAjouterPtdLeader.Text, textBoxAjouterPassif.Text, textBoxAjouterNinja.Text, textBoxAjouterNinjaSecret.Text, textBoxAjouterCouleur.Text, textBoxAjouterType.Text, Convert.ToInt32(textBoxAjouterRankPVP.Text), Convert.ToInt32(textBoxAjouterRankNest.Text), Convert.ToInt32(textBoxAjouterRankInvasion.Text), textBoxAjouterLienImageCarte.Text, textBoxAjouterLogoCarte.Text);
                    
            }
        }

        private void buttonModifierPersonnage_Click(object sender, EventArgs e)
        {
            buttonValiderModification.Enabled = true;
            Personnage persoAmodifier = (Personnage)listBoxAdministrateurPersonnage.SelectedItem;

            //textBoxAjouterNomPersonnage.Text = persoAmodifier.getNomCarte();
            //textBoxAjouterCouleur.Text = persoAmodifier.getCouleur();
            //textBoxAjouterEcole.Text = persoAmodifier.getEcole();
            //textBoxAjouterType.Text = persoAmodifier.getType();

            //textBoxAjouterPtdLeader.Text = persoAmodifier.getAptLeader();
            //textBoxAjouterPassif.Text = persoAmodifier.getAptPassif();
            //textBoxAjouterNinja.Text = persoAmodifier.getNinpo();
            //textBoxAjouterNinjaSecret.Text = persoAmodifier.getSninpo();

            //textBoxAjouterForcePhy.Text = Convert.ToString(persoAmodifier.getForcePhy());
            //textBoxAjouterPuissanceOff.Text = Convert.ToString(persoAmodifier.getPuissanceOff());
            //textBoxAjouterDefense.Text = Convert.ToString(persoAmodifier.getDefense());
            //textBoxAjouterAgilite.Text = Convert.ToString(persoAmodifier.getAgilite());

            //textBoxAjouterRankInvasion.Text = Convert.ToString(persoAmodifier.getInvasionRating());
            //textBoxAjouterRankNest.Text = Convert.ToString(persoAmodifier.getNestRating());
            //textBoxAjouterRankPVP.Text = Convert.ToString(persoAmodifier.getPvpRating());

            //textBoxAjouterLienImageCarte.Text = persoAmodifier.getLienImageCarte();
            //textBoxAjouterLogoCarte.Text = persoAmodifier.getLienImageLogo();
        }

        private void Administrateur_Load(object sender, EventArgs e)
        {
            buttonValiderModification.Enabled = false;
        }

        private void buttonValiderModification_Click(object sender, EventArgs e)
        {
            //Personnage persoCree = new Personnage(Convert.ToInt32(null), textBoxAjouterNomPersonnage.Text, textBoxAjouterEcole.Text, Convert.ToInt32(textBoxAjouterForcePhy.Text), Convert.ToInt32(textBoxAjouterPuissanceOff.Text), Convert.ToInt32(textBoxAjouterDefense.Text), Convert.ToInt32(textBoxAjouterAgilite.Text), textBoxAjouterPtdLeader.Text, textBoxAjouterPassif.Text, textBoxAjouterNinja.Text, textBoxAjouterNinjaSecret.Text, textBoxAjouterCouleur.Text, textBoxAjouterType.Text, Convert.ToInt32(textBoxAjouterRankPVP.Text), Convert.ToInt32(textBoxAjouterRankNest.Text), Convert.ToInt32(textBoxAjouterRankInvasion.Text), textBoxAjouterLienImageCarte.Text, textBoxAjouterLogoCarte.Text);

        }
    }
}
