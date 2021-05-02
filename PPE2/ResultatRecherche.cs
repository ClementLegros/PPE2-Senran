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
        List<Carte> listeCarte;
        public string couleur;
        public string type;
        public string ecole;
        public ResultatRecherche()
        {
            InitializeComponent();
        }

        private void ResultatRecherche_Load(object sender, EventArgs e)
        {
            listeCarte = Connection.getPersonnageRecherche(couleur, type, ecole);

            int premiereLigne = 64;
            int deuxiemeLigne = 125;
            int troisiemeLigne = 220;
            int quatriemeLigne = 330;
            int cinquiemeLigne = 450;
            int ligneLabel = 525;

            for (int i = 0; i < listeCarte.Count; i++)
            {
                PictureBox picture = new PictureBox
                {
                    Name = "pictureBoxImgLogo"+Convert.ToString(i),
                    Location = new Point(13,premiereLigne),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = i,
                    ImageLocation = listeCarte[i].getLogo(),
                    Size = new Size(100,75)
                };
                picture.MouseClick += new MouseEventHandler(picture_Click);

                Label lbNomCarteText = new Label
                {
                    Text = "Nom:",
                    Name = "LabelNomCarteText" + Convert.ToString(i),
                    Location = new Point(128,premiereLigne),
                    Size = new Size(45, 15)
                };

                Label lbNomCarte = new Label
                {
                    Text = listeCarte[i].ToString(),
                    Name = "LabelNomCarte" + Convert.ToString(i),
                    Location = new Point(170,premiereLigne),
                    Size = new Size(175, 15)
                };

                Label AptitudeLeaderText = new Label
                {
                    Text = "Aptitude Leader:",
                    Name = "LabelAptitudeLeaderText" + Convert.ToString(i),
                    Location = new Point(350,premiereLigne),
                    Size = new Size(116, 15)
                };

                Label AptitudeLeader = new Label
                {
                    Text = listeCarte[i].getLeader(),
                    Name = "AptitudeLeader" + Convert.ToString(i),
                    Location = new Point(477, premiereLigne),
                    Size = new Size(250, 60)

                };

                

                //Label NestRating = new Label
                //{
                //    Text = "Nest Rating:" + Convert.ToString(listPerso[i].getNestRating()),
                //    Name = "NestRating" + Convert.ToString(i),
                //    Location = new Point(750, premiereLigne),
                //    Size = new Size(100, 15)
                //};

                //Label InvasionRating = new Label
                //{
                //    Text = "Invasion Rating:" + Convert.ToString(listPerso[i].getInvasionRating()),
                //    Name = "InvasionRating" + Convert.ToString(i),
                //    Location = new Point(880, premiereLigne),
                //    Size = new Size(180, 15)
                //};

                //Label PvpRating = new Label
                //{
                //    Text = "PVP Rating:" + Convert.ToString(listPerso[i].getPvpRating()),
                //    Name = "PvpRating" + Convert.ToString(i),
                //    Location = new Point(750, deuxiemeLigne),
                //    Size = new Size(100, 15)
                //};

                Label EcoleText = new Label
                {
                    Text = "Ecole:",
                    Name = "LabelEcoleText" + Convert.ToString(i),
                    Location = new Point(128, deuxiemeLigne),
                    Size = new Size(70, 15)
                };

                MessageBox.Show(listeCarte[i].getEcole());
                Label Ecole = new Label
                {
                    Text = ecole,
                    Name = "EcoleText" + Convert.ToString(i),
                    Location = new Point(198, deuxiemeLigne),
                    Size = new Size(100, 15)
                };

                Label AptitudePassifText = new Label
                {
                    Text = "Aptitude Passif:",
                    Name = "AptitudePassifText" + Convert.ToString(i),
                    Location = new Point(350, deuxiemeLigne),
                    Size = new Size(125, 15)
                };

                Label AptitudePassif = new Label
                {
                    Text = listeCarte[i].getPassif(),
                    Name = "AptitudePassif" + Convert.ToString(i),
                    Location = new Point(477, deuxiemeLigne),
                    Size = new Size(250, 130)
                };

                Label ForcePhysiqueText = new Label
                {
                    Text = "Force Physique:",
                    Name = "ForcePhysiqueText" + Convert.ToString(i),
                    Location = new Point(10, troisiemeLigne),
                    Size = new Size(110, 15)
                };
                Label ForcePhysique = new Label
                {
                    Text = Convert.ToString(listeCarte[i].getForcePhy()),
                    Name = "ForcePhysique" + Convert.ToString(i),
                    Location = new Point(125, troisiemeLigne),
                    Size = new Size(40, 15)
                };

                Label DefenseText = new Label
                {
                    Text = "Defense:",
                    Name = "DefenseText" + Convert.ToString(i),
                    Location = new Point(271, troisiemeLigne),
                    Size = new Size(70, 15)
                };

                Label Defense = new Label
                {
                    Text = Convert.ToString(listeCarte[i].getDefense()),
                    Name = "Defense" + Convert.ToString(i),
                    Location = new Point(364, troisiemeLigne),
                    Size = new Size(70, 15)
                };

                Label PuissanceOffensiveText = new Label
                {
                    Text = "Puissance Offensive:",
                    Name = "PuissanceOffensiveText" + Convert.ToString(i),
                    Location = new Point(10, quatriemeLigne),
                    Size = new Size(140, 15)
                };

                Label PuissanceOffensive = new Label
                {
                    Text = Convert.ToString(listeCarte[i].getPuissanceOff()),
                    Name = "PuissanceOffensive" + Convert.ToString(i),
                    Location = new Point(172, quatriemeLigne),
                    Size = new Size(40, 15)
                };

                Label VitesseText = new Label
                {
                    Text = "Vitesse:",
                    Name = "VitesseText" + Convert.ToString(i),
                    Location = new Point(271, quatriemeLigne),
                    Size = new Size(70, 15)
                };

                Label Vitesse = new Label
                {
                    Text = Convert.ToString(listeCarte[i].getAgilite()),
                    Name = "Vitesse" + Convert.ToString(i),
                    Location = new Point(364, quatriemeLigne),
                    Size = new Size(70, 15)
                };

                Label NinpoText = new Label
                {
                    Text = "Ninpo:",
                    Name = "NinpoText" + Convert.ToString(i),
                    Location = new Point(10, cinquiemeLigne),
                    Size = new Size(53, 15)
                };

                Label Ninpo = new Label
                {
                    Text = listeCarte[i].getNinpo(),
                    Name = "NinpoText" + Convert.ToString(i),
                    Location = new Point(150, cinquiemeLigne),
                    Size = new Size(170, 70)
                };



                Label SninpoText = new Label
                {
                    Text = "Sninpo:",
                    Name = "SninpoText" + Convert.ToString(i),
                    Location = new Point(452, cinquiemeLigne),
                    Size = new Size(70, 15)
                };

                Label Sninpo = new Label
                {
                    Text = listeCarte[i].getSninpo(),
                    Name = "Sninpo" + Convert.ToString(i),
                    Location = new Point(531, cinquiemeLigne),
                    Size = new Size(170, 70)
                };

                Label trait = new Label
                {
                    Text = "-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                    Name = "---" + Convert.ToString(i),
                    Location = new Point(8, ligneLabel),
                    Size = new Size(650, 15)
                };

                this.Controls.Add(picture);
                this.Controls.Add(lbNomCarteText);
                this.Controls.Add(lbNomCarte);
                this.Controls.Add(AptitudeLeaderText);
                this.Controls.Add(AptitudeLeader);
                this.Controls.Add(AptitudePassifText);
                this.Controls.Add(AptitudePassif);
                this.Controls.Add(EcoleText);
                this.Controls.Add(Ecole);
                this.Controls.Add(ForcePhysiqueText);
                this.Controls.Add(ForcePhysique);
                this.Controls.Add(PuissanceOffensiveText);
                this.Controls.Add(PuissanceOffensive);
                this.Controls.Add(DefenseText);
                this.Controls.Add(Defense);
                this.Controls.Add(VitesseText);
                this.Controls.Add(Vitesse);
                //this.Controls.Add(NestRating);
                //this.Controls.Add(InvasionRating);
                //this.Controls.Add(PvpRating);
                this.Controls.Add(NinpoText);
                this.Controls.Add(Ninpo);
                this.Controls.Add(SninpoText);
                this.Controls.Add(Sninpo);
                this.Controls.Add(trait);

                premiereLigne = premiereLigne + 500;
                deuxiemeLigne = deuxiemeLigne + 500;
                troisiemeLigne = troisiemeLigne + 500;
                quatriemeLigne = quatriemeLigne + 500;
                cinquiemeLigne = cinquiemeLigne + 500;
                ligneLabel = ligneLabel + 500;


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
    }
}
