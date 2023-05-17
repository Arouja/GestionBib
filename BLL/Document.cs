using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Document
    {
        public int Numero { get; set; }
        public string Titre { get; set; }
        public Document() { }
        public Document(int Numero, string Titre)
        {
            this.Numero = Numero;
            this.Titre = Titre;
        }
        public override string ToString()
        {
            return "Titre: " + this.Titre +
                " Numero: " + this.Numero;
        }
    }
}
