
namespace PPE2
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxConnectionUser = new System.Windows.Forms.TextBox();
            this.btValiderConnection = new System.Windows.Forms.Button();
            this.textBoxConnectionMDP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.groupBoxInscription = new System.Windows.Forms.GroupBox();
            this.textBoxInscriptionValiderMDP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInscriptionUser = new System.Windows.Forms.TextBox();
            this.btInscription = new System.Windows.Forms.Button();
            this.textBoxInscriptionMDP = new System.Windows.Forms.TextBox();
            this.btQuitter = new System.Windows.Forms.Button();
            this.groupBoxConnection.SuspendLayout();
            this.groupBoxInscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxConnectionUser
            // 
            this.textBoxConnectionUser.Location = new System.Drawing.Point(102, 29);
            this.textBoxConnectionUser.Name = "textBoxConnectionUser";
            this.textBoxConnectionUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxConnectionUser.TabIndex = 0;
            // 
            // btValiderConnection
            // 
            this.btValiderConnection.Location = new System.Drawing.Point(102, 134);
            this.btValiderConnection.Name = "btValiderConnection";
            this.btValiderConnection.Size = new System.Drawing.Size(100, 23);
            this.btValiderConnection.TabIndex = 1;
            this.btValiderConnection.Text = "Connection";
            this.btValiderConnection.UseVisualStyleBackColor = true;
            this.btValiderConnection.Click += new System.EventHandler(this.btValiderConnection_Click);
            // 
            // textBoxConnectionMDP
            // 
            this.textBoxConnectionMDP.Location = new System.Drawing.Point(102, 91);
            this.textBoxConnectionMDP.Name = "textBoxConnectionMDP";
            this.textBoxConnectionMDP.Size = new System.Drawing.Size(100, 20);
            this.textBoxConnectionMDP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de Passe :";
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.label1);
            this.groupBoxConnection.Controls.Add(this.label2);
            this.groupBoxConnection.Controls.Add(this.textBoxConnectionUser);
            this.groupBoxConnection.Controls.Add(this.btValiderConnection);
            this.groupBoxConnection.Controls.Add(this.textBoxConnectionMDP);
            this.groupBoxConnection.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(247, 294);
            this.groupBoxConnection.TabIndex = 5;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Connection";
            // 
            // groupBoxInscription
            // 
            this.groupBoxInscription.Controls.Add(this.textBoxInscriptionValiderMDP);
            this.groupBoxInscription.Controls.Add(this.label5);
            this.groupBoxInscription.Controls.Add(this.label3);
            this.groupBoxInscription.Controls.Add(this.label4);
            this.groupBoxInscription.Controls.Add(this.textBoxInscriptionUser);
            this.groupBoxInscription.Controls.Add(this.btInscription);
            this.groupBoxInscription.Controls.Add(this.textBoxInscriptionMDP);
            this.groupBoxInscription.Location = new System.Drawing.Point(265, 12);
            this.groupBoxInscription.Name = "groupBoxInscription";
            this.groupBoxInscription.Size = new System.Drawing.Size(286, 294);
            this.groupBoxInscription.TabIndex = 6;
            this.groupBoxInscription.TabStop = false;
            this.groupBoxInscription.Text = "Inscription";
            // 
            // textBoxInscriptionValiderMDP
            // 
            this.textBoxInscriptionValiderMDP.Location = new System.Drawing.Point(157, 144);
            this.textBoxInscriptionValiderMDP.Name = "textBoxInscriptionValiderMDP";
            this.textBoxInscriptionValiderMDP.Size = new System.Drawing.Size(100, 20);
            this.textBoxInscriptionValiderMDP.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valider le Mot de Passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nom d\'utilisateur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mot de Passe :";
            // 
            // textBoxInscriptionUser
            // 
            this.textBoxInscriptionUser.Location = new System.Drawing.Point(157, 36);
            this.textBoxInscriptionUser.Name = "textBoxInscriptionUser";
            this.textBoxInscriptionUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxInscriptionUser.TabIndex = 5;
            // 
            // btInscription
            // 
            this.btInscription.Location = new System.Drawing.Point(157, 192);
            this.btInscription.Name = "btInscription";
            this.btInscription.Size = new System.Drawing.Size(100, 23);
            this.btInscription.TabIndex = 6;
            this.btInscription.Text = "Connection";
            this.btInscription.UseVisualStyleBackColor = true;
            this.btInscription.Click += new System.EventHandler(this.btInscription_Click);
            // 
            // textBoxInscriptionMDP
            // 
            this.textBoxInscriptionMDP.Location = new System.Drawing.Point(157, 91);
            this.textBoxInscriptionMDP.Name = "textBoxInscriptionMDP";
            this.textBoxInscriptionMDP.Size = new System.Drawing.Size(100, 20);
            this.textBoxInscriptionMDP.TabIndex = 7;
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(476, 312);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 12;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 344);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.groupBoxInscription);
            this.Controls.Add(this.groupBoxConnection);
            this.Name = "Accueil";
            this.Text = "Form1";
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            this.groupBoxInscription.ResumeLayout(false);
            this.groupBoxInscription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConnectionUser;
        private System.Windows.Forms.Button btValiderConnection;
        private System.Windows.Forms.TextBox textBoxConnectionMDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.GroupBox groupBoxInscription;
        private System.Windows.Forms.TextBox textBoxInscriptionValiderMDP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInscriptionUser;
        private System.Windows.Forms.Button btInscription;
        private System.Windows.Forms.TextBox textBoxInscriptionMDP;
        private System.Windows.Forms.Button btQuitter;
    }
}

