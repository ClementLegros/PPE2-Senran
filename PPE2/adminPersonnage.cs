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
    public partial class adminPersonnage : Form
    {
        bool aEteModifier;
        public adminPersonnage()
        {
            InitializeComponent();
        }

        private void adminPersonnage_Load(object sender, EventArgs e)
        {
            aEteModifier = false;
            listBoxPersonnage.Items.AddRange(Connection.getPersonnage().ToArray());
            listBoxEcoleModif.Items.AddRange(Connection.getNomEcole().ToArray());
            listBoxAjouterEcole.Items.AddRange(Connection.getNomEcole().ToArray());
        }

        private void listBoxPersonnage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aEteModifier)
            {
                MessageBox.Show("La modification est un succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                aEteModifier = false;

                textBoxNomPersonnageModif.Text = "";
                textBoxAgeModif.Text = "";
                textBoxTailleModif.Text = "";
                textBoxLogoChibiModif.Text = "";
            }
            else
            {
                Personnage persoRecup = (Personnage)listBoxPersonnage.SelectedItem;

                textBoxNomPersonnageModif.Text = persoRecup.getNomPersonnage();
                textBoxAgeModif.Text = Convert.ToString(persoRecup.getAge());
                textBoxLogoChibiModif.Text = persoRecup.getLogoChibi();
                textBoxTailleModif.Text = Convert.ToString(persoRecup.getTaille());

            }
        }

        private void buttonValiderModif_Click(object sender, EventArgs e)
        {
            if(listBoxEcoleModif.SelectedItem is null)
            {
                MessageBox.Show("Aucune école n'a été séléctionner", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Personnage perso = (Personnage)listBoxPersonnage.SelectedItem;
                string ecole = (string)listBoxEcoleModif.SelectedItem;
                if (Connection.alterPersonnage(perso.getNomPersonnage(), textBoxNomPersonnageModif.Text, ecole, Convert.ToInt32(textBoxTailleModif.Text), Convert.ToInt32(textBoxAgeModif.Text), textBoxLogoChibiModif.Text))
                {
                    aEteModifier = true;
                    listBoxPersonnage.Items.Remove(perso);
                    listBoxPersonnage.Items.Clear();
                    listBoxPersonnage.Items.AddRange(Connection.getPersonnage().ToArray());

                }
                else
                {
                    MessageBox.Show("pas fonctionner");
                }
            }
        }

        private void buttonSupprimerPersonnage_Click(object sender, EventArgs e)
        {
            if(listBoxPersonnage.SelectedItem is null)
            {
                MessageBox.Show("Aucun personnage séléctionner", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Personnage persoRecup = (Personnage)listBoxPersonnage.SelectedItem;
                if(Connection.supprimerPersonnage(persoRecup.getNomPersonnage()))
                {
                    aEteModifier = true;
                    listBoxPersonnage.Items.Remove(persoRecup);
                    listBoxPersonnage.Items.Clear();
                    listBoxPersonnage.Items.AddRange(Connection.getPersonnage().ToArray());
                }
                else
                {
                    MessageBox.Show("La supression n'a pas réussi, le personnage est peut être encore lié à une carte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAjouterPersonnage_Click(object sender, EventArgs e)
        {
            if(listBoxAjouterEcole.SelectedItem is null)
            {
                MessageBox.Show("Aucune école n'a été séléctionner", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nomPersonnage = textBoxAjouterNomPersonnage.Text;
                string nomEcole = (string)listBoxAjouterEcole.SelectedItem;
                int taille = Convert.ToInt32(textBoxAjouterTaille.Text);
                int age = Convert.ToInt32(textBoxAjouterAge.Text);
                string chibiLogo = textBoxAjouterLogoChibi.Text;

                if(Connection.addPersonnage(nomPersonnage,nomEcole,taille,age,chibiLogo))
                {
                    Personnage newPerso = new Personnage(nomPersonnage, nomEcole, taille, age, chibiLogo);
                    listBoxPersonnage.Items.Add(newPerso);
                    textBoxAjouterNomPersonnage.Text = "";
                    textBoxAjouterTaille.Text = "";
                    textBoxAjouterAge.Text = "";
                    textBoxAjouterLogoChibi.Text = "";
                }
                else
                {
                    MessageBox.Show("L'ajout n'a pas pu être réaliser", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
