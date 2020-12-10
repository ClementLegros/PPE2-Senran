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
            string sConnexion = @"server=localhost;userid=root;password=root;database=senran";
            conn = new MySqlConnection(sConnexion);
            conn.Open();
            return (conn.State == System.Data.ConnectionState.Open);
        }

        //Test si l'utilisateur est présent dans la BDD
        public static int testerConnection(string user, string mdp)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "SELECT COUNT(*) FROM JOUEUR WHERE USER = '"+ user +"' AND PASSWORD = '"+ mdp +"'";
            cmd.CommandText = reqI;
            int c = Convert.ToInt32(cmd.ExecuteScalar());
            return c;
        }

        public static bool ajouterUser(string user , string mdp)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string reqI = "INSERT INTO JOUEUR VALUES('" + 3 + "','" + user + "','" + mdp + "')";
            cmd.CommandText = reqI;
            int nbMaj = cmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }
    }

    
}
