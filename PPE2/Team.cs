using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE2
{
    class Team
    {
        private string nomEquipe;
        private List<Carte> listCarte;
        private string modeDeJeux;

        public Team(string nomEquipe, List<Carte> listCarte, string modeDeJeux)
        {
            this.nomEquipe = nomEquipe;
            this.listCarte = listCarte;
            this.modeDeJeux = modeDeJeux;
        }

        public string getNomEquipe()
        {
            return nomEquipe;
        }

        public List<Carte> getListCarte()
        {
            return listCarte;
        }
        public string getModeDeJeux()
        {
            return modeDeJeux;
        }

        public override string ToString()
        {
            return nomEquipe;
        }
    }
}
