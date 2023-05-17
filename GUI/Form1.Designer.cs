namespace GUI
{
    partial class Form1
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
            this.radioLivre = new System.Windows.Forms.RadioButton();
            this.radioDictionnaire = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1Ajout = new System.Windows.Forms.Button();
            this.button1Supprimer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioLivre
            // 
            this.radioLivre.AutoSize = true;
            this.radioLivre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioLivre.ForeColor = System.Drawing.SystemColors.Control;
            this.radioLivre.Location = new System.Drawing.Point(3, 3);
            this.radioLivre.Name = "radioLivre";
            this.radioLivre.Size = new System.Drawing.Size(48, 17);
            this.radioLivre.TabIndex = 0;
            this.radioLivre.TabStop = true;
            this.radioLivre.Text = "Livre";
            this.radioLivre.UseVisualStyleBackColor = false;
            // 
            // radioDictionnaire
            // 
            this.radioDictionnaire.AutoSize = true;
            this.radioDictionnaire.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioDictionnaire.ForeColor = System.Drawing.SystemColors.Control;
            this.radioDictionnaire.Location = new System.Drawing.Point(57, 3);
            this.radioDictionnaire.Name = "radioDictionnaire";
            this.radioDictionnaire.Size = new System.Drawing.Size(81, 17);
            this.radioDictionnaire.TabIndex = 1;
            this.radioDictionnaire.TabStop = true;
            this.radioDictionnaire.Text = "Dictionnaire";
            this.radioDictionnaire.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 212);
            this.listBox1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Controls.Add(this.radioLivre);
            this.flowLayoutPanel1.Controls.Add(this.radioDictionnaire);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 38);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel2.Controls.Add(this.button1Ajout);
            this.flowLayoutPanel2.Controls.Add(this.button1Supprimer);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 269);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(240, 38);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(436, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mon Document";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1Ajout
            // 
            this.button1Ajout.Location = new System.Drawing.Point(3, 3);
            this.button1Ajout.Name = "button1Ajout";
            this.button1Ajout.Size = new System.Drawing.Size(58, 23);
            this.button1Ajout.TabIndex = 6;
            this.button1Ajout.Text = "Ajouter";
            this.button1Ajout.UseVisualStyleBackColor = true;
            this.button1Ajout.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1Supprimer
            // 
            this.button1Supprimer.Location = new System.Drawing.Point(67, 3);
            this.button1Supprimer.Name = "button1Supprimer";
            this.button1Supprimer.Size = new System.Drawing.Size(64, 23);
            this.button1Supprimer.TabIndex = 6;
            this.button1Supprimer.Text = "Supprimer";
            this.button1Supprimer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(249, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 212);
            this.panel1.TabIndex = 6;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(249, 275);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(376, 36);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Details";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Titre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioLivre;
        private System.Windows.Forms.RadioButton radioDictionnaire;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Ajout;
        private System.Windows.Forms.Button button1Supprimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

