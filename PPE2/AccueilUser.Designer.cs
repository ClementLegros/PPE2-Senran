
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilUser));
            this.btMenuPersonnage = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.buttonRecherche = new System.Windows.Forms.Button();
            this.btMenuEquip = new System.Windows.Forms.Button();
            this.listBoxPersoBDD = new System.Windows.Forms.ListBox();
            this.btAjouterPersoToUserCollection = new System.Windows.Forms.Button();
            this.groupBoxPersonnageNouveau = new System.Windows.Forms.GroupBox();
            this.pictureBoxDernierPersoSorti6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDernierPersoSorti5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDernierPersoSorti4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDernierPersoSorti3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDernierPersoSorti2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDernierPersoSorti1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonPersonnage = new System.Windows.Forms.Button();
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxPersonnageNouveau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDernierPersoSorti6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDernierPersoSorti5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDernierPersoSorti4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDernierPersoSorti3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDernierPersoSorti2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDernierPersoSorti1)).BeginInit();
            this.SuspendLayout();
            // 
            // btMenuPersonnage
            // 
            this.btMenuPersonnage.Location = new System.Drawing.Point(5, 29);
            this.btMenuPersonnage.Name = "btMenuPersonnage";
            this.btMenuPersonnage.Size = new System.Drawing.Size(112, 26);
            this.btMenuPersonnage.TabIndex = 0;
            this.btMenuPersonnage.Text = "Collection";
            this.btMenuPersonnage.UseVisualStyleBackColor = true;
            this.btMenuPersonnage.Click += new System.EventHandler(this.btMenuPersonnage_Click);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.buttonPersonnage);
            this.groupBoxMenu.Controls.Add(this.buttonRecherche);
            this.groupBoxMenu.Controls.Add(this.btMenuPersonnage);
            this.groupBoxMenu.Controls.Add(this.btMenuEquip);
            this.groupBoxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMenu.Location = new System.Drawing.Point(1, 2);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(562, 62);
            this.groupBoxMenu.TabIndex = 2;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "MENU";
            // 
            // buttonRecherche
            // 
            this.buttonRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecherche.Location = new System.Drawing.Point(247, 29);
            this.buttonRecherche.Name = "buttonRecherche";
            this.buttonRecherche.Size = new System.Drawing.Size(118, 26);
            this.buttonRecherche.TabIndex = 2;
            this.buttonRecherche.Text = "Recherche";
            this.buttonRecherche.UseVisualStyleBackColor = true;
            this.buttonRecherche.Click += new System.EventHandler(this.buttonRecherche_Click);
            // 
            // btMenuEquip
            // 
            this.btMenuEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenuEquip.Location = new System.Drawing.Point(123, 29);
            this.btMenuEquip.Name = "btMenuEquip";
            this.btMenuEquip.Size = new System.Drawing.Size(118, 26);
            this.btMenuEquip.TabIndex = 1;
            this.btMenuEquip.Text = "Equipe";
            this.btMenuEquip.UseVisualStyleBackColor = true;
            this.btMenuEquip.Click += new System.EventHandler(this.btMenuEquip_Click);
            // 
            // listBoxPersoBDD
            // 
            this.listBoxPersoBDD.FormattingEnabled = true;
            this.listBoxPersoBDD.Location = new System.Drawing.Point(1958, 12);
            this.listBoxPersoBDD.Name = "listBoxPersoBDD";
            this.listBoxPersoBDD.Size = new System.Drawing.Size(291, 147);
            this.listBoxPersoBDD.TabIndex = 3;
            // 
            // btAjouterPersoToUserCollection
            // 
            this.btAjouterPersoToUserCollection.Location = new System.Drawing.Point(1958, 165);
            this.btAjouterPersoToUserCollection.Name = "btAjouterPersoToUserCollection";
            this.btAjouterPersoToUserCollection.Size = new System.Drawing.Size(291, 68);
            this.btAjouterPersoToUserCollection.TabIndex = 7;
            this.btAjouterPersoToUserCollection.Text = "Ajouter un personnage à votre collection";
            this.btAjouterPersoToUserCollection.UseVisualStyleBackColor = true;
            this.btAjouterPersoToUserCollection.Click += new System.EventHandler(this.btAjouterPersoToUserCollection_Click);
            // 
            // groupBoxPersonnageNouveau
            // 
            this.groupBoxPersonnageNouveau.Controls.Add(this.pictureBoxDernierPersoSorti6);
            this.groupBoxPersonnageNouveau.Controls.Add(this.pictureBoxDernierPersoSorti5);
            this.groupBoxPersonnageNouveau.Controls.Add(this.pictureBoxDernierPersoSorti4);
            this.groupBoxPersonnageNouveau.Controls.Add(this.pictureBoxDernierPersoSorti3);
            this.groupBoxPersonnageNouveau.Controls.Add(this.pictureBoxDernierPersoSorti2);
            this.groupBoxPersonnageNouveau.Controls.Add(this.pictureBoxDernierPersoSorti1);
            this.groupBoxPersonnageNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPersonnageNouveau.Location = new System.Drawing.Point(6, 270);
            this.groupBoxPersonnageNouveau.Name = "groupBoxPersonnageNouveau";
            this.groupBoxPersonnageNouveau.Size = new System.Drawing.Size(526, 292);
            this.groupBoxPersonnageNouveau.TabIndex = 16;
            this.groupBoxPersonnageNouveau.TabStop = false;
            this.groupBoxPersonnageNouveau.Text = "Dernier personnage rajouté à l\'application";
            // 
            // pictureBoxDernierPersoSorti6
            // 
            this.pictureBoxDernierPersoSorti6.Location = new System.Drawing.Point(385, 160);
            this.pictureBoxDernierPersoSorti6.Name = "pictureBoxDernierPersoSorti6";
            this.pictureBoxDernierPersoSorti6.Size = new System.Drawing.Size(120, 100);
            this.pictureBoxDernierPersoSorti6.TabIndex = 5;
            this.pictureBoxDernierPersoSorti6.TabStop = false;
            // 
            // pictureBoxDernierPersoSorti5
            // 
            this.pictureBoxDernierPersoSorti5.Location = new System.Drawing.Point(199, 160);
            this.pictureBoxDernierPersoSorti5.Name = "pictureBoxDernierPersoSorti5";
            this.pictureBoxDernierPersoSorti5.Size = new System.Drawing.Size(120, 100);
            this.pictureBoxDernierPersoSorti5.TabIndex = 4;
            this.pictureBoxDernierPersoSorti5.TabStop = false;
            // 
            // pictureBoxDernierPersoSorti4
            // 
            this.pictureBoxDernierPersoSorti4.Location = new System.Drawing.Point(6, 160);
            this.pictureBoxDernierPersoSorti4.Name = "pictureBoxDernierPersoSorti4";
            this.pictureBoxDernierPersoSorti4.Size = new System.Drawing.Size(120, 100);
            this.pictureBoxDernierPersoSorti4.TabIndex = 3;
            this.pictureBoxDernierPersoSorti4.TabStop = false;
            // 
            // pictureBoxDernierPersoSorti3
            // 
            this.pictureBoxDernierPersoSorti3.Location = new System.Drawing.Point(385, 36);
            this.pictureBoxDernierPersoSorti3.Name = "pictureBoxDernierPersoSorti3";
            this.pictureBoxDernierPersoSorti3.Size = new System.Drawing.Size(120, 100);
            this.pictureBoxDernierPersoSorti3.TabIndex = 2;
            this.pictureBoxDernierPersoSorti3.TabStop = false;
            // 
            // pictureBoxDernierPersoSorti2
            // 
            this.pictureBoxDernierPersoSorti2.Location = new System.Drawing.Point(199, 36);
            this.pictureBoxDernierPersoSorti2.Name = "pictureBoxDernierPersoSorti2";
            this.pictureBoxDernierPersoSorti2.Size = new System.Drawing.Size(120, 100);
            this.pictureBoxDernierPersoSorti2.TabIndex = 1;
            this.pictureBoxDernierPersoSorti2.TabStop = false;
            // 
            // pictureBoxDernierPersoSorti1
            // 
            this.pictureBoxDernierPersoSorti1.Location = new System.Drawing.Point(6, 36);
            this.pictureBoxDernierPersoSorti1.Name = "pictureBoxDernierPersoSorti1";
            this.pictureBoxDernierPersoSorti1.Size = new System.Drawing.Size(120, 100);
            this.pictureBoxDernierPersoSorti1.TabIndex = 0;
            this.pictureBoxDernierPersoSorti1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(697, 80);
            this.label7.TabIndex = 17;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // buttonPersonnage
            // 
            this.buttonPersonnage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonnage.Location = new System.Drawing.Point(371, 29);
            this.buttonPersonnage.Name = "buttonPersonnage";
            this.buttonPersonnage.Size = new System.Drawing.Size(118, 26);
            this.buttonPersonnage.TabIndex = 3;
            this.buttonPersonnage.Text = "Personnage";
            this.buttonPersonnage.UseVisualStyleBackColor = true;
            this.buttonPersonnage.Click += new System.EventHandler(this.buttonPersonnage_Click);
            // 
            // AccueilUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 736);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBoxPersonnageNouveau);
            this.Controls.Add(this.btAjouterPersoToUserCollection);
            this.Controls.Add(this.listBoxPersoBDD);
            this.Controls.Add(this.groupBoxMenu);
            this.Name = "AccueilUser";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.AccueilUser_Load);
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxPersonnageNouveau.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDernierPersoSorti6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDernierPersoSorti5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDernierPersoSorti4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDernierPersoSorti3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDernierPersoSorti2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDernierPersoSorti1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMenuPersonnage;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.ListBox listBoxPersoBDD;
        private System.Windows.Forms.Button btAjouterPersoToUserCollection;
        private System.Windows.Forms.Button btMenuEquip;
        private System.Windows.Forms.GroupBox groupBoxPersonnageNouveau;
        private System.Windows.Forms.PictureBox pictureBoxDernierPersoSorti6;
        private System.Windows.Forms.PictureBox pictureBoxDernierPersoSorti5;
        private System.Windows.Forms.PictureBox pictureBoxDernierPersoSorti4;
        private System.Windows.Forms.PictureBox pictureBoxDernierPersoSorti3;
        private System.Windows.Forms.PictureBox pictureBoxDernierPersoSorti2;
        private System.Windows.Forms.PictureBox pictureBoxDernierPersoSorti1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRecherche;
        private System.Windows.Forms.Button buttonPersonnage;
    }
}