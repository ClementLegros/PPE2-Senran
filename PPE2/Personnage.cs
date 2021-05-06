using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE2
{
    class Personnage
    {
        private string nomPersonnage;
        private string ecole;
        private int taille;
        private int age;
        private string logoChibi;

        public Personnage(string nomPersonnage, string ecole, int taille, int age, string logoChibi)
        {
            this.nomPersonnage = nomPersonnage;
            this.ecole = ecole;
            this.taille = taille;
            this.age = age;
            this.logoChibi = logoChibi;
        }

        public override string ToString()
        {
            return nomPersonnage;
        }

        public string getNomPersonnage()
        {
            return nomPersonnage;
        }

        public string getEcole()
        {
            return ecole;
        }

        public int getTaille()
        {
            return taille;
        }

        public int getAge()
        {
            return age;
        }

        public string getLogoChibi()
        {
            return logoChibi;
        }
    }
}
