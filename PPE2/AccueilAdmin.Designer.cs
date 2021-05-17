
namespace PPE2
{
    partial class AccueilAdmin
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
            this.buttonCarte = new System.Windows.Forms.Button();
            this.buttonPersonnage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCarte
            // 
            this.buttonCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCarte.Location = new System.Drawing.Point(15, 93);
            this.buttonCarte.Name = "buttonCarte";
            this.buttonCarte.Size = new System.Drawing.Size(112, 41);
            this.buttonCarte.TabIndex = 0;
            this.buttonCarte.Text = "Carte";
            this.buttonCarte.UseVisualStyleBackColor = true;
            this.buttonCarte.Click += new System.EventHandler(this.buttonCarte_Click);
            // 
            // buttonPersonnage
            // 
            this.buttonPersonnage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonnage.Location = new System.Drawing.Point(280, 93);
            this.buttonPersonnage.Name = "buttonPersonnage";
            this.buttonPersonnage.Size = new System.Drawing.Size(155, 41);
            this.buttonPersonnage.TabIndex = 1;
            this.buttonPersonnage.Text = "Personnage";
            this.buttonPersonnage.UseVisualStyleBackColor = true;
            this.buttonPersonnage.Click += new System.EventHandler(this.buttonPersonnage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliquer sur un button pour continuer l\'administration de l\'utilitaire\r\n";
            // 
            // AccueilAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPersonnage);
            this.Controls.Add(this.buttonCarte);
            this.Name = "AccueilAdmin";
            this.Text = "AccueilAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCarte;
        private System.Windows.Forms.Button buttonPersonnage;
        private System.Windows.Forms.Label label1;
    }
}