using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP2_Tanguay_Zachary.Models;

namespace TP2_Tanguay_Zachary.ViewModels
{
    public class PageRechercheViewModel
    {
        public CritereRechercheViewModel Criteres { get; set; }

        public List<Enfant> Resultat { get; set; }
    }
}
