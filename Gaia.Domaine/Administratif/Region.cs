using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaia.Domaine.DecoupageAdministratif
{
    public class Region : Localite
    {
        public ICollection<Departement> Departements { get; set; }
    }
}
