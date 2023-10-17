using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_GestionBiblio
{
    class BD : Document
    {
        public string Auteur { get; }
        public string Dessinateur { get; }

        public BD(string titre, string auteur, string dessinateur) : base(titre)
        {
            Auteur = auteur;
            Dessinateur = dessinateur;
        }
    }
}
