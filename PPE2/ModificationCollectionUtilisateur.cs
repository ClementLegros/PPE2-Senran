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
            if(operation == "AJOUTER")
            {
                listBoxAjouterPersonnage.Items.Clear();
                listBoxAjouterPersonnage.Items.AddRange(Connection.getCarteNonPossederParUser(noUser).ToArray());
            }
            
        }

        private void listBoxAjouterPersonnage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(aEteModifier)
            {
                MessageBox.Show("La modification à bien réussi");
                aEteModifier = false;
            }
            else
            {
                if(operation == "AJOUTER")
                {
                    Carte carteRecup = (Carte)listBoxAjouterPersonnage.SelectedItem;
                    this.pictureBoxCarte.Load(carteRecup.getLogo());
                    this.labelNomCarte.Text = carteRecup.ToString();
                    this.pictureBoxCarte.Visible = true;
                    this.labelNomCarte.Visible = true;
                    this.buttonAjouterCarteToUser.Visible = true;
                }
                
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
                    MessageBox.Show("L'ajout n'a pas marché");
                }
            }

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            PersonnageDeUser pdu = new PersonnageDeUser();
            pdu.noUser = this.noUser;
            this.Hide();
            pdu.Show();
        }

        
    }
}
