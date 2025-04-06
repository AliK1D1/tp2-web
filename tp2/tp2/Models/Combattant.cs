namespace tp2.Models
{
    public class Combattant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Poid { get; set; }
        public bool EstChampion { get; set; }
        public string Description { get; set; }
        public int Reach { get; set; }
        public ratiocombat Ratio { get; set; }
        public string Origine { get; set; }
        public int Precision { get; set; }
        public int VictoiresParKO { get; set; }
        public string ImageUrl { get; set; }

    }
}
