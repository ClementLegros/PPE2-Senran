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
        public string idUser;

        public AccueilUser()
        {
            InitializeComponent();
            Connection.connexion();
        }

        private void AccueilUser_Load(object sender, EventArgs e)
        {
            List<Carte> listeCarte = Connection.getCarteRecent();
            pictureBoxDernierPersoSorti1.Load(listeCarte[0].getLogo());
            //pictureBoxDernierPersoSorti2.Load(personnageRecent[1].getLienImageLogo());
            //pictureBoxDernierPersoSorti3.Load(personnageRecent[2].getLienImageLogo());
            //pictureBoxDernierPersoSorti4.Load(personnageRecent[3].getLienImageLogo());
            //pictureBoxDernierPersoSorti5.Load(personnageRecent[4].getLienImageLogo());
            //pictureBoxDernierPersoSorti6.Load(personnageRecent[5].getLienImageLogo());
        }


        

        private void btMenuPersonnage_Click(object sender, EventArgs e)
        {
            CarteDeUser pdu = new CarteDeUser();
            pdu.noUser = idUser;
            pdu.Show();
        }

        private void btAjouterPersoToUserCollection_Click(object sender, EventArgs e)
        {
            Personnage perso = (Personnage)listBoxPersoBDD.SelectedItem;
            //Connection.ajouterPersonnageToUser(perso, idUser);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btAutoTeam_Click(object sender, EventArgs e)
        {
            //string conditionPrincipalType = (string)listBoxConditionPrincipaleType.SelectedItem;
            //string conditionPrincipaleCouleur = (string)listBoxConditionPrincipaleCouleur.SelectedItem;

            //string conditionSecondaireType = (string)listBoxConditionSecondaireType.SelectedItem;
            //string conditionSecondaireCouleur = (string)listBoxConditionSecondaireCouleur.SelectedItem;
            
            //List<Personnage> listPersoResult = Connection.getListPersoForTeam(conditionPrincipalType, conditionSecondaireCouleur, conditionSecondaireType, conditionSecondaireCouleur, "PVP_RATING");
            //if (listPersoResult.Count == 4)
            //{
            //    pictureBox0LogoCarte.Load(listPersoResult[0].getLienImageLogo());
            //    pictureBox1LogoCarte.Load(listPersoResult[1].getLienImageLogo());
            //    pictureBox2LogoCarte.Load(listPersoResult[2].getLienImageLogo());
            //    pictureBox3LogoCarte.Load(listPersoResult[3].getLienImageLogo());
            //    //pictureBox4LogoCarte.Load(listPersoResult[4].getLienImageLogo());
            //}
            //else
            //{
            //    MessageBox.Show("Vous n'avez pas assez de personnage pour faire une composition d'équipe ");
            //}

            ////Faire un message d'alerte pour savoir si l'utilisateur veut enregistrer son équipe
            






        }

        private void buttonValiderDetailPersonnage_Click(object sender, EventArgs e)
        {
            //Personnage persoRecup = (Personnage)listBoxPersoBDD.SelectedItem;
            //if(checkBoxDetailCarteBDD.Checked == true && checkBoxDetailPersoBox.Checked == false)
            //{
            //    DetailCarte d1 = new DetailCarte();
            //    d1.nom = persoRecup.getNomCarte();
            //    d1.ecole = persoRecup.getEcole();
            //    d1.aptLeader = persoRecup.getAptLeader();
            //    d1.aptPassif = persoRecup.getAptPassif();
            //    d1.couleur = persoRecup.getCouleur();
            //    d1.type = persoRecup.getType();
            //    d1.invasionRating = persoRecup.getInvasionRating();
            //    d1.pvpRating = persoRecup.getPvpRating();
            //    d1.nestRating = persoRecup.getNestRating();
            //    d1.ShowDialog();

            //}
            //else
            //{
            //    MessageBox.Show("Les critères ont mal été remplis ");
            //}
        }

        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            recherchePersonnage rp = new recherchePersonnage();
            rp.Show();
        }

        private void btMenuEquip_Click(object sender, EventArgs e)
        {
            Equipe ep = new Equipe();
            ep.idUser = this.idUser;
            ep.Show();
        }

        private void buttonPersonnage_Click(object sender, EventArgs e)
        {
            PersonnageInfo pi = new PersonnageInfo();
            pi.Show();
        }
    }
}
