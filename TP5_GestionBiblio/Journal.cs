using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_GestionBiblio
{
    class Journal : Document
    {
        public DateTime DateParution { get; }

        public Journal(string titre, DateTime dateParution) : base(titre)
        {
            DateParution = dateParution;
        }

        public override string ToString()
        {
            return "Journal: " + base.Titre + " (Date de parution: " + DateParution.ToShortDateString() + ")";
        }
    }

}
