
namespace PPE2
{
    partial class ModificationCollectionUtilisateur
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
            this.labelPresentation = new System.Windows.Forms.Label();
            this.listBoxAjouterPersonnage = new System.Windows.Forms.ListBox();
            this.textBoxRecherchePersonnage = new System.Windows.Forms.TextBox();
            this.pictureBoxCarte = new System.Windows.Forms.PictureBox();
            this.labelNomCarte = new System.Windows.Forms.Label();
            this.buttonAjouterCarteToUser = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarte)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPresentation
            // 
            this.labelPresentation.AutoSize = true;
            this.labelPresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentation.Location = new System.Drawing.Point(12, 9);
            this.labelPresentation.Name = "labelPresentation";
            this.labelPresentation.Size = new System.Drawing.Size(429, 15);
            this.labelPresentation.TabIndex = 0;
            this.labelPresentation.Text = "Selectionner la carte que vous souhaitez ajouter à votre collection";
            // 
            // listBoxAjouterPersonnage
            // 
            this.listBoxAjouterPersonnage.FormattingEnabled = true;
            this.listBoxAjouterPersonnage.Location = new System.Drawing.Point(12, 138);
            this.listBoxAjouterPersonnage.Name = "listBoxAjouterPersonnage";
            this.listBoxAjouterPersonnage.Size = new System.Drawing.Size(188, 368);
            this.listBoxAjouterPersonnage.TabIndex = 1;
            this.listBoxAjouterPersonnage.SelectedIndexChanged += new System.EventHandler(this.listBoxAjouterPersonnage_SelectedIndexChanged);
            // 
            // textBoxRecherchePersonnage
            // 
            this.textBoxRecherchePersonnage.Location = new System.Drawing.Point(12, 102);
            this.textBoxRecherchePersonnage.Name = "textBoxRecherchePersonnage";
            this.textBoxRecherchePersonnage.Size = new System.Drawing.Size(188, 20);
            this.textBoxRecherchePersonnage.TabIndex = 2;
            this.textBoxRecherchePersonnage.TextChanged += new System.EventHandler(this.textBoxRecherchePersonnage_TextChanged);
            // 
            // pictureBoxCarte
            // 
            this.pictureBoxCarte.Location = new System.Drawing.Point(233, 138);
            this.pictureBoxCarte.Name = "pictureBoxCarte";
            this.pictureBoxCarte.Size = new System.Drawing.Size(126, 100);
            this.pictureBoxCarte.TabIndex = 3;
            this.pictureBoxCarte.TabStop = false;
            this.pictureBoxCarte.Visible = false;
            // 
            // labelNomCarte
            // 
            this.labelNomCarte.AutoSize = true;
            this.labelNomCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomCarte.Location = new System.Drawing.Point(230, 250);
            this.labelNomCarte.Name = "labelNomCarte";
            this.labelNomCarte.Size = new System.Drawing.Size(118, 16);
            this.labelNomCarte.TabIndex = 4;
            this.labelNomCarte.Text = "Nom de la carte";
            this.labelNomCarte.Visible = false;
            // 
            // buttonAjouterCarteToUser
            // 
            this.buttonAjouterCarteToUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterCarteToUser.Location = new System.Drawing.Point(233, 360);
            this.buttonAjouterCarteToUser.Name = "buttonAjouterCarteToUser";
            this.buttonAjouterCarteToUser.Size = new System.Drawing.Size(126, 29);
            this.buttonAjouterCarteToUser.TabIndex = 5;
            this.buttonAjouterCarteToUser.Text = "Valider";
            this.buttonAjouterCarteToUser.UseVisualStyleBackColor = true;
            this.buttonAjouterCarteToUser.Visible = false;
            this.buttonAjouterCarteToUser.Click += new System.EventHandler(this.buttonAjouterCarteToUser_Click);
            // 
            // buttonRetour
            // 
            this.buttonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.Location = new System.Drawing.Point(467, -3);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(91, 38);
            this.buttonRetour.TabIndex = 6;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rechercher :";
            // 
            // ModificationCollectionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonAjouterCarteToUser);
            this.Controls.Add(this.labelNomCarte);
            this.Controls.Add(this.pictureBoxCarte);
            this.Controls.Add(this.textBoxRecherchePersonnage);
            this.Controls.Add(this.listBoxAjouterPersonnage);
            this.Controls.Add(this.labelPresentation);
            this.Name = "ModificationCollectionUtilisateur";
            this.Text = "Modifier";
            this.Load += new System.EventHandler(this.ModificationCollectionUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPresentation;
        private System.Windows.Forms.ListBox listBoxAjouterPersonnage;
        private System.Windows.Forms.TextBox textBoxRecherchePersonnage;
        private System.Windows.Forms.PictureBox pictureBoxCarte;
        private System.Windows.Forms.Label labelNomCarte;
        private System.Windows.Forms.Button buttonAjouterCarteToUser;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label label1;
    }
}