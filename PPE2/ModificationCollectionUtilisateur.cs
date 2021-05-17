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
    public partial class ModificationCollectionUtilisateur : Form
    {
        public string noUser;
        public bool aEteModifier = false;
        public string operation;

        public ModificationCollectionUtilisateur()
        {
            InitializeComponent();
        }

        private void ModificationCollectionUtilisateur_Load(object sender, EventArgs e)
        {
            listBoxAjouterPersonnage.Items.Clear();

            if (operation == "AJOUTER")
            {
                listBoxAjouterPersonnage.Items.AddRange(Connection.getCarteNonPossederParUser(noUser).ToArray());
            }
            else if (operation == "SUPPRIMER")
            {
                listBoxAjouterPersonnage.Items.AddRange(Connection.getPersonnageDeUser(noUser).ToArray());
            }
            else
            {
                MessageBox.Show("An UFO as been detected", "Anomaly", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void listBoxAjouterPersonnage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(aEteModifier)
            {
                MessageBox.Show("La modification est un succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                aEteModifier = false;
            }
            else
            {
                Carte carteRecup = (Carte)listBoxAjouterPersonnage.SelectedItem;
                this.pictureBoxCarte.Load(carteRecup.getLogo());
                this.labelNomCarte.Text = carteRecup.ToString();
                this.pictureBoxCarte.Visible = true;
                this.labelNomCarte.Visible = true;
                this.buttonAjouterCarteToUser.Visible = true;             
            }
            
            
        }

        private void buttonAjouterCarteToUser_Click(object sender, EventArgs e)
        {
            Carte carteRecup = (Carte)listBoxAjouterPersonnage.SelectedItem;
            if (operation == "AJOUTER")
            {
                if (Connection.ajouterPersonnageToUser(carteRecup, noUser))
                {
                    this.pictureBoxCarte.Visible = false;
                    this.labelNomCarte.Visible = false;
                    this.buttonAjouterCarteToUser.Visible = false;
                    aEteModifier = true;
                    this.listBoxAjouterPersonnage.Items.Remove(carteRecup);
                }
                else
                {
                    MessageBox.Show("L'ajout n'a pas réussi", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if(Connection.deleteCarteToUser(carteRecup, noUser))
                {
                    this.pictureBoxCarte.Visible = false;
                    this.labelNomCarte.Visible = false;
                    this.buttonAjouterCarteToUser.Visible = false;
                    aEteModifier = true;
                    this.listBoxAjouterPersonnage.Items.Remove(carteRecup);
                }
                else
                {
                    MessageBox.Show("La supression n'a pas réussi", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            CarteDeUser pdu = new CarteDeUser();
            pdu.noUser = this.noUser;
            this.Hide();
            pdu.Show();
        }

        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxRecherchePersonnage_TextChanged(object sender, EventArgs e)
        {
            listBoxAjouterPersonnage.Items.Clear();
            bool found = false;

            if (operation == "AJOUTER")
            {
                
                foreach (Carte c in Connection.getCarteNonPossederParUser(noUser))
                {
                    if (textBoxRecherchePersonnage.Text == c.getPersonnage())
                    {
                        listBoxAjouterPersonnage.Items.Clear();
                        listBoxAjouterPersonnage.Items.Add(c);
                        found = true;
                    }
                    //else if (textBoxRecherchePersonnage.Text == c.ToString())
                    //{
                    //    listBoxAjouterPersonnage.Items.Clear();
                    //    listBoxAjouterPersonnage.Items.Add(c);
                    //    found = true;
                    //}
                    else
                    {
                        found = false;
                    }
                }
                if(found != true)
                {
                    listBoxAjouterPersonnage.Items.AddRange(Connection.getCarteNonPossederParUser(noUser).ToArray());
                }
            }
            else if (operation == "SUPPRIMER")
            {
                foreach (Carte c in Connection.getPersonnageDeUser(noUser))
                {
                    if(textBoxRecherchePersonnage.Text == c.getPersonnage())
                    {
                        listBoxAjouterPersonnage.Items.Clear();
                        listBoxAjouterPersonnage.Items.Add(c);
                        found = true;
                    }
                    //else if(textBoxRecherchePersonnage.Text == c.ToString())
                    //{
                    //    listBoxAjouterPersonnage.Items.Clear();
                    //    listBoxAjouterPersonnage.Items.Add(c);
                    //    found = true;
                    //}
                    else
                    {
                        found = false;
                    }
                }
                if(found != true)
                {
                    listBoxAjouterPersonnage.Items.AddRange(Connection.getPersonnageDeUser(noUser).ToArray());
                }
            }
        }
    }
}
