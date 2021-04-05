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
        public int noUser;
        

        public PersonnageDeUser()
        {
            InitializeComponent();
        }

        private void PersonnageDeUser_Load(object sender, EventArgs e)
        {
            List<Personnage> listPerso = Connection.getPersonnageDeUser(noUser);
            
            int c = listPerso.Count;
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
                PictureBox picture = new PictureBox
                {
                    Name = "pictureBoxPersonnage" + Convert.ToString(i),
                    Size = new Size(100, 75),
                    Location = new Point(horizontal , vertical),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = listPerso[i].getLienImageLogo()
                };
                this.Controls.Add(picture);
                if(c != 0)
                {
                    horizontal = horizontal + 106;
                }
                sautMoins = 0;
            }
        }
    }
}
