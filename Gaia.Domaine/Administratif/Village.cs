namespace Gaia.Domaine.DecoupageAdministratif
{
    public class Village : Localite
    {
        public SousPrefecture SousPrefecture { get; set; }
        public string NomChef { get; set; }
    }
}