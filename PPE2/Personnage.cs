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
        private int noCarte;
        private string nomPersonnage;
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
        private string urlImageCarte;
        private string urlImageLogo;
        private string descriptif;

        //On utilise se constructeur quand on veux un descriptif complet de la carte
        public Personnage(int noCarte, string nomPersonnage, string nomCarte, string ecole, int forcePhy, int puissanceOff, int defense, int agilite, string aptLeader, string aptPassif, string ninpo, string sninpo, string couleur, string type, int pvpRating, int nestRating, int invasionRating, string urlImageCarte, string urlImageLogo, string descriptif)
        {
            this.noCarte = noCarte;
            this.nomPersonnage = nomPersonnage;
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
            this.pvpRating = pvpRating;
            this.nestRating = nestRating;
            this.invasionRating = invasionRating;
            this.urlImageCarte = urlImageCarte;
            this.urlImageLogo = urlImageLogo;
            this.descriptif = descriptif;
        }

        //On utilise se constructeur pour afficher rapidements des cartes
        public Personnage(int noCarte, string urlImageLogo)
        {
            this.noCarte = noCarte;
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

        public void setNomPersonnage(string nomPersonnage)
        {
            this.nomCarte = nomPersonnage;
        }

        public void setAptLeader(string aptLeader)
        {
            this.aptLeader = aptLeader;
        }

        public void setAptPassif(string aptPassif)
        {
            this.aptPassif = aptPassif;
        }

        public void setCouleur(string couleur)
        {
            this.couleur = couleur;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public void setEcole(string ecole)
        {
            this.ecole = ecole;
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

        public string getNinpo()
        {
            return ninpo;
        }

        public string getSninpo()
        {
            return sninpo;
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
    }
}
