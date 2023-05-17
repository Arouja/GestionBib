using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Livre : Document
    {
        private string auteur;

        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }
        private int numpage;

        public int Numpage
        {
            get { return numpage; }
            set { numpage = value; }
        }


        public override string ToString()
        {
            return base.ToString() + " Auteur: " + Auteur + " Num page: " + Numpage;
        }

        public Livre(int numero, string titre, string auteur, int numpage)
            : base(numero, titre)
        {
            Auteur = auteur;
            Numpage = numpage;
        }

        public Livre()
        {
        }
    }
}
