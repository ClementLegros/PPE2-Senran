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
    public partial class ResultatRecherche : Form
    {
        List<Personnage> listPerso;
        public ResultatRecherche()
        {
            InitializeComponent();
        }

        private void ResultatRecherche_Load(object sender, EventArgs e)
        {
            listPerso = new List<Personnage>();

            int premiereLigne = 64;
            int deuxiemeLigne = 112;
            int troisiemeLigne = 115;
            int quatriemeLigne = 193;
            int ligneLabel = 28;

            for (int i = 0; i < listPerso.Count; i++)
            {
                PictureBox picture = new PictureBox
                {
                    Name = "pictureBoxImgLogo"+Convert.ToString(i),
                    Location = new Point(13,premiereLigne),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = listPerso[i].getNumeroCarte(),
                    ImageLocation = listPerso[i].getLienImageLogo(),
                    Size = new Size(100,75)
                };

                Label lbNomCarteText = new Label
                {
                    Text = "Nom:",
                    Name = "LabelNomCarteText" + Convert.ToString(i),
                    Location = new Point(128,premiereLigne)
                };

                Label lbNomCarte = new Label
                {
                    Text = listPerso[i].getNomCarte(),
                    Name = "LabelNomCarte" + Convert.ToString(i),
                    Location = new Point(181,premiereLigne)
                };

                Label AptitudeLeaderText = new Label
                {
                    Text = "Aptitude Leader:",
                    Name = "LabelAptitudeLeaderText" + Convert.ToString(i),
                    Location = new Point(303,premiereLigne)
                };

                Label AptitudeLeader = new Label
                {
                    Text = listPerso[i].getAptLeader(),
                    Name = "AptitudeLeader" + Convert.ToString(i),
                    Location = new Point(427,premiereLigne)
                };

                Label EcoleText = new Label
                {
                    Text = "Ecole:",
                    Name = "LabelEcoleText" + Convert.ToString(i),
                    Location = new Point(128, deuxiemeLigne)
                };

                Label Ecole = new Label
                {
                    Text = listPerso[i].getEcole(),
                    Name = "EcoleText" + Convert.ToString(i),
                    Location = new Point(181, deuxiemeLigne)
                };

                Label AptitudePassifText = new Label
                {
                    Text = "Aptitude Passif:",
                    Name = "AptitudePassifText" + Convert.ToString(i),
                    Location = new Point(303, deuxiemeLigne)
                };

                Label AptitudePassif = new Label
                {
                    Text = listPerso[i].getAptPassif(),
                    Name = "AptitudePassif" + Convert.ToString(i),
                    Location = new Point(427, deuxiemeLigne)
                };

                Label ForcePhysiqueText = new Label
                {
                    Text = "Force Physique:",
                    Name = "ForcePhysiqueText" + Convert.ToString(i),
                    Location = new Point(10, troisiemeLigne)
                };
                Label ForcePhysique = new Label
                {
                    Text = Convert.ToString(listPerso[i].getForcePhy()),
                    Name = "ForcePhysique" + Convert.ToString(i),
                    Location = new Point(172, troisiemeLigne)
                };

                Label DefenseText = new Label
                {
                    Text = "Defense:",
                    Name = "DefenseText" + Convert.ToString(i),
                    Location = new Point(271, troisiemeLigne)
                };

                Label Defense = new Label
                {
                    Text = Convert.ToString(listPerso[i].getDefense()),
                    Name = "Defense" + Convert.ToString(i),
                    Location = new Point(364, troisiemeLigne)
                };

                Label NinpoText = new Label
                {
                    Text = "Ninpo:",
                    Name = "NinpoText" + Convert.ToString(i),
                    Location = new Point(452, troisiemeLigne)
                };

                Label Ninpo = new Label
                {
                    Text = listPerso[i].getNinpo(),
                    Name = "NinpoText" + Convert.ToString(i),
                    Location = new Point(531, troisiemeLigne)
                };

                Label PuissanceOffensiveText = new Label
                {
                    Text = "Puissance Offensive:",
                    Name = "PuissanceOffensiveText" + Convert.ToString(i),
                    Location = new Point(10, quatriemeLigne)
                };

                Label PuissanceOffensive = new Label
                {
                    Text = Convert.ToString(listPerso[i].getForceOff()),
                    Name = "PuissanceOffensive" + Convert.ToString(i),
                    Location = new Point(172, quatriemeLigne)
                };

                Label VitesseText = new Label
                {
                    Text = "Vitesse:",
                    Name = "VitesseText" + Convert.ToString(i),
                    Location = new Point(271, quatriemeLigne)
                };

                Label Vitesse = new Label
                {
                    Text = Convert.ToString(listPerso[i].getAgilite()),
                    Name = "Vitesse" + Convert.ToString(i),
                    Location = new Point(364, quatriemeLigne)
                };

                Label SninpoText = new Label
                {
                    Text = "Sninpo:",
                    Name = "SninpoText" + Convert.ToString(i),
                    Location = new Point(452, quatriemeLigne)
                };

                Label Sninpo = new Label
                {
                    Text = listPerso[i].getSninpo(),
                    Name = "Sninpo" + Convert.ToString(i),
                    Location = new Point(531, quatriemeLigne)
                };

                Label trait = new Label
                {
                    Text = "-------------------------------------------------",
                    Name = "---" + Convert.ToString(i),
                    Location = new Point(8, ligneLabel)
                };

                premiereLigne = premiereLigne + 357;
                deuxiemeLigne = deuxiemeLigne + 357;
                troisiemeLigne = troisiemeLigne + 357;
                quatriemeLigne = quatriemeLigne + 357;
                ligneLabel = ligneLabel + 357;


            }
            
        }
    }
}
