using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_GestionBiblio
{
    // enfant de doc
    class Livre : Document
    {
        public string Auteur { get; }
        public bool Emprunte { get; set; }

        public Livre(string titre, string auteur) : base(titre)
        {
            Auteur = auteur;
            Emprunte = false;
        }

     
    }
}
