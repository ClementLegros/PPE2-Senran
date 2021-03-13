
namespace PPE2
{
    partial class AccueilUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btMenuPersonnage = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.btMenuEquip = new System.Windows.Forms.Button();
            this.listBoxPersoBDD = new System.Windows.Forms.ListBox();
            this.textBoxRecherchePersonnage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRecherchePerso = new System.Windows.Forms.Button();
            this.checkBoxDansLaBDD = new System.Windows.Forms.CheckBox();
            this.checkBoxVotreCollection = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPersoPossedeParUser = new System.Windows.Forms.ListBox();
            this.btAjouterPersoToUserCollection = new System.Windows.Forms.Button();
            this.groupBoxDetailCarte = new System.Windows.Forms.GroupBox();
            this.buttonValiderDetailPersonnage = new System.Windows.Forms.Button();
            this.checkBoxDetailCarteBDD = new System.Windows.Forms.CheckBox();
            this.checkBoxDetailPersoBox = new System.Windows.Forms.CheckBox();
            this.checkBoxInvasion = new System.Windows.Forms.CheckBox();
            this.checkBoxNest = new System.Windows.Forms.CheckBox();
            this.checkBoxPvp = new System.Windows.Forms.CheckBox();
            this.pictureBox2LogoCarte = new System.Windows.Forms.PictureBox();
            this.btAutoTeam = new System.Windows.Forms.Button();
            this.listBoxEquipe = new System.Windows.Forms.ListBox();
            this.pictureBox1LogoCarte = new System.Windows.Forms.PictureBox();
            this.pictureBox0LogoCarte = new System.Windows.Forms.PictureBox();
            this.pictureBox3LogoCarte = new System.Windows.Forms.PictureBox();
            this.pictureBox4LogoCarte = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxConditionPrincipaleType = new System.Windows.Forms.ListBox();
            this.groupBoxEquipe = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxConditionSecondaireCouleur = new System.Windows.Forms.ListBox();
            this.listBoxConditionSecondaireType = new System.Windows.Forms.ListBox();
            this.listBoxConditionPrincipaleCouleur = new System.Windows.Forms.ListBox();
            this.buttonRetirerPersonnageUser = new System.Windows.Forms.Button();
            this.groupBoxMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxDetailCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2LogoCarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1LogoCarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0LogoCarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3LogoCarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4LogoCarte)).BeginInit();
            this.groupBoxEquipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btMenuPersonnage
            // 
            this.btMenuPersonnage.Location = new System.Drawing.Point(5, 29);
            this.btMenuPersonnage.Name = "btMenuPersonnage";
            this.btMenuPersonnage.Size = new System.Drawing.Size(75, 41);
            this.btMenuPersonnage.TabIndex = 0;
            this.btMenuPersonnage.Text = "Personnage";
            this.btMenuPersonnage.UseVisualStyleBackColor = true;
            this.btMenuPersonnage.Click += new System.EventHandler(this.btMenuPersonnage_Click);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.btMenuPersonnage);
            this.groupBoxMenu.Controls.Add(this.btMenuEquip);
            this.groupBoxMenu.Location = new System.Drawing.Point(1, 2);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(86, 468);
            this.groupBoxMenu.TabIndex = 2;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "MENU";
            // 
            // btMenuEquip
            // 
            this.btMenuEquip.Location = new System.Drawing.Point(5, 76);
            this.btMenuEquip.Name = "btMenuEquip";
            this.btMenuEquip.Size = new System.Drawing.Size(75, 35);
            this.btMenuEquip.TabIndex = 1;
            this.btMenuEquip.Text = "Equipe";
            this.btMenuEquip.UseVisualStyleBackColor = true;
            // 
            // listBoxPersoBDD
            // 
            this.listBoxPersoBDD.FormattingEnabled = true;
            this.listBoxPersoBDD.Location = new System.Drawing.Point(557, 12);
            this.listBoxPersoBDD.Name = "listBoxPersoBDD";
            this.listBoxPersoBDD.Size = new System.Drawing.Size(291, 147);
            this.listBoxPersoBDD.TabIndex = 3;
            // 
            // textBoxRecherchePersonnage
            // 
            this.textBoxRecherchePersonnage.Location = new System.Drawing.Point(122, 34);
            this.textBoxRecherchePersonnage.Name = "textBoxRecherchePersonnage";
            this.textBoxRecherchePersonnage.Size = new System.Drawing.Size(100, 20);
            this.textBoxRecherchePersonnage.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRecherchePerso);
            this.groupBox1.Controls.Add(this.checkBoxDansLaBDD);
            this.groupBox1.Controls.Add(this.checkBoxVotreCollection);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxRecherchePersonnage);
            this.groupBox1.Location = new System.Drawing.Point(103, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 79);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher un personnage";
            // 
            // btRecherchePerso
            // 
            this.btRecherchePerso.Location = new System.Drawing.Point(664, 37);
            this.btRecherchePerso.Name = "btRecherchePerso";
            this.btRecherchePerso.Size = new System.Drawing.Size(75, 23);
            this.btRecherchePerso.TabIndex = 9;
            this.btRecherchePerso.Text = "Recherche";
            this.btRecherchePerso.UseVisualStyleBackColor = true;
            this.btRecherchePerso.Click += new System.EventHandler(this.btRecherchePerso_Click);
            // 
            // checkBoxDansLaBDD
            // 
            this.checkBoxDansLaBDD.AutoSize = true;
            this.checkBoxDansLaBDD.Location = new System.Drawing.Point(559, 38);
            this.checkBoxDansLaBDD.Name = "checkBoxDansLaBDD";
            this.checkBoxDansLaBDD.Size = new System.Drawing.Size(105, 17);
            this.checkBoxDansLaBDD.TabIndex = 8;
            this.checkBoxDansLaBDD.Text = "Dans tout le jeux";
            this.checkBoxDansLaBDD.UseVisualStyleBackColor = true;
            // 
            // checkBoxVotreCollection
            // 
            this.checkBoxVotreCollection.AutoSize = true;
            this.checkBoxVotreCollection.Location = new System.Drawing.Point(454, 37);
            this.checkBoxVotreCollection.Name = "checkBoxVotreCollection";
            this.checkBoxVotreCollection.Size = new System.Drawing.Size(99, 17);
            this.checkBoxVotreCollection.TabIndex = 7;
            this.checkBoxVotreCollection.Text = "Votre collection";
            this.checkBoxVotreCollection.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ou souhaitez vous chercher un personnage :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom du Personnage :";
            // 
            // listBoxPersoPossedeParUser
            // 
            this.listBoxPersoPossedeParUser.FormattingEnabled = true;
            this.listBoxPersoPossedeParUser.Location = new System.Drawing.Point(103, 12);
            this.listBoxPersoPossedeParUser.Name = "listBoxPersoPossedeParUser";
            this.listBoxPersoPossedeParUser.Size = new System.Drawing.Size(341, 147);
            this.listBoxPersoPossedeParUser.TabIndex = 6;
            // 
            // btAjouterPersoToUserCollection
            // 
            this.btAjouterPersoToUserCollection.Location = new System.Drawing.Point(557, 165);
            this.btAjouterPersoToUserCollection.Name = "btAjouterPersoToUserCollection";
            this.btAjouterPersoToUserCollection.Size = new System.Drawing.Size(291, 68);
            this.btAjouterPersoToUserCollection.TabIndex = 7;
            this.btAjouterPersoToUserCollection.Text = "Ajouter un personnage à votre collection";
            this.btAjouterPersoToUserCollection.UseVisualStyleBackColor = true;
            this.btAjouterPersoToUserCollection.Click += new System.EventHandler(this.btAjouterPersoToUserCollection_Click);
            // 
            // groupBoxDetailCarte
            // 
            this.groupBoxDetailCarte.Controls.Add(this.buttonValiderDetailPersonnage);
            this.groupBoxDetailCarte.Controls.Add(this.checkBoxDetailCarteBDD);
            this.groupBoxDetailCarte.Controls.Add(this.checkBoxDetailPersoBox);
            this.groupBoxDetailCarte.Location = new System.Drawing.Point(103, 244);
            this.groupBoxDetailCarte.Name = "groupBoxDetailCarte";
            this.groupBoxDetailCarte.Size = new System.Drawing.Size(341, 115);
            this.groupBoxDetailCarte.TabIndex = 14;
            this.groupBoxDetailCarte.TabStop = false;
            this.groupBoxDetailCarte.Text = "Détail Carte";
            // 
            // buttonValiderDetailPersonnage
            // 
            this.buttonValiderDetailPersonnage.Location = new System.Drawing.Point(6, 79);
            this.buttonValiderDetailPersonnage.Name = "buttonValiderDetailPersonnage";
            this.buttonValiderDetailPersonnage.Size = new System.Drawing.Size(75, 23);
            this.buttonValiderDetailPersonnage.TabIndex = 2;
            this.buttonValiderDetailPersonnage.Text = "Valider";
            this.buttonValiderDetailPersonnage.UseVisualStyleBackColor = true;
            this.buttonValiderDetailPersonnage.Click += new System.EventHandler(this.buttonValiderDetailPersonnage_Click);
            // 
            // checkBoxDetailCarteBDD
            // 
            this.checkBoxDetailCarteBDD.AutoSize = true;
            this.checkBoxDetailCarteBDD.Location = new System.Drawing.Point(112, 42);
            this.checkBoxDetailCarteBDD.Name = "checkBoxDetailCarteBDD";
            this.checkBoxDetailCarteBDD.Size = new System.Drawing.Size(187, 17);
            this.checkBoxDetailCarteBDD.TabIndex = 1;
            this.checkBoxDetailCarteBDD.Text = "dans tout les personnages du jeux";
            this.checkBoxDetailCarteBDD.UseVisualStyleBackColor = true;
            // 
            // checkBoxDetailPersoBox
            // 
            this.checkBoxDetailPersoBox.AutoSize = true;
            this.checkBoxDetailPersoBox.Location = new System.Drawing.Point(6, 42);
            this.checkBoxDetailPersoBox.Name = "checkBoxDetailPersoBox";
            this.checkBoxDetailPersoBox.Size = new System.Drawing.Size(100, 17);
            this.checkBoxDetailPersoBox.TabIndex = 0;
            this.checkBoxDetailPersoBox.Text = "Votre Collection";
            this.checkBoxDetailPersoBox.UseVisualStyleBackColor = true;
            // 
            // checkBoxInvasion
            // 
            this.checkBoxInvasion.AutoSize = true;
            this.checkBoxInvasion.Location = new System.Drawing.Point(30, 85);
            this.checkBoxInvasion.Name = "checkBoxInvasion";
            this.checkBoxInvasion.Size = new System.Drawing.Size(66, 17);
            this.checkBoxInvasion.TabIndex = 10;
            this.checkBoxInvasion.Text = "Invasion";
            this.checkBoxInvasion.UseVisualStyleBackColor = true;
            // 
            // checkBoxNest
            // 
            this.checkBoxNest.AutoSize = true;
            this.checkBoxNest.Location = new System.Drawing.Point(30, 62);
            this.checkBoxNest.Name = "checkBoxNest";
            this.checkBoxNest.Size = new System.Drawing.Size(48, 17);
            this.checkBoxNest.TabIndex = 9;
            this.checkBoxNest.Text = "Nest";
            this.checkBoxNest.UseVisualStyleBackColor = true;
            // 
            // checkBoxPvp
            // 
            this.checkBoxPvp.AutoSize = true;
            this.checkBoxPvp.Location = new System.Drawing.Point(30, 108);
            this.checkBoxPvp.Name = "checkBoxPvp";
            this.checkBoxPvp.Size = new System.Drawing.Size(44, 17);
            this.checkBoxPvp.TabIndex = 11;
            this.checkBoxPvp.Text = "pvp";
            this.checkBoxPvp.UseVisualStyleBackColor = true;
            // 
            // pictureBox2LogoCarte
            // 
            this.pictureBox2LogoCarte.Location = new System.Drawing.Point(126, 434);
            this.pictureBox2LogoCarte.Name = "pictureBox2LogoCarte";
            this.pictureBox2LogoCarte.Size = new System.Drawing.Size(69, 61);
            this.pictureBox2LogoCarte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2LogoCarte.TabIndex = 8;
            this.pictureBox2LogoCarte.TabStop = false;
            // 
            // btAutoTeam
            // 
            this.btAutoTeam.Location = new System.Drawing.Point(168, 326);
            this.btAutoTeam.Name = "btAutoTeam";
            this.btAutoTeam.Size = new System.Drawing.Size(102, 44);
            this.btAutoTeam.TabIndex = 12;
            this.btAutoTeam.Text = "Valider";
            this.btAutoTeam.UseVisualStyleBackColor = true;
            this.btAutoTeam.Click += new System.EventHandler(this.btAutoTeam_Click);
            // 
            // listBoxEquipe
            // 
            this.listBoxEquipe.FormattingEnabled = true;
            this.listBoxEquipe.Location = new System.Drawing.Point(6, 533);
            this.listBoxEquipe.Name = "listBoxEquipe";
            this.listBoxEquipe.Size = new System.Drawing.Size(492, 108);
            this.listBoxEquipe.TabIndex = 14;
            // 
            // pictureBox1LogoCarte
            // 
            this.pictureBox1LogoCarte.Location = new System.Drawing.Point(276, 434);
            this.pictureBox1LogoCarte.Name = "pictureBox1LogoCarte";
            this.pictureBox1LogoCarte.Size = new System.Drawing.Size(69, 61);
            this.pictureBox1LogoCarte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1LogoCarte.TabIndex = 15;
            this.pictureBox1LogoCarte.TabStop = false;
            // 
            // pictureBox0LogoCarte
            // 
            this.pictureBox0LogoCarte.Location = new System.Drawing.Point(201, 434);
            this.pictureBox0LogoCarte.Name = "pictureBox0LogoCarte";
            this.pictureBox0LogoCarte.Size = new System.Drawing.Size(69, 61);
            this.pictureBox0LogoCarte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox0LogoCarte.TabIndex = 16;
            this.pictureBox0LogoCarte.TabStop = false;
            // 
            // pictureBox3LogoCarte
            // 
            this.pictureBox3LogoCarte.Location = new System.Drawing.Point(351, 434);
            this.pictureBox3LogoCarte.Name = "pictureBox3LogoCarte";
            this.pictureBox3LogoCarte.Size = new System.Drawing.Size(69, 61);
            this.pictureBox3LogoCarte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3LogoCarte.TabIndex = 17;
            this.pictureBox3LogoCarte.TabStop = false;
            // 
            // pictureBox4LogoCarte
            // 
            this.pictureBox4LogoCarte.Location = new System.Drawing.Point(51, 434);
            this.pictureBox4LogoCarte.Name = "pictureBox4LogoCarte";
            this.pictureBox4LogoCarte.Size = new System.Drawing.Size(69, 61);
            this.pictureBox4LogoCarte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4LogoCarte.TabIndex = 18;
            this.pictureBox4LogoCarte.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Equipe enregistrer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(461, 26);
            this.label4.TabIndex = 20;
            this.label4.Text = "Séléctionner pour quel type de mode de jeux souhaitez vous crée votre équipe auto" +
    "matiquement\r\nen fonction des conditions";
            // 
            // listBoxConditionPrincipaleType
            // 
            this.listBoxConditionPrincipaleType.FormattingEnabled = true;
            this.listBoxConditionPrincipaleType.Items.AddRange(new object[] {
            "GOOD",
            "EVIL",
            "UNALIGNED"});
            this.listBoxConditionPrincipaleType.Location = new System.Drawing.Point(168, 153);
            this.listBoxConditionPrincipaleType.Name = "listBoxConditionPrincipaleType";
            this.listBoxConditionPrincipaleType.Size = new System.Drawing.Size(114, 43);
            this.listBoxConditionPrincipaleType.TabIndex = 21;
            // 
            // groupBoxEquipe
            // 
            this.groupBoxEquipe.Controls.Add(this.label6);
            this.groupBoxEquipe.Controls.Add(this.label5);
            this.groupBoxEquipe.Controls.Add(this.listBoxConditionSecondaireCouleur);
            this.groupBoxEquipe.Controls.Add(this.listBoxConditionSecondaireType);
            this.groupBoxEquipe.Controls.Add(this.listBoxConditionPrincipaleCouleur);
            this.groupBoxEquipe.Controls.Add(this.listBoxConditionPrincipaleType);
            this.groupBoxEquipe.Controls.Add(this.label4);
            this.groupBoxEquipe.Controls.Add(this.label3);
            this.groupBoxEquipe.Controls.Add(this.pictureBox4LogoCarte);
            this.groupBoxEquipe.Controls.Add(this.pictureBox3LogoCarte);
            this.groupBoxEquipe.Controls.Add(this.pictureBox0LogoCarte);
            this.groupBoxEquipe.Controls.Add(this.pictureBox1LogoCarte);
            this.groupBoxEquipe.Controls.Add(this.listBoxEquipe);
            this.groupBoxEquipe.Controls.Add(this.btAutoTeam);
            this.groupBoxEquipe.Controls.Add(this.pictureBox2LogoCarte);
            this.groupBoxEquipe.Controls.Add(this.checkBoxPvp);
            this.groupBoxEquipe.Controls.Add(this.checkBoxNest);
            this.groupBoxEquipe.Controls.Add(this.checkBoxInvasion);
            this.groupBoxEquipe.Location = new System.Drawing.Point(854, 12);
            this.groupBoxEquipe.Name = "groupBoxEquipe";
            this.groupBoxEquipe.Size = new System.Drawing.Size(504, 712);
            this.groupBoxEquipe.TabIndex = 13;
            this.groupBoxEquipe.TabStop = false;
            this.groupBoxEquipe.Text = "Equipe";
            this.groupBoxEquipe.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Condition Secondaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Condition Principale";
            // 
            // listBoxConditionSecondaireCouleur
            // 
            this.listBoxConditionSecondaireCouleur.FormattingEnabled = true;
            this.listBoxConditionSecondaireCouleur.Items.AddRange(new object[] {
            "BLEU",
            "ROUGE",
            "JAUNE",
            "VIOLET",
            "VERT"});
            this.listBoxConditionSecondaireCouleur.Location = new System.Drawing.Point(299, 232);
            this.listBoxConditionSecondaireCouleur.Name = "listBoxConditionSecondaireCouleur";
            this.listBoxConditionSecondaireCouleur.Size = new System.Drawing.Size(120, 69);
            this.listBoxConditionSecondaireCouleur.TabIndex = 24;
            // 
            // listBoxConditionSecondaireType
            // 
            this.listBoxConditionSecondaireType.FormattingEnabled = true;
            this.listBoxConditionSecondaireType.Items.AddRange(new object[] {
            "GOOD",
            "EVIL",
            "UNALIGNED"});
            this.listBoxConditionSecondaireType.Location = new System.Drawing.Point(168, 232);
            this.listBoxConditionSecondaireType.Name = "listBoxConditionSecondaireType";
            this.listBoxConditionSecondaireType.Size = new System.Drawing.Size(114, 43);
            this.listBoxConditionSecondaireType.TabIndex = 23;
            // 
            // listBoxConditionPrincipaleCouleur
            // 
            this.listBoxConditionPrincipaleCouleur.FormattingEnabled = true;
            this.listBoxConditionPrincipaleCouleur.Items.AddRange(new object[] {
            "BLEU",
            "ROUGE",
            "JAUNE",
            "VIOLET",
            "VERT"});
            this.listBoxConditionPrincipaleCouleur.Location = new System.Drawing.Point(299, 153);
            this.listBoxConditionPrincipaleCouleur.Name = "listBoxConditionPrincipaleCouleur";
            this.listBoxConditionPrincipaleCouleur.Size = new System.Drawing.Size(120, 69);
            this.listBoxConditionPrincipaleCouleur.TabIndex = 22;
            // 
            // buttonRetirerPersonnageUser
            // 
            this.buttonRetirerPersonnageUser.Location = new System.Drawing.Point(103, 165);
            this.buttonRetirerPersonnageUser.Name = "buttonRetirerPersonnageUser";
            this.buttonRetirerPersonnageUser.Size = new System.Drawing.Size(341, 68);
            this.buttonRetirerPersonnageUser.TabIndex = 15;
            this.buttonRetirerPersonnageUser.Text = "Retirer un personnage";
            this.buttonRetirerPersonnageUser.UseVisualStyleBackColor = true;
            // 
            // AccueilUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 736);
            this.Controls.Add(this.buttonRetirerPersonnageUser);
            this.Controls.Add(this.groupBoxDetailCarte);
            this.Controls.Add(this.groupBoxEquipe);
            this.Controls.Add(this.btAjouterPersoToUserCollection);
            this.Controls.Add(this.listBoxPersoPossedeParUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxPersoBDD);
            this.Controls.Add(this.groupBoxMenu);
            this.Name = "AccueilUser";
            this.Text = "      ";
            this.Load += new System.EventHandler(this.AccueilUser_Load);
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDetailCarte.ResumeLayout(false);
            this.groupBoxDetailCarte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2LogoCarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1LogoCarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0LogoCarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3LogoCarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4LogoCarte)).EndInit();
            this.groupBoxEquipe.ResumeLayout(false);
            this.groupBoxEquipe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMenuPersonnage;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.ListBox listBoxPersoBDD;
        private System.Windows.Forms.TextBox textBoxRecherchePersonnage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRecherchePerso;
        private System.Windows.Forms.CheckBox checkBoxDansLaBDD;
        private System.Windows.Forms.CheckBox checkBoxVotreCollection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxPersoPossedeParUser;
        private System.Windows.Forms.Button btAjouterPersoToUserCollection;
        private System.Windows.Forms.Button btMenuEquip;
        private System.Windows.Forms.GroupBox groupBoxDetailCarte;
        private System.Windows.Forms.Button buttonValiderDetailPersonnage;
        private System.Windows.Forms.CheckBox checkBoxDetailCarteBDD;
        private System.Windows.Forms.CheckBox checkBoxDetailPersoBox;
        private System.Windows.Forms.CheckBox checkBoxInvasion;
        private System.Windows.Forms.CheckBox checkBoxNest;
        private System.Windows.Forms.CheckBox checkBoxPvp;
        private System.Windows.Forms.PictureBox pictureBox2LogoCarte;
        private System.Windows.Forms.Button btAutoTeam;
        private System.Windows.Forms.ListBox listBoxEquipe;
        private System.Windows.Forms.PictureBox pictureBox1LogoCarte;
        private System.Windows.Forms.PictureBox pictureBox0LogoCarte;
        private System.Windows.Forms.PictureBox pictureBox3LogoCarte;
        private System.Windows.Forms.PictureBox pictureBox4LogoCarte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxConditionPrincipaleType;
        private System.Windows.Forms.GroupBox groupBoxEquipe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxConditionSecondaireCouleur;
        private System.Windows.Forms.ListBox listBoxConditionSecondaireType;
        private System.Windows.Forms.ListBox listBoxConditionPrincipaleCouleur;
        private System.Windows.Forms.Button buttonRetirerPersonnageUser;
    }
}