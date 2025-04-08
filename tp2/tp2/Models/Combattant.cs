namespace tp2.Models
{
    public class Combattant
    {
        public int Id { get; set; }

        public int IdCategorie { get; set; }
        public string Nom { get; set; }
        public String Poid { get; set; }
        public bool EstChampion { get; set; }
        public string Description { get; set; }
        public int Reach { get; set; }
        
        public Categories PoidCategorie { get; set; }
        public ratiocombat Ratio { get; set; }
        public string Origine { get; set; }
        public int Precision { get; set; }
        public int VictoiresParKO { get; set; }
        public string ImageUrl { get; set; }

    }
}
