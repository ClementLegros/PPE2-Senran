using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE2
{
    class collection
    {
        private List<Personnage> listCollectionPersonnage;
        private int idUser;

        public collection(List<Personnage> listCollectionPersonnage, int idUser)
        {
            this.listCollectionPersonnage = listCollectionPersonnage;
            this.idUser = idUser;
        }

        public List<Personnage> getListCollectionPersonnage()
        {
            return listCollectionPersonnage;
        }

        public int getIdUser()
        {
            return idUser;
        }

        public void ajouterListCollectionUser(List<Personnage> listCollectionPersonnage)
        {
            this.listCollectionPersonnage = listCollectionPersonnage;
        }

        public void ajoutIdUser(int idUser)
        {
            this.idUser = idUser;
        }
    }
}
