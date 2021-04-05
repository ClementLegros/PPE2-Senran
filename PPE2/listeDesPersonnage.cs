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
    public partial class listeDesPersonnage : Form
    {
        public listeDesPersonnage()
        {
            InitializeComponent();
        }

        private void listeDesPersonnage_Load(object sender, EventArgs e)
        {
            afficherLesCartes();
            
        }

        private void afficherLesCartes()
        {
            //int fin = 10;
           
            //for (int i = 0; i < fin; i++)
            //{
            //    PictureBox imageControl = new PictureBox();
            //    imageControl.Height = 50;
            //    imageControl.Width = 50;
            //    int pointX = 20;
            //    int pointY = 20;
            //    if ((i % 3) == 0)
            //    {
            //        if(i == 0)
            //        {
            //            imageControl.Location = new Point(pointX, 20);
            //        }
            //        else
            //        {
            //            pointX = pointX + (200 * i);
            //            imageControl.Location = new Point(pointX, 20);
            //        }
                    
                    
                    
            //    }
            //    else
            //    {
            //        imageControl.Location = new Point(pointX, 20 + (200*i));
            //    }
                
                
            //    imageControl.Load("https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse2.mm.bing.net%2Fth%3Fid%3DOIP.vaePzxVVbDrnNzQ83IVukgHaEK%26pid%3DApi&f=1");
  
            //    Controls.Add(imageControl);
            
            
        }
    }
}
