namespace tp2.Models
{
    public class BaseDeDonnees
    {
        public List<Categories> Categories { get; set; }
        public List<Combattant> Combattants { get; set; }

        public BaseDeDonnees()
        
             
        {
            Categories = new List<Categories>
        {
            new Categories{ Id = 1, Nom = "Poids Plume", Poids = 145, ImageCombattantLegende = "~/images/josealdo.jpg" },
            new Categories { Id = 2, Nom = "Poids Moyen", Poids = 185, ImageCombattantLegende = "~/images/andersonsilva.jpg" },
            new Categories { Id = 3, Nom = "Poids Lourd", Poids=265, ImageCombattantLegende = "~/images/cainvelasquez.jpg" }
        };

            Combattants = new List<Combattant>
        {
            new Combattant { Id = 1, Nom = "Ilia Topuria", Poid = "Poids Plume", EstChampion = true, Description = "Champion actuel", Reach = 69, Origine = "Espagne", Precision = 55, VictoiresParKO = 12, ImageUrl = "~/images/topuria.jpg", Ratio= new ratiocombat(1,2,2) },
            new Combattant { Id = 2, Nom = "Conor McGregor", Poid = "Poids Plume", EstChampion = false, Description = "Ancien champion", Reach = 74, Origine = "Irlande", Precision = 50, VictoiresParKO = 19, ImageUrl = "~/images/conor.jpg" ,Ratio= new ratiocombat(1,2,2) },
            new Combattant { Id = 3, Nom = "Alex Pereira", Poid = "Poids Moyen", EstChampion = true, Description = "Champion actuel", Reach = 79, Origine = "Brésil", Precision = 60, VictoiresParKO = 7, ImageUrl = "~/images/alexpeiraacceuil.jpg",Ratio= new ratiocombat(1,2,2) },
            
        };
        }
    }
    
}
