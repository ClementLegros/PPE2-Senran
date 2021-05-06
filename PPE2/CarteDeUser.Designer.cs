
namespace PPE2
{
    partial class CarteDeUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAjouterPerso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSupprimerCarte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vous pouvez retrouver ici toute les cartes que vous possedez.\r\nSi vous vous voule" +
    "z ajouter ou supprimer une carte à votre collection,\r\ncliquer sur les buttons en" +
    " bas\r\n\r\n";
            // 
            // buttonAjouterPerso
            // 
            this.buttonAjouterPerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterPerso.Location = new System.Drawing.Point(16, 74);
            this.buttonAjouterPerso.Name = "buttonAjouterPerso";
            this.buttonAjouterPerso.Size = new System.Drawing.Size(215, 47);
            this.buttonAjouterPerso.TabIndex = 1;
            this.buttonAjouterPerso.Text = "Ajouter une carte";
            this.buttonAjouterPerso.UseVisualStyleBackColor = true;
            this.buttonAjouterPerso.Click += new System.EventHandler(this.buttonAjouterPerso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liste de vos cartes :\r\n";
            // 
            // buttonSupprimerCarte
            // 
            this.buttonSupprimerCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerCarte.Location = new System.Drawing.Point(237, 74);
            this.buttonSupprimerCarte.Name = "buttonSupprimerCarte";
            this.buttonSupprimerCarte.Size = new System.Drawing.Size(215, 47);
            this.buttonSupprimerCarte.TabIndex = 3;
            this.buttonSupprimerCarte.Text = "Supprimer une carte";
            this.buttonSupprimerCarte.UseVisualStyleBackColor = true;
            this.buttonSupprimerCarte.Click += new System.EventHandler(this.buttonSupprimerCarte_Click);
            // 
            // CarteDeUser
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(577, 648);
            this.Controls.Add(this.buttonSupprimerCarte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAjouterPerso);
            this.Controls.Add(this.label1);
            this.Name = "CarteDeUser";
            this.Text = "Collection";
            this.Load += new System.EventHandler(this.PersonnageDeUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAjouterPerso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSupprimerCarte;
    }
}