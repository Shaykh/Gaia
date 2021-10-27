using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaia.Domaine.DecoupageAdministratif
{
    public class Departement : Localite
    {
        public Region Region { get; set; }
        public ICollection<SousPrefecture> SousPrefectures { get; set; }
    }
}
