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
                //Connection à la base de données et test la connection à l'utilisateur !
            }
            else if(mdp != "" && mdpConfirm != "")
            {
                MessageBox.Show("Vos 2 mots de passes ne correspondent pas");
            }
                
        }
    }
}
