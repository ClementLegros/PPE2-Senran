
namespace PPE2
{
    partial class ResultatRecherche
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
            this.buttonRetourEcranRecherche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRetourEcranRecherche
            // 
            this.buttonRetourEcranRecherche.Location = new System.Drawing.Point(12, 12);
            this.buttonRetourEcranRecherche.Name = "buttonRetourEcranRecherche";
            this.buttonRetourEcranRecherche.Size = new System.Drawing.Size(141, 46);
            this.buttonRetourEcranRecherche.TabIndex = 22;
            this.buttonRetourEcranRecherche.Text = "Retour à l\'écran de recherche";
            this.buttonRetourEcranRecherche.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cliquer sur le logo pour plus de détails !\r\n";
            // 
            // ResultatRecherche
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1494, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRetourEcranRecherche);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ResultatRecherche";
            this.Text = "ResultatRecherche";
            this.Load += new System.EventHandler(this.ResultatRecherche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRetourEcranRecherche;
        private System.Windows.Forms.Label label1;
    }
}