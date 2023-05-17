using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Dictionnaire : Document
    {
        private string langue;

        public string Langue
        {
            get { return langue; }
            set { langue = value; }
        }
        private int numtome;

        public int Numtome
        {
            get { return numtome; }
            set { numtome = value; }
        }
       


        public override string ToString()
        {
            return base.ToString() + " Langue: " + Langue + " Num tome: " + Numtome;
        }

        public Dictionnaire(int numero, string titre,
            string langue, int numtome)
            : base(numero, titre)
        {
            Langue = langue;
            Numtome = numtome;
        }

        public Dictionnaire()
        {
        }
    }
}
