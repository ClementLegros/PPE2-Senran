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
        public static bool ajouterPersonnageToUser(Carte c, string noUser)
        {
            
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "CALL addCarteToCollection('"+ c.getNoCarte() +"','"+ noUser+"')";
            cmd.CommandText = reqI;
            int nbMaj = cmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        public static bool deleteCarteToUser(Carte c, string noUser)
        {

            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "CALL deletePersoDeUser('" + noUser + "','" + c.getNoCarte() + "')";
            cmd.CommandText = reqI;
            int nbMaj = cmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        public static List<Carte> getCarteNonPossederParUser(string idUser)
        {
            List<Carte> listeCarte = new List<Carte>();
            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "CALL getPersoNonPossedeParUser('" + idUser + "')";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Carte carteRecup = new Carte((int)rdr["NO_CARTE"], (string)rdr["LOGO"], (string)rdr["NOM_PERSONNAGE"], (string)rdr["NOM_CARTE"]);
                listeCarte.Add(carteRecup);
            }
            rdr.Close();
            return listeCarte;
        }

        public static List<string> getNomEcole()
        {
            List<string> listDesEcoles = new List<string>();
            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "SELECT NOM_ECOLE FROM ECOLE";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                listDesEcoles.Add((string)rdr["NOM_ECOLE"]);
            }
            rdr.Close();
            return listDesEcoles;
        }

        public static bool alterPersonnage(string basicNomPersonnage, string nomPersonnage, string nomEcole, int taille, int age, string chibiLogo)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "CALL alterPersonnage('" + nomPersonnage + "','" + nomEcole + "','"+ taille+"','"+ age +"','"+ chibiLogo +"','"+ basicNomPersonnage +"')";
            cmd.CommandText = reqI;
            int nbMaj = cmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        public static bool alterCarte(int noCarte, string nomEcole, string nomPersonnage, string aptLeader, string nomCarte, string couleur, string type, string passif, int forcePhy, int puissanceOff, int def, int agilite, string ninpo, string sninpo, string logo, string carteComplete, string description, int noCarteBase)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "CALL alterCarte('"+ noCarte +"','" + nomEcole + "','" + nomPersonnage + "','" + aptLeader + "','" + nomCarte + "','" + couleur + "','" + type + "','" + passif + "','" + forcePhy + "','" + puissanceOff + "','" + def + "','" + agilite + "','" + ninpo + "','" + sninpo + "','" + logo + "','" + carteComplete + "','" + description + "';'"+noCarteBase+"')";
            cmd.CommandText = reqI;
            int nbMaj = cmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        public static bool addPersonnage(string nomPersonnage, string nomEcole, int taille, int age, string chibiLogo)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "CALL addPersonnage('" + nomPersonnage + "','" + nomEcole + "','" + taille + "','" + age + "','" + chibiLogo + "')";
            cmd.CommandText = reqI;
            int nbMaj = cmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        public static bool addCarte(string nomEcole, string nomPersonnage, string aptLeader, string nomCarte, string couleur, string type, string passif, int forcePhy, int puissanceOff, int def, int agilite, string ninpo, string sninpo, string logo, string carteComplete, string description)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "CALL addCarte('" + nomEcole + "','" + nomPersonnage + "','" + aptLeader + "','" + nomCarte + "','" + couleur + "','" + type + "','" + passif + "','" + forcePhy + "','" + puissanceOff + "','" + def + "','" + agilite + "','" + ninpo + "','" + sninpo + "','" + logo + "','" + carteComplete + "','" + description + "')";
            cmd.CommandText = reqI;
            int nbMaj = cmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        public static bool supprimerPersonnage(string nomPersonnage)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "CALL deletePersonnage('" + nomPersonnage + "')";
            cmd.CommandText = reqI;
            int nbMaj = cmd.ExecuteNonQuery();
            return (nbMaj == 1);

        }

        public static bool supprimerCarte(int noCarte)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "CALL deleteCarte('" + noCarte + "')";
            cmd.CommandText = reqI;
            int nbMaj = cmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        public static List<Personnage> getPersonnage()
        {
            List<Personnage> listePersonnage = new List<Personnage>();
            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "CALL getToutLesPersonnages()";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Personnage persoRecup = new Personnage((string)rdr["NOM_PERSONNAGE"], (string)rdr["NOM_ECOLE"], (int)rdr["TAILLE"], (int)rdr["AGE"],(string)rdr["LOGO_CHIBI"]);
                listePersonnage.Add(persoRecup);
            }
            rdr.Close();
            return listePersonnage;
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
                Carte carteRecup = new Carte((int)rdr["NO_CARTE"], (string)rdr["LOGO"], (string)rdr["NOM_PERSONNAGE"], (string)rdr["NOM_CARTE"]);
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
        public static List<Carte> getListCarteForTeam(string cdType1, string cdCouleur1, string cdType2, string cdCouleur2, string modeDeJeux)
        {
            List<Carte> listCarte = new List<Carte>();

            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "CALL GetTriCarte('" + cdType1 + "', '" + cdCouleur1 + "', '" + modeDeJeux + "', '" + cdType2 + "', '" + cdCouleur2 + "')";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Carte carteRecup = new Carte((int)rdr["NO_CARTE"], (string)rdr["LOGO"], (string)rdr["NOM_PERSONNAGE"], (string)rdr["NOM_CARTE"]);
                listCarte.Add(carteRecup);
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
                    Carte carteRecup = new Carte((int)rdr["NO_CARTE"], (string)rdr["LOGO"], (string)rdr["NOM_PERSONNAGE"], (string)rdr["NOM_CARTE"]);
                    listCarte.Add(carteRecup);
                    //Personnage personnageRecup = new Personnage((int)rdr["NO_CARTE"],
                    //(string)rdr["NOM_CARTE"],
                    //(string)rdr["LienLogoImage"]);
                    //listPerso.Add(personnageRecup);

                }
            }
            rdr.Close();
            return listCarte;
        }

        public static List<Carte>getTouteLesCartes()
        {
            List<Carte> listeCarte = new List<Carte>();
            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "SELECT * FROM CARTE";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Carte carteRecup = new Carte((int)rdr["NO_CARTE"], (string)rdr["NOM_PERSONNAGE"], (string)rdr["NOM_CARTE"], (string)rdr["NOM_ECOLE"], (int)rdr["FORCE_PHYSIQUE"], (int)rdr["PUISSANCE_OFFENSIVE"], (int)rdr["DEFENSE"], (int)rdr["AGILITE"], (string)rdr["APT_LEADER"], (string)rdr["EFFET_PASSIF"], (string)rdr["NINPO"], (string)rdr["SNINPO"], (string)rdr["COULEUR"], (string)rdr["TYPE"], (string)rdr["CARTE_COMPLETE"], (string)rdr["LOGO"], (string)rdr["DESCRIPTION"]);
                listeCarte.Add(carteRecup);
                //Personnage personnageRecup = new Personnage((int)rdr["NO_CARTE"], (string)rdr["NOM_CARTE"], (string)rdr["NOM_ECOLE"], (int)rdr["Force_Physique"], (int)rdr["Puissance_Offensive"], (int)rdr["Defense"], (int)rdr["Agilite"], (string)rdr["EFFET_LEADER"], (string)rdr["EFFET_PASSIF"], (string)rdr["Ninja"], (string)rdr["Secret"], (string)rdr["COULEUR"], (string)rdr["TYPE"], (int)rdr["PVP_RATING"], (int)rdr["NEST_RATING"], (int)rdr["INVASION_RATING"], (string)rdr["LienCarteImage"], (string)rdr["LienLogoImage"]);
                //listPersonnageRecherche.Add(personnageRecup);
            }
            rdr.Close();
            return listeCarte;
        }

        public static List<Carte> getPersonnageRecherche(string couleur, string type, string ecole)
        {
            List<Carte> listeCarte = new List<Carte>();
            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "CALL GetPersoRecherche('" + couleur + "','" + type + "','" + ecole + "')";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Carte carteRecup = new Carte((int)rdr["NO_CARTE"], (string)rdr["NOM_PERSONNAGE"], (string)rdr["NOM_CARTE"], (string)rdr["NOM_ECOLE"], (int)rdr["FORCE_PHYSIQUE"], (int)rdr["PUISSANCE_OFFENSIVE"], (int)rdr["DEFENSE"], (int)rdr["AGILITE"], (string)rdr["APT_LEADER"], (string)rdr["EFFET_PASSIF"] ,(string)rdr["NINPO"], (string)rdr["SNINPO"], (string)rdr["COULEUR"], (string)rdr["TYPE"],(string)rdr["CARTE_COMPLETE"], (string)rdr["LOGO"], (string)rdr["DESCRIPTION"]);
                listeCarte.Add(carteRecup);
                //Personnage personnageRecup = new Personnage((int)rdr["NO_CARTE"], (string)rdr["NOM_CARTE"], (string)rdr["NOM_ECOLE"], (int)rdr["Force_Physique"], (int)rdr["Puissance_Offensive"], (int)rdr["Defense"], (int)rdr["Agilite"], (string)rdr["EFFET_LEADER"], (string)rdr["EFFET_PASSIF"], (string)rdr["Ninja"], (string)rdr["Secret"], (string)rdr["COULEUR"], (string)rdr["TYPE"], (int)rdr["PVP_RATING"], (int)rdr["NEST_RATING"], (int)rdr["INVASION_RATING"], (string)rdr["LienCarteImage"], (string)rdr["LienLogoImage"]);
                //listPersonnageRecherche.Add(personnageRecup);
            }
            rdr.Close();
            return listeCarte;

        }

        public static List<string> getToutLesleaders()
        {
            List<string> listLeaders = new List<string>();
            MySqlCommand cmd = conn.CreateCommand();
            String reqI = "SELECT * FROM APT_LEADER";
            cmd.CommandText = reqI;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                listLeaders.Add((string)rdr["APT_LEADER"]);
            }
            rdr.Close();
            return listLeaders;

        }

    }
    
    
}
