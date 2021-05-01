using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE2
{
    public partial class PersonnageDeUser : Form
    {
        public string noUser;
        List<Carte> listeCarte;
        



        public PersonnageDeUser()
        {
            InitializeComponent();
        }

        private void PersonnageDeUser_Load(object sender, EventArgs e)
        {
            listeCarte = Connection.getPersonnageDeUser(noUser);
            
            int c = listeCarte.Count;
            int horizontal = 16;
            int vertical = 95;
            int sautMoins = 106;
            for (int i = 0; i < c; i++)
            {

                if(i%5 == 0)
                {
                    sautMoins = 106;
                    horizontal = 16;
                    vertical = vertical + 81;
                }
                string nomPicture = "pictureBoxPersonnage" + Convert.ToString(i);
                PictureBox picture = new PictureBox
                {
                    Name = nomPicture,
                    Size = new Size(100, 75),
                    Location = new Point(horizontal, vertical),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = i,
                    ImageLocation = listeCarte[i].getLogo()

                };
                picture.MouseClick += new MouseEventHandler(picture_Click);
                this.Controls.Add(picture);
                if(c != 0)
                {
                    horizontal = horizontal + 106;
                }
                sautMoins = 0;
            }
        }

        void picture_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            int index = Convert.ToInt32(pb.Tag);
            Carte carteRecup = listeCarte[index];
            DetailsCarte dc = new DetailsCarte();
            dc.imgCarte = carteRecup.getLogo();
            dc.Show();
        }

        private void buttonAjouterPerso_Click(object sender, EventArgs e)
        {

        }
    }
}
