using Gaia.Domaine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaia.Domaine.DecoupageAdministratif
{
    public class Localite : Entite
    {
        public string Libelle { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Superficie { get; set; }
        public int Population { get; set; }
    }
}
