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
        public static int testerConnection(string user, string mdp)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "SELECT COUNT(*) FROM UTILISATEUR WHERE USER = '"+ user +"' AND PASSWORD = '"+ mdp +"'";
            cmd.CommandText = reqI;
            int c = Convert.ToInt32(cmd.ExecuteScalar());
            return c;
        }
        
        public static int getIdUser(string user, string mdp)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "SELECT NO_UTILISATEUR FROM UTILISATEUR WHERE USER = '" + user + "' AND PASSWORD = '" + mdp + "'";
            cmd.CommandText = reqI;
            int noId = Convert.ToInt32(cmd.ExecuteScalar());
            return noId;   
        }

        //Ajoute un personnage dans la collection de l'utilisateur
        public static int ajouterPersonnageToUser(Personnage p, int idUser)
        {
            int numeroCarte = p.getNumeroCarte();
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "INSERT INTO Collection(NO_JOUEUR,NO_CARTE) WHERE NO_JOUEUR ='" + idUser + "' AND NO_CARTE = '" + numeroCarte + "'";
           
            return 0;
        }

        //Récupère toute les Cartes du jeux sans exception (tant qu'elle sont complète)
        public static List<Personnage> getToutLesPersonnages()
        {
            List<Personnage> listPersonnage = new List<Personnage>();
            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "SELECT * FROM getcartecomplete";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Personnage personnageRecup = new Personnage((int)rdr["NO_CARTE"],(string)rdr["NOM_CARTE"],(string)rdr["NOM_ECOLE"],(string)rdr["EFFET_LEADER"],(string)rdr["EFFET_PASSIF"],(string)rdr["COULEUR"],(string)rdr["TYPE"],(int)rdr["PVP_RATING"],(int)rdr["NEST_RATING"],(int)rdr["INVASION_RATING"]);
                listPersonnage.Add(personnageRecup);
            }
            rdr.Close();
            return listPersonnage;

        }

        public static List<Personnage> getPersonnageDeUser(int idUser)
        {
            List<Personnage> listPersonnageDeUser = new List<Personnage>();
            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "CALL GetPersoDeUser('"+idUser+"')";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Personnage personnageRecup = new Personnage((int)rdr["NO_CARTE"], (string)rdr["NOM_CARTE"], (string)rdr["NOM_ECOLE"], (string)rdr["EFFET_LEADER"], (string)rdr["EFFET_PASSIF"], (string)rdr["COULEUR"], (string)rdr["TYPE"], (int)rdr["PVP_RATING"], (int)rdr["NEST_RATING"], (int)rdr["INVASION_RATING"]);
                listPersonnageDeUser.Add(personnageRecup);
            }
            rdr.Close();
            return listPersonnageDeUser;

        }


        //Ajout d'utilisateur à la bdd
        public static bool ajouterUser(string user , string mdp)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "INSERT INTO JOUEUR VALUES('" + 4 + "','" + user + "','" + mdp + "')";
            cmd.CommandText = reqI;
            int nbMaj = cmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        //Récupérer la liste des personnages en fonction des ordres de tri
        public static List<Personnage> getListPersoForTeam(string cdType1, string cdCouleur1, string cdType2,string cdCouleur2, string modeDeJeux)
        {
            List<Personnage> listPerso = new List<Personnage>();

            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "CALL GetTriCarte('"+ cdType1 +"', '"+cdCouleur1+"', '"+modeDeJeux+"', '"+cdType2+"', '"+cdCouleur2+"')";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Personnage personnageRecup = new Personnage((int)rdr["NO_CARTE"],
                                                            (string)rdr["NOM_CARTE"],
                                                            (string)rdr["LienLogoImage"]);
                                                            
                listPerso.Add(personnageRecup);
                
            }
            
            rdr.NextResult();
            if(rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Personnage personnageRecup = new Personnage((int)rdr["NO_CARTE"],
                                                            (string)rdr["NOM_CARTE"],
                                                            (string)rdr["LienLogoImage"]);
                    listPerso.Add(personnageRecup);

                }
            }
            rdr.Close();
            return listPerso;
        }
        
    }
    
    
}
