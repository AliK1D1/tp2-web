namespace tp2.Models
{
    public class Categories
    {
        public int Id { get; set; }

        public string Nom { get; set; } 

        public List<Combattant> Combattants { get; set; }
        public int Poids { get; set; }


        public int nombreCombattants { get; set; }
        public String Description { get; set; }
        public string ImageCombattantLegende { get; set; } 
    }
}
