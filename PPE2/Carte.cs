using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE2
{
    class Carte
    {
        private int noCarte;
        private string personnage;
        private string nomCarte;
        private string ecole;
        private int forcePhy;
        private int puissanceOff;
        private int defense;
        private int agilite;
        private string aptLeader;
        private string aptPassif;
        private string ninpo;
        private string sninpo;
        private string couleur;
        private string type;
        private int pvpRating;
        private int nestRating;
        private int invasionRating;
        private string carteComplete;
        private string logo;
        private string descriptif;

        public Carte(int noCarte, string personnage, string nomCarte, string ecole, int forcePhy, int puissanceOff, int defense, int agilite, string aptLeader, string aptPassif, string ninpo, string sninpo, string couleur, string type, string carteComplete, string logo, string descriptif)
        {
            this.noCarte = noCarte;
            this.personnage = personnage;
            this.nomCarte = nomCarte;
            this.ecole = ecole;
            this.forcePhy = forcePhy;
            this.puissanceOff = puissanceOff;
            this.defense = defense;
            this.agilite = agilite;
            this.aptLeader = aptLeader;
            this.aptPassif = aptPassif;
            this.ninpo = ninpo;
            this.sninpo = sninpo;
            this.couleur = couleur;
            this.type = type;
            this.carteComplete = carteComplete;
            this.logo = logo;
            this.descriptif = descriptif;
        }

        public override string ToString()
        {
            return personnage + " " + nomCarte;
        }

        public Carte(int noCarte, string logo, string personnage, string nomCarte)
        {
            this.noCarte = noCarte;
            this.logo = logo;
            this.personnage = personnage;
            this.nomCarte = nomCarte;
        }


        public Carte(int noCarte, string logo)
        {
            this.noCarte = noCarte;
            this.logo = logo;
        }


        //GET
        public  string getPersonnage()
        {
            return personnage;
        }

        public int getNoCarte()
        {
            return noCarte;
        }

        public string getEcole()
        {
            return ecole;
        }

        public string getNomCarte()
        {
            return nomCarte;
        }

        public string getCouleur()
        {
            return couleur;
        }

        public string getLeader()
        {
            return aptLeader;
        }

        public string getPassif()
        {
            return aptPassif;
        }

        public int getForcePhy()
        {
            return forcePhy;
        }

        public int getPuissanceOff()
        {
            return puissanceOff;
        }

        public int getDefense()
        {
            return defense;
        }

        public int getAgilite()
        {
            return agilite;
        }

        public string getNinpo()
        {
            return ninpo;
        }

        public string getSninpo()
        {
            return sninpo;
        }

        public string getCarteComplete()
        {
            return carteComplete;
        }

        public string getLogo()
        {
            return logo;
        }

        public string getDescription()
        {
            return descriptif;
        }

        //SET
        public void setPvpRating(int rating)
        {
            this.pvpRating = rating;
        }
    }


}
