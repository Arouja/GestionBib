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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Document> listDoc = new List<Document>();

        public Bibliotheque bibliotheque = new Bibliotheque();

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            if (radioDictionnaire.Checked)
            {
                Dictionnaire d = new Dictionnaire();
                NouveauDictionnaire nd =
                    new NouveauDictionnaire(d);
                if (nd.ShowDialog() == DialogResult.OK)
                {
                    bibliotheque.AddDoc(d);
                }
                listDoc = bibliotheque.
                    AfficherDocuments(SubType.Dictionnaire);
                remplirListe();

            }

            private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
