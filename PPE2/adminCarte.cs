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
    public partial class adminCarte : Form
    {
        bool aEteModifier;
        public adminCarte()
        {
            InitializeComponent();
        }

        private void adminCarte_Load(object sender, EventArgs e)
        {
            
            aEteModifier = false;
            listBoxCarte.Items.AddRange(Connection.getTouteLesCartes().ToArray());

            //Partie modifier/supprimer

            listBoxModifNomEcole.Items.AddRange(Connection.getNomEcole().ToArray());
            listBoxModifPersonnage.Items.AddRange(Connection.getPersonnage().ToArray());
            listBoxModifAptLeader.Items.AddRange(Connection.getToutLesleaders().ToArray());

            //Partie ajouter

            listBoxAjouterNomEcole.Items.AddRange(Connection.getNomEcole().ToArray());
            listBoxAjouterPersonnage.Items.AddRange(Connection.getPersonnage().ToArray());
            listBoxAjouterAptLeader.Items.AddRange(Connection.getToutLesleaders().ToArray());


        }


        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (listBoxCarte.SelectedItem is null)
            {
                MessageBox.Show("Aucune carte séléctionner", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Carte carteRecup = (Carte)listBoxCarte.SelectedItem;
                if (Connection.supprimerCarte(carteRecup.getNoCarte()))
                {
                    aEteModifier = true;
                    listBoxCarte.Items.Remove(carteRecup);
                    //listBoxPersonnage.Items.Remove(persoRecup);
                    //listBoxPersonnage.Items.Clear();
                    //listBoxPersonnage.Items.AddRange(Connection.getPersonnage().ToArray());
                }
                else
                {
                    MessageBox.Show("La supression n'a pas réussi", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listBoxCarte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aEteModifier)
            {
                MessageBox.Show("La modification est un succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                aEteModifier = false;

                textBoxModifNoCarte.Text = "";
                textBoxModifNomCarte.Text = "";
                textBoxModifCouleur.Text = "";
                richTextBoxModifEffetPassif.Text = "";
                textBoxModifPuissanceOffensive.Text = "";
                textBoxModifForcePhysique.Text = "";
                textBoxModifDefense.Text = "";
                textBoxModifVitesse.Text = "";
                textBoxModifNinpo.Text = "";
                richTextBoxModifSninpo.Text = "";
                richTextBoxModifCarteComplete.Text = "";
                richTextBoxModifLogo.Text = "";
                richTextBoxModifDescription.Text = "";

                //textBoxNomPersonnageModif.Text = "";
                //textBoxAgeModif.Text = "";
                //textBoxTailleModif.Text = "";
                //textBoxLogoChibiModif.Text = "";
            }
            else
            {
                Carte carteRecup = (Carte)listBoxCarte.SelectedItem;
                textBoxModifNoCarte.Text = Convert.ToString(carteRecup.getNoCarte());
                textBoxModifNomCarte.Text = carteRecup.getNomCarte();
                textBoxModifCouleur.Text = carteRecup.getCouleur();
                richTextBoxModifEffetPassif.Text = carteRecup.getPassif();
                textBoxModifPuissanceOffensive.Text = Convert.ToString(carteRecup.getPuissanceOff());
                textBoxModifForcePhysique.Text = Convert.ToString(carteRecup.getForcePhy());
                textBoxModifDefense.Text = Convert.ToString(carteRecup.getDefense());
                textBoxModifVitesse.Text = Convert.ToString(carteRecup.getAgilite());
                textBoxModifNinpo.Text = carteRecup.getNinpo();
                richTextBoxModifSninpo.Text = carteRecup.getSninpo();
                richTextBoxModifCarteComplete.Text = carteRecup.getCarteComplete();
                richTextBoxModifLogo.Text = carteRecup.getLogo();
                richTextBoxModifDescription.Text = carteRecup.getDescription();
                //Personnage persoRecup = (Personnage)listBoxPersonnage.SelectedItem;

                //textBoxNomPersonnageModif.Text = persoRecup.getNomPersonnage();
                //textBoxAgeModif.Text = Convert.ToString(persoRecup.getAge());
                //textBoxLogoChibiModif.Text = persoRecup.getLogoChibi();
                //textBoxTailleModif.Text = Convert.ToString(persoRecup.getTaille());

            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if(listBoxAjouterPersonnage.SelectedItem is null)
            {
                MessageBox.Show("Aucun personnage séléctionner", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(listBoxAjouterNomEcole.SelectedItem is null)
            {
                MessageBox.Show("Aucune école séléctionner", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(listBoxAjouterType.SelectedItem is null)
            {
                MessageBox.Show("Aucun type", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(listBoxAjouterAptLeader.SelectedItem is null)
            {
                MessageBox.Show("Aucune apt leader séléctionner", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nomEcole = (string)listBoxAjouterNomEcole.SelectedItem;
                Personnage persoRecup = (Personnage)listBoxAjouterPersonnage.SelectedItem;
                string personnage = persoRecup.getNomPersonnage(); 
                string aptLeader = (string)listBoxAjouterAptLeader.SelectedItem;
                string nomCarte = textBoxAjouterNomCarte.Text;
                string couleur = textBoxAjouterCouleur.Text;
                
                string type = (string)listBoxAjouterType.SelectedItem;
                string passif = richTextBoxAjouterPassif.Text;
                int forcePhy = Convert.ToInt32(textBoxAjouterForcePhysique.Text);
                int puissanceOff = Convert.ToInt32(textBoxAjouterPuissanceOff.Text);
                int defense = Convert.ToInt32(textBoxAjouterDefense.Text);
                int vitesse = Convert.ToInt32(textBoxAjouterVitesse.Text);
                string ninpo = textBoxAjouterNinpo.Text;
                string sninpo = richTextBoxAjouterSninpo.Text;
                string logo = richTextBoxAjouterLogo.Text;
                string carteComplete = richTextBoxAjouterCarteComplete.Text;
                string description = richTextBoxAjouterDescription.Text;

                if(Connection.addCarte(nomEcole,personnage,aptLeader,nomCarte,couleur,type,passif,forcePhy,puissanceOff,defense,vitesse,ninpo,sninpo,logo,carteComplete,description))
                {
                    listBoxCarte.Items.Clear();
                    listBoxCarte.Items.AddRange(Connection.getTouteLesCartes().ToArray());
                }

            }

        }

        private void buttonModifValider_Click(object sender, EventArgs e)
        {
            int noCarte = Convert.ToInt32(textBoxModifNoCarte.Text);
            string nomCarte = textBoxModifNomCarte.Text;
            Personnage persoRecup = (Personnage)listBoxModifPersonnage.SelectedItem;
            string aptLeader = (string)listBoxModifAptLeader.SelectedItem;
            string couleur = textBoxModifCouleur.Text;
            string type = (string)listBoxType.SelectedItem;
            string passif = richTextBoxModifEffetPassif.Text;
            int puissanceOff = Convert.ToInt32(textBoxModifPuissanceOffensive.Text);
            int forcePhy = Convert.ToInt32(textBoxModifForcePhysique.Text);
            int defense = Convert.ToInt32(textBoxModifDefense.Text);
            int vitesse = Convert.ToInt32(textBoxModifVitesse.Text);
            string ninpo = textBoxModifNinpo.Text;
            string sninpo = richTextBoxModifSninpo.Text;
            string carteComplete = richTextBoxModifCarteComplete.Text;
            string logo = richTextBoxModifLogo.Text;
            string description = richTextBoxModifDescription.Text;
            Carte carteRecup = (Carte)listBoxCarte.SelectedItem;

            MessageBox.Show((string)listBoxModifNomEcole.SelectedItem);

            if(Connection.alterCarte(noCarte,(string)listBoxModifNomEcole.SelectedItem, persoRecup.getNomPersonnage(), aptLeader, nomCarte, couleur, type, passif, forcePhy, puissanceOff, defense, vitesse, ninpo, sninpo, logo, carteComplete, description, carteRecup.getNoCarte()))
            {
                aEteModifier = true;
                listBoxCarte.Items.Clear();
                listBoxCarte.Items.AddRange(Connection.getTouteLesCartes().ToArray());
            }
            else
            {
                MessageBox.Show("La modif n'a pas fonctionnée");
            }

        }
    }
}
