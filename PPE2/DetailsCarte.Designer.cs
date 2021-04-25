
namespace PPE2
{
    partial class DetailsCarte
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
            this.pictureBoxPersonnage = new System.Windows.Forms.PictureBox();
            this.labelNomCarte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonnage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPersonnage
            // 
            this.pictureBoxPersonnage.Location = new System.Drawing.Point(16, 15);
            this.pictureBoxPersonnage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPersonnage.Name = "pictureBoxPersonnage";
            this.pictureBoxPersonnage.Size = new System.Drawing.Size(331, 280);
            this.pictureBoxPersonnage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPersonnage.TabIndex = 0;
            this.pictureBoxPersonnage.TabStop = false;
            // 
            // labelNomCarte
            // 
            this.labelNomCarte.AutoSize = true;
            this.labelNomCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomCarte.Location = new System.Drawing.Point(13, 324);
            this.labelNomCarte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomCarte.Name = "labelNomCarte";
            this.labelNomCarte.Size = new System.Drawing.Size(51, 16);
            this.labelNomCarte.TabIndex = 1;
            this.labelNomCarte.Text = "label1";
            // 
            // DetailsCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 349);
            this.Controls.Add(this.labelNomCarte);
            this.Controls.Add(this.pictureBoxPersonnage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetailsCarte";
            this.Text = "DetailsCarte";
            this.Load += new System.EventHandler(this.DetailsCarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonnage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPersonnage;
        private System.Windows.Forms.Label labelNomCarte;
    }
}