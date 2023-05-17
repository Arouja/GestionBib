namespace GUI
{
    partial class NouveauLivre
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
            this.Livre = new System.Windows.Forms.Label();
            this.textAuteur = new System.Windows.Forms.TextBox();
            this.Numpage = new System.Windows.Forms.Label();
            this.textNumpage = new System.Windows.Forms.TextBox();
            this.AjouterL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Livre
            // 
            this.Livre.AutoSize = true;
            this.Livre.Location = new System.Drawing.Point(23, 18);
            this.Livre.Name = "Livre";
            this.Livre.Size = new System.Drawing.Size(41, 13);
            this.Livre.TabIndex = 0;
            this.Livre.Text = "Auteur:";
            // 
            // textAuteur
            // 
            this.textAuteur.Location = new System.Drawing.Point(101, 18);
            this.textAuteur.Name = "textAuteur";
            this.textAuteur.Size = new System.Drawing.Size(130, 20);
            this.textAuteur.TabIndex = 1;
            // 
            // Numpage
            // 
            this.Numpage.AutoSize = true;
            this.Numpage.Location = new System.Drawing.Point(24, 73);
            this.Numpage.Name = "Numpage";
            this.Numpage.Size = new System.Drawing.Size(56, 13);
            this.Numpage.TabIndex = 2;
            this.Numpage.Text = "Numpage:";
            // 
            // textNumpage
            // 
            this.textNumpage.Location = new System.Drawing.Point(101, 70);
            this.textNumpage.Name = "textNumpage";
            this.textNumpage.Size = new System.Drawing.Size(151, 20);
            this.textNumpage.TabIndex = 3;
            // 
            // AjouterL
            // 
            this.AjouterL.Location = new System.Drawing.Point(219, 137);
            this.AjouterL.Name = "AjouterL";
            this.AjouterL.Size = new System.Drawing.Size(132, 31);
            this.AjouterL.TabIndex = 4;
            this.AjouterL.Text = "Ajouter";
            this.AjouterL.UseVisualStyleBackColor = true;
            // 
            // NouveauLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 192);
            this.Controls.Add(this.AjouterL);
            this.Controls.Add(this.textNumpage);
            this.Controls.Add(this.Numpage);
            this.Controls.Add(this.textAuteur);
            this.Controls.Add(this.Livre);
            this.Name = "NouveauLivre";
            this.Text = "NouveauLivre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Livre;
        private System.Windows.Forms.TextBox textAuteur;
        private System.Windows.Forms.Label Numpage;
        private System.Windows.Forms.TextBox textNumpage;
        private System.Windows.Forms.Button AjouterL;
    }
}