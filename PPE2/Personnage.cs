using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE2
{
    class Personnage
    {
        private string nomCarte;
        private string ecole;
        private string aptLeader;
        private string type;
        private List<String> listPassif;

        public Personnage(string nomCarte, string ecole, string aptLeader, string type)
        {
            this.nomCarte = nomCarte;
            this.ecole = ecole;
            this.aptLeader = aptLeader;
            this.type = type;
        }

        public void setPassif(List<String> passifs)
        {
            this.listPassif = passifs;
        }

        public string getNomCarte()
        {
            return nomCarte;   
        }

        public string getAptLeader()
        {
            return aptLeader;
        }

        public string getEcole()
        {
            return ecole;
        }

        public string getType()
        {
            return type;
        }

        public override string ToString()
        {   
            return nomCarte + " / " + type + " / " + aptLeader + " / " + ecole;
        }
    }
}
