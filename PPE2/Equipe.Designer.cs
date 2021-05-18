
namespace PPE2
{
    partial class Equipe
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBoxEquipeInvasion = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxEquipeNest = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxEquipePvp = new System.Windows.Forms.ListBox();
            this.listBoxConditionPrincipaleType = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxNest = new System.Windows.Forms.CheckBox();
            this.checkBoxPvp = new System.Windows.Forms.CheckBox();
            this.checkBoxInvasion = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxConditionPrincipaleCouleur = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxConditionSecondaireType = new System.Windows.Forms.ListBox();
            this.listBoxConditionSecondaireCouleur = new System.Windows.Forms.ListBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormationAuto1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFormationAuto2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFormationAuto5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFormationAuto3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFormationAuto4 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormationAuto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormationAuto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormationAuto5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormationAuto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormationAuto4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(719, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1084, 604);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipe enregistrer";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBoxEquipeInvasion);
            this.groupBox5.Location = new System.Drawing.Point(15, 403);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(561, 195);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Equipe INVASION";
            // 
            // listBoxEquipeInvasion
            // 
            this.listBoxEquipeInvasion.FormattingEnabled = true;
            this.listBoxEquipeInvasion.ItemHeight = 16;
            this.listBoxEquipeInvasion.Location = new System.Drawing.Point(0, 40);
            this.listBoxEquipeInvasion.Name = "listBoxEquipeInvasion";
            this.listBoxEquipeInvasion.Size = new System.Drawing.Size(555, 148);
            this.listBoxEquipeInvasion.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxEquipeNest);
            this.groupBox4.Location = new System.Drawing.Point(6, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(570, 151);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Equipe NEST";
            // 
            // listBoxEquipeNest
            // 
            this.listBoxEquipeNest.FormattingEnabled = true;
            this.listBoxEquipeNest.ItemHeight = 16;
            this.listBoxEquipeNest.Location = new System.Drawing.Point(9, 34);
            this.listBoxEquipeNest.Name = "listBoxEquipeNest";
            this.listBoxEquipeNest.Size = new System.Drawing.Size(555, 100);
            this.listBoxEquipeNest.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxEquipePvp);
            this.groupBox3.Location = new System.Drawing.Point(6, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 205);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Equipe PVP";
            // 
            // listBoxEquipePvp
            // 
            this.listBoxEquipePvp.FormattingEnabled = true;
            this.listBoxEquipePvp.ItemHeight = 16;
            this.listBoxEquipePvp.Location = new System.Drawing.Point(9, 30);
            this.listBoxEquipePvp.Name = "listBoxEquipePvp";
            this.listBoxEquipePvp.Size = new System.Drawing.Size(555, 164);
            this.listBoxEquipePvp.TabIndex = 0;
            this.listBoxEquipePvp.SelectedIndexChanged += new System.EventHandler(this.listBoxEquipePvp_SelectedIndexChanged);
            // 
            // listBoxConditionPrincipaleType
            // 
            this.listBoxConditionPrincipaleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxConditionPrincipaleType.FormattingEnabled = true;
            this.listBoxConditionPrincipaleType.ItemHeight = 16;
            this.listBoxConditionPrincipaleType.Items.AddRange(new object[] {
            "GOOD",
            "EVIL",
            "UNALIGNED"});
            this.listBoxConditionPrincipaleType.Location = new System.Drawing.Point(138, 146);
            this.listBoxConditionPrincipaleType.Name = "listBoxConditionPrincipaleType";
            this.listBoxConditionPrincipaleType.Size = new System.Drawing.Size(120, 52);
            this.listBoxConditionPrincipaleType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sélectionnez les critères qui serviront à composer automatiquement votre équipe\r\n" +
    "";
            // 
            // checkBoxNest
            // 
            this.checkBoxNest.AutoSize = true;
            this.checkBoxNest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNest.Location = new System.Drawing.Point(9, 79);
            this.checkBoxNest.Name = "checkBoxNest";
            this.checkBoxNest.Size = new System.Drawing.Size(55, 20);
            this.checkBoxNest.TabIndex = 2;
            this.checkBoxNest.Text = "Nest";
            this.checkBoxNest.UseVisualStyleBackColor = true;
            this.checkBoxNest.CheckedChanged += new System.EventHandler(this.checkBoxNest_CheckedChanged);
            // 
            // checkBoxPvp
            // 
            this.checkBoxPvp.AutoSize = true;
            this.checkBoxPvp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPvp.Location = new System.Drawing.Point(68, 79);
            this.checkBoxPvp.Name = "checkBoxPvp";
            this.checkBoxPvp.Size = new System.Drawing.Size(54, 20);
            this.checkBoxPvp.TabIndex = 3;
            this.checkBoxPvp.Text = "PVP";
            this.checkBoxPvp.UseVisualStyleBackColor = true;
            this.checkBoxPvp.CheckedChanged += new System.EventHandler(this.checkBoxPvp_CheckedChanged);
            // 
            // checkBoxInvasion
            // 
            this.checkBoxInvasion.AutoSize = true;
            this.checkBoxInvasion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInvasion.Location = new System.Drawing.Point(121, 79);
            this.checkBoxInvasion.Name = "checkBoxInvasion";
            this.checkBoxInvasion.Size = new System.Drawing.Size(77, 20);
            this.checkBoxInvasion.TabIndex = 4;
            this.checkBoxInvasion.Text = "Invasion";
            this.checkBoxInvasion.UseVisualStyleBackColor = true;
            this.checkBoxInvasion.CheckedChanged += new System.EventHandler(this.checkBoxInvasion_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Condition principale";
            // 
            // listBoxConditionPrincipaleCouleur
            // 
            this.listBoxConditionPrincipaleCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxConditionPrincipaleCouleur.FormattingEnabled = true;
            this.listBoxConditionPrincipaleCouleur.ItemHeight = 16;
            this.listBoxConditionPrincipaleCouleur.Items.AddRange(new object[] {
            "BLEU",
            "ROUGE",
            "JAUNE",
            "VIOLET",
            "VERT"});
            this.listBoxConditionPrincipaleCouleur.Location = new System.Drawing.Point(280, 146);
            this.listBoxConditionPrincipaleCouleur.Name = "listBoxConditionPrincipaleCouleur";
            this.listBoxConditionPrincipaleCouleur.Size = new System.Drawing.Size(120, 84);
            this.listBoxConditionPrincipaleCouleur.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Condition secondaire";
            // 
            // listBoxConditionSecondaireType
            // 
            this.listBoxConditionSecondaireType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxConditionSecondaireType.FormattingEnabled = true;
            this.listBoxConditionSecondaireType.ItemHeight = 16;
            this.listBoxConditionSecondaireType.Items.AddRange(new object[] {
            "GOOD",
            "EVIL",
            "UNALIGNED"});
            this.listBoxConditionSecondaireType.Location = new System.Drawing.Point(138, 280);
            this.listBoxConditionSecondaireType.Name = "listBoxConditionSecondaireType";
            this.listBoxConditionSecondaireType.Size = new System.Drawing.Size(120, 52);
            this.listBoxConditionSecondaireType.TabIndex = 8;
            // 
            // listBoxConditionSecondaireCouleur
            // 
            this.listBoxConditionSecondaireCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxConditionSecondaireCouleur.FormattingEnabled = true;
            this.listBoxConditionSecondaireCouleur.ItemHeight = 16;
            this.listBoxConditionSecondaireCouleur.Items.AddRange(new object[] {
            "BLEU",
            "ROUGE",
            "JAUNE",
            "VIOLET",
            "VERT"});
            this.listBoxConditionSecondaireCouleur.Location = new System.Drawing.Point(280, 280);
            this.listBoxConditionSecondaireCouleur.Name = "listBoxConditionSecondaireCouleur";
            this.listBoxConditionSecondaireCouleur.Size = new System.Drawing.Size(120, 84);
            this.listBoxConditionSecondaireCouleur.TabIndex = 9;
            // 
            // buttonValider
            // 
            this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Location = new System.Drawing.Point(10, 403);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(390, 66);
            this.buttonValider.TabIndex = 10;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonValider);
            this.groupBox1.Controls.Add(this.listBoxConditionSecondaireCouleur);
            this.groupBox1.Controls.Add(this.listBoxConditionSecondaireType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listBoxConditionPrincipaleCouleur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBoxInvasion);
            this.groupBox1.Controls.Add(this.checkBoxPvp);
            this.groupBox1.Controls.Add(this.checkBoxNest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBoxConditionPrincipaleType);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Composition automatique";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBoxFormationAuto1
            // 
            this.pictureBoxFormationAuto1.Location = new System.Drawing.Point(282, 508);
            this.pictureBoxFormationAuto1.Name = "pictureBoxFormationAuto1";
            this.pictureBoxFormationAuto1.Size = new System.Drawing.Size(100, 78);
            this.pictureBoxFormationAuto1.TabIndex = 17;
            this.pictureBoxFormationAuto1.TabStop = false;
            // 
            // pictureBoxFormationAuto2
            // 
            this.pictureBoxFormationAuto2.Location = new System.Drawing.Point(140, 508);
            this.pictureBoxFormationAuto2.Name = "pictureBoxFormationAuto2";
            this.pictureBoxFormationAuto2.Size = new System.Drawing.Size(100, 78);
            this.pictureBoxFormationAuto2.TabIndex = 16;
            this.pictureBoxFormationAuto2.TabStop = false;
            // 
            // pictureBoxFormationAuto5
            // 
            this.pictureBoxFormationAuto5.Location = new System.Drawing.Point(564, 508);
            this.pictureBoxFormationAuto5.Name = "pictureBoxFormationAuto5";
            this.pictureBoxFormationAuto5.Size = new System.Drawing.Size(100, 78);
            this.pictureBoxFormationAuto5.TabIndex = 15;
            this.pictureBoxFormationAuto5.TabStop = false;
            // 
            // pictureBoxFormationAuto3
            // 
            this.pictureBoxFormationAuto3.Location = new System.Drawing.Point(429, 508);
            this.pictureBoxFormationAuto3.Name = "pictureBoxFormationAuto3";
            this.pictureBoxFormationAuto3.Size = new System.Drawing.Size(100, 78);
            this.pictureBoxFormationAuto3.TabIndex = 14;
            this.pictureBoxFormationAuto3.TabStop = false;
            // 
            // pictureBoxFormationAuto4
            // 
            this.pictureBoxFormationAuto4.Location = new System.Drawing.Point(12, 508);
            this.pictureBoxFormationAuto4.Name = "pictureBoxFormationAuto4";
            this.pictureBoxFormationAuto4.Size = new System.Drawing.Size(100, 78);
            this.pictureBoxFormationAuto4.TabIndex = 11;
            this.pictureBoxFormationAuto4.TabStop = false;
            // 
            // Equipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 819);
            this.Controls.Add(this.pictureBoxFormationAuto1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBoxFormationAuto2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxFormationAuto5);
            this.Controls.Add(this.pictureBoxFormationAuto4);
            this.Controls.Add(this.pictureBoxFormationAuto3);
            this.Name = "Equipe";
            this.Text = "Equipe";
            this.Load += new System.EventHandler(this.Equipe_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormationAuto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormationAuto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormationAuto5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormationAuto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormationAuto4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBoxEquipeInvasion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxEquipeNest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxEquipePvp;
        private System.Windows.Forms.ListBox listBoxConditionPrincipaleType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxNest;
        private System.Windows.Forms.CheckBox checkBoxPvp;
        private System.Windows.Forms.CheckBox checkBoxInvasion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxConditionPrincipaleCouleur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxConditionSecondaireType;
        private System.Windows.Forms.ListBox listBoxConditionSecondaireCouleur;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxFormationAuto1;
        private System.Windows.Forms.PictureBox pictureBoxFormationAuto2;
        private System.Windows.Forms.PictureBox pictureBoxFormationAuto5;
        private System.Windows.Forms.PictureBox pictureBoxFormationAuto3;
        private System.Windows.Forms.PictureBox pictureBoxFormationAuto4;
    }
}