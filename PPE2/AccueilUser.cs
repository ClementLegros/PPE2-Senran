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

            pictureBoxPersonnage.ImageLocation = "https://i.imgur.com/uPQzOvo.png";
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
            
        }
    }
}
