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
    public partial class Accueil : Form
    {
       
        public Accueil()
        {
            InitializeComponent();
            Connection.connexion();
        }

        private void btInscription_Click(object sender, EventArgs e)
        {
            string user = textBoxInscriptionUser.Text;
            string mdp = textBoxInscriptionMDP.Text;
            string mdpConfirm = textBoxInscriptionValiderMDP.Text;

            if(mdp == "" && mdpConfirm== "")
            {
                MessageBox.Show("Vos champs mots de passe sont vide");
            }

            if(mdp == mdpConfirm && mdp != "" && mdpConfirm != "")
            {
                //Inscription à la base de données      
                Connection.ajouterUser(user, mdp);
                MessageBox.Show("L'enregistrement à été éféctuer avec succès");
            }
            else if(mdp != "" && mdpConfirm != "")
            {
                MessageBox.Show("Vos 2 mots de passes ne correspondent pas");
            }
                
        }

        private void btValiderConnection_Click(object sender, EventArgs e)
        {
            string user = textBoxConnectionUser.Text;
            string mdp = textBoxConnectionMDP.Text;
            if (Connection.testerConnection(user, mdp) == 1)
            {
                if(Connection.getTypeUser(user) == "UTILISATEUR" )
                {
                    AccueilUser ac = new AccueilUser();
                    ac.idUser = user;
                    ac.Show();
                    this.Hide();
                }
                else
                {
                    AccueilAdmin aad = new AccueilAdmin();
                    aad.Show();
                    this.Hide();

                }
                
            }

            else
            {
                MessageBox.Show("La connection n'a pas été aboutit");
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }
    }
}
