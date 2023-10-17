using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TP5_GestionBiblio
{
    class Bibliotheque
    {
        private List<Adherent> adherents = new List<Adherent>();
        private List<Document> documents = new List<Document>();

        public List<Document> LesDocuments { get { return documents; } }

        public void AjouterAdherent(Adherent ad)
        {
            adherents.Add(ad);
        }

        public void AjouterDocument(Document doc)
        {
            documents.Add(doc);
        }

        public List<Document> ChercherDocument(string texteRecherche)
        {
            return documents.FindAll(d => d.Titre.Contains(texteRecherche));
        }

        public void ListerDocuments()
        {
            foreach (Document doc in documents)
            {
                Console.WriteLine(doc);
            }
        }

        public void ListerResultatsRecherche(List<Document> resultats)
        {
            if (resultats.Count == 0)
            {
                Console.WriteLine("Aucun document trouvé.");
            }
            else
            {
                foreach (Document doc in resultats)
                {
                    Console.WriteLine(doc);
                }
            }
        }
    }
}
