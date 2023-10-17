using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_GestionBiblio
{
    class Adherent
    {
        public string Prenom { get; }
        public string Nom { get; }
        // ma liste 
        private List<Livre> livresEmpruntes = new List<Livre>();

        public Adherent(string prenom, string nom)
        {
            Prenom = prenom;
            Nom = nom;
        }

        public void Emprunter(Livre livre)
        {
            if (livre.Emprunte == false)
            {
                livresEmpruntes.Add(livre);
                livre.Emprunte = true;
            }
        }

        public void Rendre(Livre livre)
        {
            if (livresEmpruntes.Contains(livre))
            {
                livresEmpruntes.Remove(livre);
                livre.Emprunte = false;
            }
        }

        public void ListerLivresEmpruntes()
        {
            foreach (Livre livre in livresEmpruntes)
            {
                Console.WriteLine(livre);
            }
        }
    }
}
