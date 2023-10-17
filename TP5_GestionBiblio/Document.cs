using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_GestionBiblio
{
    class Document
    {
        public string Titre { get; }
        //ctor
        public Document(string titre)
        {
            Titre = titre;
        }

        public override string ToString()
        {
            return "Titre: " + Titre;
        }
    }

}
