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
    public partial class AccueilUser : Form
    {
        List<Personnage> listPersonnageBDD;
        collection collectionDeUser;
        public int idUser;

        public AccueilUser()
        {
            InitializeComponent();
            Connection.connexion();
        }

        private void AccueilUser_Load(object sender, EventArgs e)
        {
            collectionDeUser = new collection(Connection.getPersonnageDeUser(idUser), idUser);
            listPersonnageBDD = Connection.getToutLesPersonnages();

            
            
            listBoxPersoPossedeParUser.Items.AddRange(collectionDeUser.getListCollectionPersonnage().ToArray());
            listBoxPersoBDD.Items.AddRange(listPersonnageBDD.ToArray());
        }


        private void btRecherchePerso_Click(object sender, EventArgs e)
        {
            string nomPersonnage = textBoxRecherchePersonnage.Text;
            List<Personnage> listPerso = new List<Personnage>();

            if (checkBoxVotreCollection.Checked)
            {
                //Rechercher dans la collection du joueur
                foreach(Personnage p in collectionDeUser.getListCollectionPersonnage())
                {
                    if(p.getNomCarte() == nomPersonnage)
                    {
                        listPerso.Add(p);
                    }
                }

                listBoxPersoPossedeParUser.Items.Clear();
                listBoxPersoPossedeParUser.Items.AddRange(listPerso.ToArray());
            }
            if(checkBoxDansLaBDD.Checked)
            {
                //Rechercher dans la base de données
                foreach(Personnage p in listPersonnageBDD)
                {
                    if(p.getNomCarte() == nomPersonnage)
                    {
                        listPerso.Add(p);
                    }
                }

                listBoxPersoBDD.Items.Clear();
                listBoxPersoBDD.Items.AddRange(listPerso.ToArray());
            }
        }

        private void btMenuPersonnage_Click(object sender, EventArgs e)
        {

        }

        private void btAjouterPersoToUserCollection_Click(object sender, EventArgs e)
        {
            Personnage perso = (Personnage)listBoxPersoBDD.SelectedItem;
            Connection.ajouterPersonnageToUser(perso, idUser);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btAutoTeam_Click(object sender, EventArgs e)
        {
            string conditionPrincipalType = (string)listBoxConditionPrincipaleType.SelectedItem;
            string conditionPrincipaleCouleur = (string)listBoxConditionPrincipaleCouleur.SelectedItem;

            string conditionSecondaireType = (string)listBoxConditionSecondaireType.SelectedItem;
            string conditionSecondaireCouleur = (string)listBoxConditionSecondaireCouleur.SelectedItem;
            
            List<Personnage> listPersoResult = Connection.getListPersoForTeam(conditionPrincipalType, conditionSecondaireCouleur, conditionSecondaireType, conditionSecondaireCouleur, "PVP_RATING");
            pictureBox0LogoCarte.Load(listPersoResult[0].getLienImageLogo());
            pictureBox1LogoCarte.Load(listPersoResult[1].getLienImageLogo());
            pictureBox2LogoCarte.Load(listPersoResult[2].getLienImageLogo());
            pictureBox3LogoCarte.Load(listPersoResult[3].getLienImageLogo());
            pictureBox4LogoCarte.Load(listPersoResult[4].getLienImageLogo());






        }

        private void buttonValiderDetailPersonnage_Click(object sender, EventArgs e)
        {
            Personnage persoRecup = (Personnage)listBoxPersoBDD.SelectedItem;
            if(checkBoxDetailCarteBDD.Checked == true && checkBoxDetailPersoBox.Checked == false)
            {
                DetailCarte d1 = new DetailCarte();
                d1.nom = persoRecup.getNomCarte();
                d1.ecole = persoRecup.getEcole();
                d1.aptLeader = persoRecup.getAptLeader();
                d1.aptPassif = persoRecup.getAptPassif();
                d1.couleur = persoRecup.getCouleur();
                d1.type = persoRecup.getType();
                d1.invasionRating = persoRecup.getInvasionRating();
                d1.pvpRating = persoRecup.getPvpRating();
                d1.nestRating = persoRecup.getNestRating();
                d1.ShowDialog();

            }
            else
            {
                MessageBox.Show("Les critères ont mal été remplis ");
            }
        }
    }
}
