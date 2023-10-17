using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_GestionBiblio
{
    class Dictionnaire : Document
    {
        public Dictionnaire(string titre, string auteur) : base(titre)
        {
            Auteur = auteur;
        }

        public override string ToString()
        {
            return "Dictionnaire: " + base.Titre + " (Auteur: " + Auteur + ")";
        }
    }
