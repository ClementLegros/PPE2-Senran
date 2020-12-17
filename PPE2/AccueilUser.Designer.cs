
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
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
            this.pictureBoxPersonnage = new System.Windows.Forms.PictureBox();
            this.groupBoxMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonnage)).BeginInit();
            this.SuspendLayout();
            // 
            // btMenuPersonnage
            // 
            this.btMenuPersonnage.Location = new System.Drawing.Point(5, 29);
            this.btMenuPersonnage.Name = "btMenuPersonnage";
            this.btMenuPersonnage.Size = new System.Drawing.Size(75, 30);
            this.btMenuPersonnage.TabIndex = 0;
            this.btMenuPersonnage.Text = "Personnage";
            this.btMenuPersonnage.UseVisualStyleBackColor = true;
            this.btMenuPersonnage.Click += new System.EventHandler(this.btMenuPersonnage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.btMenuPersonnage);
            this.groupBoxMenu.Controls.Add(this.button2);
            this.groupBoxMenu.Location = new System.Drawing.Point(1, 2);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(86, 468);
            this.groupBoxMenu.TabIndex = 2;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "MENU";
            // 
            // listBoxPersoBDD
            // 
            this.listBoxPersoBDD.FormattingEnabled = true;
            this.listBoxPersoBDD.Location = new System.Drawing.Point(557, 12);
            this.listBoxPersoBDD.Name = "listBoxPersoBDD";
            this.listBoxPersoBDD.Size = new System.Drawing.Size(291, 264);
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
            this.listBoxPersoPossedeParUser.Size = new System.Drawing.Size(341, 368);
            this.listBoxPersoPossedeParUser.TabIndex = 6;
            // 
            // btAjouterPersoToUserCollection
            // 
            this.btAjouterPersoToUserCollection.Location = new System.Drawing.Point(557, 278);
            this.btAjouterPersoToUserCollection.Name = "btAjouterPersoToUserCollection";
            this.btAjouterPersoToUserCollection.Size = new System.Drawing.Size(291, 107);
            this.btAjouterPersoToUserCollection.TabIndex = 7;
            this.btAjouterPersoToUserCollection.Text = "Ajouter un personnage à votre collection";
            this.btAjouterPersoToUserCollection.UseVisualStyleBackColor = true;
            this.btAjouterPersoToUserCollection.Click += new System.EventHandler(this.btAjouterPersoToUserCollection_Click);
            // 
            // pictureBoxPersonnage
            // 
            this.pictureBoxPersonnage.Location = new System.Drawing.Point(878, 12);
            this.pictureBoxPersonnage.Name = "pictureBoxPersonnage";
            this.pictureBoxPersonnage.Size = new System.Drawing.Size(470, 373);
            this.pictureBoxPersonnage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPersonnage.TabIndex = 8;
            this.pictureBoxPersonnage.TabStop = false;
            // 
            // AccueilUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 512);
            this.Controls.Add(this.pictureBoxPersonnage);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonnage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMenuPersonnage;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.PictureBox pictureBoxPersonnage;
    }
}