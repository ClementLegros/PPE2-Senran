using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PPE2
{
    class Connection
    {
        private static MySqlConnection conn = null;

        //Connection à la base de données

        public static bool connexion()
        {
            string sConnexion = @"server=localhost;userid=root;password=root;database=PPE2Senran";
            conn = new MySqlConnection(sConnexion);
            conn.Open();
            return (conn.State == System.Data.ConnectionState.Open);
        }

        //Test si l'utilisateur est présent dans la BDD
        public static int testerConnection(string login, string mdp)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "SELECT COUNT(*) FROM USER WHERE LOGIN = '"+ login +"' AND PASSWORD = '"+ mdp +"'";
            cmd.CommandText = reqI;
            int c = Convert.ToInt32(cmd.ExecuteScalar());
            return c;
        }
        
        //On récupère le type de Jouer savoir si c'est un simple joueur ou un admin
        public static string getTypeUser(string login)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "SELECT TYPE_USER FROM USER WHERE LOGIN = '"+login+"'";
            cmd.CommandText = reqI;
            string typeUser = (string)cmd.ExecuteScalar();
            return typeUser;
        }


        //Ajoute un personnage dans la collection de l'utilisateur
        public static int ajouterPersonnageToUser(Personnage p, int idUser)
        {
            int numeroCarte = p.getNumeroCarte();
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "INSERT INTO Collection(NO_JOUEUR,NO_CARTE) WHERE NO_JOUEUR ='" + idUser + "' AND NO_CARTE = '" + numeroCarte + "'";
            return 0;
        }

        //Récupère toute les Cartes du jeux sans exception
        public static List<Personnage> getToutLesPersonnages()
        {
            List<Personnage> listPersonnage = new List<Personnage>();
            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "SELECT * FROM getcartecomplete";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                //Personnage personnageRecup = new Personnage((int)rdr["NO_CARTE"], (string)rdr["NOM_CARTE"], (string)rdr["NOM_ECOLE"], (string)rdr["EFFET_LEADER"], (string)rdr["EFFET_PASSIF"], (string)rdr["COULEUR"], (string)rdr["TYPE"], (int)rdr["PVP_RATING"], (int)rdr["NEST_RATING"], (int)rdr["INVASION_RATING"]);
                //listPersonnage.Add(personnageRecup);
            }
            rdr.Close();
            return listPersonnage;
        }

        public static List<Carte> getCarteRecent()
        {
            List<Carte> listeCarte = new List<Carte>();
            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "SELECT * FROM CARTE";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Carte carteRecup = new Carte((int)rdr["NO_CARTE"], (string)rdr["Logo"]);
                listeCarte.Add(carteRecup);
            }
            rdr.Close();
            return listeCarte;

        }

        public static List<Carte> getPersonnageDeUser(string idUser)
        {
            List<Carte> listeCarte = new List<Carte>();
            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "CALL GetPersoDeUser('" + idUser + "')";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Carte carteRecup = new Carte((int)rdr["NO_CARTE"], (string)rdr["LOGO"]);
                listeCarte.Add(carteRecup);
            }
            rdr.Close();
            return listeCarte;

        }


        //Ajout d'utilisateur à la bdd
        public static bool ajouterUser(string user, string mdp)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "INSERT INTO JOUEUR VALUES('" + 4 + "','" + user + "','" + mdp + "')";
            cmd.CommandText = reqI;
            int nbMaj = cmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        //Récupérer la liste des personnages en fonction des ordres de tri
        public static List<Personnage> getListPersoForTeam(string cdType1, string cdCouleur1, string cdType2, string cdCouleur2, string modeDeJeux)
        {
            List<Personnage> listPerso = new List<Personnage>();

            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "CALL GetTriCarte('" + cdType1 + "', '" + cdCouleur1 + "', '" + modeDeJeux + "', '" + cdType2 + "', '" + cdCouleur2 + "')";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                //Personnage personnageRecup = new Personnage((int)rdr["NO_CARTE"],
                                                            //(string)rdr["NOM_CARTE"],
                                                            //(string)rdr["LienLogoImage"]);

                //listPerso.Add(personnageRecup);

            }

            rdr.NextResult();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    //Personnage personnageRecup = new Personnage((int)rdr["NO_CARTE"],
                                                            //(string)rdr["NOM_CARTE"],
                                                            //(string)rdr["LienLogoImage"]);
                    //listPerso.Add(personnageRecup);

                }
            }
            rdr.Close();
            return listPerso;
        }

        public static bool ajouterPersonnage(Personnage p)
        {
            string getEcole = p.getEcole();

            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "INSERT INTO CARTE VALUES(" + null + " ,'" + p.getNomCarte() + "',')";
            cmd.CommandText = reqI;
            int nbMaj = cmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        public static List<Personnage> getPersonnageRecherche(string couleur, string type, string ecole)
        {
            List<Personnage> listPersonnageRecherche = new List<Personnage>();
            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "CALL GetPersoRecherche('" + couleur + "','" + type + "','" + ecole + "')";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                //Personnage personnageRecup = new Personnage((int)rdr["NO_CARTE"], (string)rdr["NOM_CARTE"], (string)rdr["NOM_ECOLE"], (int)rdr["Force_Physique"], (int)rdr["Puissance_Offensive"], (int)rdr["Defense"], (int)rdr["Agilite"], (string)rdr["EFFET_LEADER"], (string)rdr["EFFET_PASSIF"], (string)rdr["Ninja"], (string)rdr["Secret"], (string)rdr["COULEUR"], (string)rdr["TYPE"], (int)rdr["PVP_RATING"], (int)rdr["NEST_RATING"], (int)rdr["INVASION_RATING"], (string)rdr["LienCarteImage"], (string)rdr["LienLogoImage"]);
                //listPersonnageRecherche.Add(personnageRecup);
            }
            rdr.Close();
            return listPersonnageRecherche;

        }

    }
    
    
}
