
namespace PPE2
{
    partial class PersonnageInfo
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
            this.listBoxPersonnage = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelTaille = new System.Windows.Forms.Label();
            this.labelNomPersonnage = new System.Windows.Forms.Label();
            this.pictureBoxChibiPersonnage = new System.Windows.Forms.PictureBox();
            this.labelEcole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChibiPersonnage)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPersonnage
            // 
            this.listBoxPersonnage.FormattingEnabled = true;
            this.listBoxPersonnage.ItemHeight = 18;
            this.listBoxPersonnage.Location = new System.Drawing.Point(21, 70);
            this.listBoxPersonnage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxPersonnage.Name = "listBoxPersonnage";
            this.listBoxPersonnage.Size = new System.Drawing.Size(178, 544);
            this.listBoxPersonnage.TabIndex = 0;
            this.listBoxPersonnage.SelectedIndexChanged += new System.EventHandler(this.listBoxPersonnage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliquer sur un personnage pour plus de détails";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(361, 108);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(33, 18);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age";
            this.labelAge.Visible = false;
            // 
            // labelTaille
            // 
            this.labelTaille.AutoSize = true;
            this.labelTaille.Location = new System.Drawing.Point(361, 144);
            this.labelTaille.Name = "labelTaille";
            this.labelTaille.Size = new System.Drawing.Size(42, 18);
            this.labelTaille.TabIndex = 3;
            this.labelTaille.Text = "Taille";
            this.labelTaille.Visible = false;
            // 
            // labelNomPersonnage
            // 
            this.labelNomPersonnage.AutoSize = true;
            this.labelNomPersonnage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomPersonnage.Location = new System.Drawing.Point(361, 70);
            this.labelNomPersonnage.Name = "labelNomPersonnage";
            this.labelNomPersonnage.Size = new System.Drawing.Size(92, 18);
            this.labelNomPersonnage.TabIndex = 4;
            this.labelNomPersonnage.Text = "Nom perso";
            this.labelNomPersonnage.Visible = false;
            // 
            // pictureBoxChibiPersonnage
            // 
            this.pictureBoxChibiPersonnage.Location = new System.Drawing.Point(213, 73);
            this.pictureBoxChibiPersonnage.Name = "pictureBoxChibiPersonnage";
            this.pictureBoxChibiPersonnage.Size = new System.Drawing.Size(128, 112);
            this.pictureBoxChibiPersonnage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChibiPersonnage.TabIndex = 5;
            this.pictureBoxChibiPersonnage.TabStop = false;
            this.pictureBoxChibiPersonnage.Visible = false;
            // 
            // labelEcole
            // 
            this.labelEcole.AutoSize = true;
            this.labelEcole.Location = new System.Drawing.Point(361, 178);
            this.labelEcole.Name = "labelEcole";
            this.labelEcole.Size = new System.Drawing.Size(46, 18);
            this.labelEcole.TabIndex = 6;
            this.labelEcole.Text = "Ecole";
            this.labelEcole.Visible = false;
            // 
            // PersonnageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 623);
            this.Controls.Add(this.labelEcole);
            this.Controls.Add(this.pictureBoxChibiPersonnage);
            this.Controls.Add(this.labelNomPersonnage);
            this.Controls.Add(this.labelTaille);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPersonnage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PersonnageInfo";
            this.Text = "PersonnageInfo";
            this.Load += new System.EventHandler(this.PersonnageInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChibiPersonnage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPersonnage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelTaille;
        private System.Windows.Forms.Label labelNomPersonnage;
        private System.Windows.Forms.PictureBox pictureBoxChibiPersonnage;
        private System.Windows.Forms.Label labelEcole;
    }
}