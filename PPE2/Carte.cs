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
        private Personnage p;
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

        public Carte(int noCarte, Personnage p, string nomCarte, string ecole, int forcePhy, int puissanceOff, int defense, int agilite, string aptLeader, string aptPassif, string ninpo, string sninpo, string couleur, string type, int pvpRating, int nestRating, int invasionRating, string carteComplete, string logo, string descriptif)
        {
            this.noCarte = noCarte;
            this.p = p;
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
            this.carteComplete = carteComplete;
            this.logo = logo;
            this.descriptif = descriptif;
        }

        public Carte(int noCarte, string logo)
        {
            this.noCarte = noCarte;
            this.logo = logo;
        }

        public  string getNomCarteComplet()
        {
            return "";
        }

        public int getNoCarte()
        {
            return noCarte;
        }

        public string getLogo()
        {
            return logo;
        }
    }


}
