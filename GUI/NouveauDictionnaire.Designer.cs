namespace GUI
{
    partial class NouveauDictionnaire
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
            this.Langue = new System.Windows.Forms.Label();
            this.Numtome = new System.Windows.Forms.Label();
            this.textLangue = new System.Windows.Forms.TextBox();
            this.textNumtome = new System.Windows.Forms.TextBox();
            this.AjouterD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Langue
            // 
            this.Langue.AutoSize = true;
            this.Langue.Location = new System.Drawing.Point(18, 28);
            this.Langue.Name = "Langue";
            this.Langue.Size = new System.Drawing.Size(49, 13);
            this.Langue.TabIndex = 0;
            this.Langue.Text = "Langue: ";
            // 
            // Numtome
            // 
            this.Numtome.AutoSize = true;
            this.Numtome.Location = new System.Drawing.Point(18, 75);
            this.Numtome.Name = "Numtome";
            this.Numtome.Size = new System.Drawing.Size(55, 13);
            this.Numtome.TabIndex = 1;
            this.Numtome.Text = "Numtome:";
            // 
            // textLangue
            // 
            this.textLangue.Location = new System.Drawing.Point(121, 25);
            this.textLangue.Name = "textLangue";
            this.textLangue.Size = new System.Drawing.Size(116, 20);
            this.textLangue.TabIndex = 2;
            // 
            // textNumtome
            // 
            this.textNumtome.Location = new System.Drawing.Point(121, 75);
            this.textNumtome.Name = "textNumtome";
            this.textNumtome.Size = new System.Drawing.Size(154, 20);
            this.textNumtome.TabIndex = 3;
            // 
            // AjouterD
            // 
            this.AjouterD.Location = new System.Drawing.Point(143, 165);
            this.AjouterD.Name = "AjouterD";
            this.AjouterD.Size = new System.Drawing.Size(146, 42);
            this.AjouterD.TabIndex = 4;
            this.AjouterD.Text = "Ajouter";
            this.AjouterD.UseVisualStyleBackColor = true;
            // 
            // Dictionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 238);
            this.Controls.Add(this.AjouterD);
            this.Controls.Add(this.textNumtome);
            this.Controls.Add(this.textLangue);
            this.Controls.Add(this.Numtome);
            this.Controls.Add(this.Langue);
            this.Name = "Dictionnaire";
            this.Text = "Dictionnaire";
            this.Load += new System.EventHandler(this.Dictionnaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Langue;
        private System.Windows.Forms.Label Numtome;
        private System.Windows.Forms.TextBox textLangue;
        private System.Windows.Forms.TextBox textNumtome;
        private System.Windows.Forms.Button AjouterD;
    }
}