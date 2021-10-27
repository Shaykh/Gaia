using System.Collections.Generic;

namespace Gaia.Domaine.DecoupageAdministratif
{
    public class SousPrefecture : Localite
    {
        public Departement Departement { get; set; }
        public ICollection<Village> Villages { get; set; }
    }
}