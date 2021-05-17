
namespace PPE2
{
    partial class adminPersonnage
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
            this.listBoxPersonnage = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonValiderModif = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxLogoChibiModif = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAgeModif = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTailleModif = new System.Windows.Forms.TextBox();
            this.buttonSupprimerPersonnage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxEcoleModif = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomPersonnageModif = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAjouterPersonnage = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAjouterLogoChibi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAjouterAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAjouterTaille = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxAjouterEcole = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAjouterNomPersonnage = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sélectionnez les actions que vous souhaitez effectuer\r\n";
            // 
            // listBoxPersonnage
            // 
            this.listBoxPersonnage.FormattingEnabled = true;
            this.listBoxPersonnage.Location = new System.Drawing.Point(6, 19);
            this.listBoxPersonnage.Name = "listBoxPersonnage";
            this.listBoxPersonnage.Size = new System.Drawing.Size(172, 225);
            this.listBoxPersonnage.TabIndex = 1;
            this.listBoxPersonnage.SelectedIndexChanged += new System.EventHandler(this.listBoxPersonnage_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sélectionnez les actions que vous souhaitez effectuer\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonValiderModif);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxLogoChibiModif);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxAgeModif);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxTailleModif);
            this.groupBox1.Controls.Add(this.buttonSupprimerPersonnage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listBoxEcoleModif);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNomPersonnageModif);
            this.groupBox1.Controls.Add(this.listBoxPersonnage);
            this.groupBox1.Location = new System.Drawing.Point(15, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 305);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier / Supprimer";
            // 
            // buttonValiderModif
            // 
            this.buttonValiderModif.Location = new System.Drawing.Point(278, 218);
            this.buttonValiderModif.Name = "buttonValiderModif";
            this.buttonValiderModif.Size = new System.Drawing.Size(215, 31);
            this.buttonValiderModif.TabIndex = 24;
            this.buttonValiderModif.Text = "Modifier";
            this.buttonValiderModif.UseVisualStyleBackColor = true;
            this.buttonValiderModif.Click += new System.EventHandler(this.buttonValiderModif_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Logo chibi";
            // 
            // textBoxLogoChibiModif
            // 
            this.textBoxLogoChibiModif.Location = new System.Drawing.Point(278, 192);
            this.textBoxLogoChibiModif.Name = "textBoxLogoChibiModif";
            this.textBoxLogoChibiModif.Size = new System.Drawing.Size(215, 20);
            this.textBoxLogoChibiModif.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(246, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Age";
            // 
            // textBoxAgeModif
            // 
            this.textBoxAgeModif.Location = new System.Drawing.Point(278, 166);
            this.textBoxAgeModif.Name = "textBoxAgeModif";
            this.textBoxAgeModif.Size = new System.Drawing.Size(215, 20);
            this.textBoxAgeModif.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(240, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Taille";
            // 
            // textBoxTailleModif
            // 
            this.textBoxTailleModif.Location = new System.Drawing.Point(278, 140);
            this.textBoxTailleModif.Name = "textBoxTailleModif";
            this.textBoxTailleModif.Size = new System.Drawing.Size(215, 20);
            this.textBoxTailleModif.TabIndex = 18;
            // 
            // buttonSupprimerPersonnage
            // 
            this.buttonSupprimerPersonnage.Location = new System.Drawing.Point(6, 250);
            this.buttonSupprimerPersonnage.Name = "buttonSupprimerPersonnage";
            this.buttonSupprimerPersonnage.Size = new System.Drawing.Size(172, 31);
            this.buttonSupprimerPersonnage.TabIndex = 17;
            this.buttonSupprimerPersonnage.Text = "Supprimer";
            this.buttonSupprimerPersonnage.UseVisualStyleBackColor = true;
            this.buttonSupprimerPersonnage.Click += new System.EventHandler(this.buttonSupprimerPersonnage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ecole";
            // 
            // listBoxEcoleModif
            // 
            this.listBoxEcoleModif.FormattingEnabled = true;
            this.listBoxEcoleModif.Location = new System.Drawing.Point(278, 52);
            this.listBoxEcoleModif.Name = "listBoxEcoleModif";
            this.listBoxEcoleModif.Size = new System.Drawing.Size(215, 82);
            this.listBoxEcoleModif.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom personnage";
            // 
            // textBoxNomPersonnageModif
            // 
            this.textBoxNomPersonnageModif.Location = new System.Drawing.Point(278, 16);
            this.textBoxNomPersonnageModif.Name = "textBoxNomPersonnageModif";
            this.textBoxNomPersonnageModif.Size = new System.Drawing.Size(215, 20);
            this.textBoxNomPersonnageModif.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAjouterPersonnage);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxAjouterLogoChibi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxAjouterAge);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxAjouterTaille);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listBoxAjouterEcole);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxAjouterNomPersonnage);
            this.groupBox2.Location = new System.Drawing.Point(560, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 305);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajouter";
            // 
            // buttonAjouterPersonnage
            // 
            this.buttonAjouterPersonnage.Location = new System.Drawing.Point(100, 218);
            this.buttonAjouterPersonnage.Name = "buttonAjouterPersonnage";
            this.buttonAjouterPersonnage.Size = new System.Drawing.Size(215, 31);
            this.buttonAjouterPersonnage.TabIndex = 16;
            this.buttonAjouterPersonnage.Text = "Ajouter";
            this.buttonAjouterPersonnage.UseVisualStyleBackColor = true;
            this.buttonAjouterPersonnage.Click += new System.EventHandler(this.buttonAjouterPersonnage_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Logo chibi";
            // 
            // textBoxAjouterLogoChibi
            // 
            this.textBoxAjouterLogoChibi.Location = new System.Drawing.Point(100, 192);
            this.textBoxAjouterLogoChibi.Name = "textBoxAjouterLogoChibi";
            this.textBoxAjouterLogoChibi.Size = new System.Drawing.Size(215, 20);
            this.textBoxAjouterLogoChibi.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Age";
            // 
            // textBoxAjouterAge
            // 
            this.textBoxAjouterAge.Location = new System.Drawing.Point(100, 166);
            this.textBoxAjouterAge.Name = "textBoxAjouterAge";
            this.textBoxAjouterAge.Size = new System.Drawing.Size(215, 20);
            this.textBoxAjouterAge.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Taille";
            // 
            // textBoxAjouterTaille
            // 
            this.textBoxAjouterTaille.Location = new System.Drawing.Point(100, 140);
            this.textBoxAjouterTaille.Name = "textBoxAjouterTaille";
            this.textBoxAjouterTaille.Size = new System.Drawing.Size(215, 20);
            this.textBoxAjouterTaille.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nom ecole";
            // 
            // listBoxAjouterEcole
            // 
            this.listBoxAjouterEcole.FormattingEnabled = true;
            this.listBoxAjouterEcole.Location = new System.Drawing.Point(100, 52);
            this.listBoxAjouterEcole.Name = "listBoxAjouterEcole";
            this.listBoxAjouterEcole.Size = new System.Drawing.Size(215, 82);
            this.listBoxAjouterEcole.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nom personnage";
            // 
            // textBoxAjouterNomPersonnage
            // 
            this.textBoxAjouterNomPersonnage.Location = new System.Drawing.Point(100, 16);
            this.textBoxAjouterNomPersonnage.Name = "textBoxAjouterNomPersonnage";
            this.textBoxAjouterNomPersonnage.Size = new System.Drawing.Size(215, 20);
            this.textBoxAjouterNomPersonnage.TabIndex = 6;
            // 
            // adminPersonnage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 410);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminPersonnage";
            this.Text = "adminPersonnage";
            this.Load += new System.EventHandler(this.adminPersonnage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPersonnage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxEcoleModif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomPersonnageModif;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSupprimerPersonnage;
        private System.Windows.Forms.Button buttonAjouterPersonnage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAjouterLogoChibi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAjouterAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAjouterTaille;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxAjouterEcole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAjouterNomPersonnage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxLogoChibiModif;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxAgeModif;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTailleModif;
        private System.Windows.Forms.Button buttonValiderModif;
    }
}