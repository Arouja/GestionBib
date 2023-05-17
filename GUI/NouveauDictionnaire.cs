using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class NouveauDictionnaire : Form
    {
        public Dictionnaire dictionnaire;
        public NouveauDictionnaire(Dictionnaire a)
        {
            InitializeComponent();
            this.dictionnaire = a;
        }

        private void AjouterD_Click(object sender, EventArgs e)
        {
            dictionnaire.Numero = int.Parse(textNumero.Text);
            dictionnaire.Titre = textTitre.Text;
            dictionnaire.Langue = string.Parse(textLangue.Text);
            dictionnaire.Numtome = int.Parse(textNumtome.Text);
            this.Close();
        }

        private void Dictionnaire_Load(object sender, EventArgs e)
        {

        }
    }
}
