using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Bibliotheque
    {
        public List<Document> Docs { get; set; }
        private string reference;

        public Bibliotheque()
        {
            Docs = new List<Document>();
        }

        public Bibliotheque(string reference)
        {
            Reference = reference;
            Docs = new List<Document>();
        }

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public string AddDoc(Document doc)
        {
            try
            {
                Docs.Add(doc);

                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        public Document GetDoc(int numero)
        {
            foreach (var item in Docs)
            {
                if (item.Numero == numero)
                    return item;
            }
            return null;

        }

        public string DeleteDoc(int numero)
        {
            try
            {

                Document doc = GetDoc(numero);
                if (doc != null)
                    Docs.Remove(doc);
                return "";

            }

            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        public int GetIndexDoc(Document d1)
        {
            for (int i = 0; i < Docs.Count; i++)
            {
                if (Docs[i].Numero ==
                    d1.Numero)
                    return i;
            }
            return -1;

        }

        public string UpdateDoc(Document doc)
        {
            try
            {

                int pos = GetIndexDoc(doc);
                if (pos != -1)
                {
                    Docs[pos] = doc;
                }
                else
                {
                    return "Document not exist";
                }
                return "";

            }



            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        public List<Document> AfficherDocuments
            (SubType soustype)
        {
            List<Document> temp = new List<Document>();
            switch (soustype)
            {
                case SubType.Livre:
                    foreach (Document a in Docs)
                    {
                        if (a is Livre)
                            temp.Add(a);
                    }
                    break;
                case SubType.Dictionnaire:
                    foreach (Document a in Docs)
                    {
                        if (a is Dictionnaire)
                            temp.Add(a);
                    }
                    break;
            }
            return temp;
        }

    }

    public enum SubType
    {
        Livre, Dictionnaire
    }
}
