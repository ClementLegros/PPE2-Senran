using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE2
{
    class Personnage : IComparable
    {
        private int noCarte;
        private string nomCarte;
        private string ecole;
        private int forcePhy;
        private int forceOff;
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
        private string urlImageCarte;
        private string urlImageLogo;


   

        public Personnage(int noCarte,string nomCarte, string ecole, string aptLeader,string aptPassif,string couleur, string type,int pvpRating,int nestRating,int invasionRating)
        {
            this.noCarte = noCarte;
            this.nomCarte = nomCarte;
            this.ecole = ecole;
            this.aptLeader = aptLeader;
            this.aptPassif = aptPassif;
            this.couleur = couleur;
            this.type = type;
            this.pvpRating = pvpRating;
            this.nestRating = nestRating;
            this.invasionRating = invasionRating;
        }

        public Personnage(int noCarte, string nomCarte, string aptLeader, string aptPassif, string couleur, string type, int pvpRating, int nestRating, int invasionRating, string urlImageCarte, string urlImageLogo)
        {
            this.noCarte = noCarte;
            this.nomCarte = nomCarte;
            this.aptLeader = aptLeader;
            this.aptPassif = aptPassif;
            this.couleur = couleur;
            this.type = type;
            this.pvpRating = pvpRating;
            this.nestRating = nestRating;
            this.invasionRating = invasionRating;
            this.urlImageCarte = urlImageCarte;
            this.urlImageLogo = urlImageLogo;
        }

        public void ajouterUrlImageCarte(string urlCarte)
        {
            this.urlImageCarte = urlCarte;
        }

        public void ajouterUrlImageLogo(string urlLogo)
        {
            this.urlImageLogo = urlLogo;
        }

        public int getNumeroCarte()
        {
            return noCarte;
        }

        public string getNomCarte()
        {
            return nomCarte;   
        }

        public string getAptLeader()
        {
            return aptLeader;
        }

        public string getAptPassif()
        {
            return aptPassif;
        }

        public string getCouleur()
        {
            return couleur;
        }

        public int getInvasionRating()
        {
            return invasionRating;
        }

        public int getPvpRating()
        {
            return pvpRating;
        }

        public int getNestRating()
        {
            return nestRating;
        }

        public string getEcole()
        {
            return ecole;
        }

        public string getType()
        {
            return type;
        }

        public string getLienImageCarte()
        {
            return urlImageCarte;
        }

        public string getLienImageLogo()
        {
            return urlImageLogo;
        }


        public int compareTo(Personnage p)
        {
            return this.invasionRating.CompareTo(p.invasionRating);
        }

        public override string ToString()
        {   
            return nomCarte + " / " + couleur + " / " + aptLeader + " / " + ecole;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
