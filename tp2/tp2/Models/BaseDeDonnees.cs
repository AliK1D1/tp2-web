using System.Linq;


namespace tp2.Models
{
    public class BaseDeDonnees
    {
        public List<Categories> Categories { get; set; }
        public List<Combattant> Combattants { get; set; }

        public BaseDeDonnees()        
        {
            Categories = new List<Categories>();
            Combattants = new List<Combattant>();
            
            
            Categories.Add(new Categories() { Id = 1, Nom = "Poids Plume", Poids = 145, ImageCombattantLegende = "~/images/Topuria.jpg", Description= "Les <span class=\"rouge\">poids plumes</span> en UFC sont des combattants pesant entre 136 et 145 livres. Cette catégorie, riche en talents, est célèbre pour sa combinaison de vitesse, de technique et de puissance. Les athlètes de cette division sont souvent parmi les plus dynamiques et explosifs, offrant des combats spectaculaires. Des stars comme Conor McGregor, qui a remporté le titre en 2015, et Ilia Topuria, champion actuel, ont marqué cette catégorie par leurs performances impressionnantes. Leurs styles variés, allant du striking au grappling, rendent chaque affrontement imprévisible et excitant pour les fans. En somme, le poids plume en UFC est synonyme de compétitivité intense et de moments mémorables dans l'histoire du sport. \U0001f94a" });
            Categories.Add(new Categories() { Id = 2, Nom = "Poids Moyen", Poids = 185, ImageCombattantLegende = "~/images/andersonsilva.jpg" });
            Categories.Add(new Categories() { Id = 3, Nom = "Poids Lourd", Poids = 265, ImageCombattantLegende = "~/images/cainvelasquez.jpg" });
            Combattants.Add(new Combattant() { Id = 1, IdCategorie = 1, Nom = "Ilia Topuria", Poid = "Poids Plume", EstChampion = true, Description = "Champion actuel", Reach = 69, Origine = "Espagne", Precision = 55, VictoiresParKO = 12, ImageUrl = "/images/topuriach.jpg", Ratio = new ratiocombat(16, 0, 0), Age = 26 });
            Combattants.Add(new Combattant() { Id = 2, IdCategorie = 1, Nom = "Conor McGregor", Poid = "Poids Plume", EstChampion = false, Description = "Ancien champion", Reach = 74, Origine = "Irlande", Precision = 50, VictoiresParKO = 19, ImageUrl = "/images/conor.jpg", Ratio = new ratiocombat(22, 6, 0), Age = 35 });
            Combattants.Add(new Combattant() { Id = 3, IdCategorie = 2, Nom = "Alex Pereira", Poid = "Poids Moyen", EstChampion = true, Description = "Champion actuel", Reach = 79, Origine = "Brésil", Precision = 60, VictoiresParKO = 7, ImageUrl = "/images/alexprc.jpg", Ratio = new ratiocombat(12, 3, 0), Age = 33 });
            Combattants.Add(new Combattant() { Id = 4, IdCategorie = 2, Nom = "Sean Strickland", Poid = "Poids Moyen", EstChampion = false, Description = "Ancien champion des poids moyens", Reach = 76, Origine = "États-Unis", Precision = 52, VictoiresParKO = 11, ImageUrl = "/images/stricland.jpg", Ratio = new ratiocombat(29, 7, 0), Age = 32 });
            Combattants.Add(new Combattant() { Id = 5, IdCategorie = 2, Nom = "Israel Adesanya", Poid = "Poids Moyen", EstChampion = false, Description = "Ancien champion des poids moyens", Reach = 80, Origine = "Nouvelle-Zélande", Precision = 58, VictoiresParKO = 16, ImageUrl = "/images/IA.jpg", Ratio = new ratiocombat(24, 5, 0), Age = 34 });
            Combattants.Add(new Combattant() { Id = 6, IdCategorie = 3, Nom = "Daniel Cormier", Poid = "Poids Lourd", EstChampion = false, Description = "Ancien double champion", Reach = 72, Origine = "États-Unis", Precision = 48, VictoiresParKO = 10, ImageUrl = "/images/DC.jpg", Ratio = new ratiocombat(22, 3, 0), Age = 44 });
            Combattants.Add(new Combattant() { Id = 7, IdCategorie = 2, Nom = "Paulo Costa", Poid = "Poids Moyen", EstChampion = false, Description = "Contender poids moyen", Reach = 72, Origine = "Brésil", Precision = 49, VictoiresParKO = 11, ImageUrl = "/images/paulocosta.jpg", Ratio = new ratiocombat(14, 4, 0), Age = 31 });
            Combattants.Add(new Combattant() { Id = 8, IdCategorie = 1, Nom = "Alexander Volkanovski", Poid = "Poids Plume", EstChampion = false, Description = "Ancien champion poids plume", Reach = 71, Origine = "Australie", Precision = 57, VictoiresParKO = 13, ImageUrl = "/images/volk.jpg", Ratio = new ratiocombat(26, 5, 0), Age = 35 });
            Combattants.Add(new Combattant() { Id = 9, IdCategorie = 3, Nom = "Tom Aspinall", Poid = "Poids Lourd", EstChampion = true, Description = "Champion intérimaire des poids lourds", Reach = 78, Origine = "Angleterre", Precision = 56, VictoiresParKO = 10, ImageUrl = "/images/Aspinall.jpg", Ratio = new ratiocombat(15, 3, 0), Age = 30 });
            Combattants.Add(new Combattant() { Id = 10, IdCategorie = 1, Nom = "Max Holloway", Poid = "Poids Plume", EstChampion = false, Description = "Ancien champion poids plume", Reach = 69, Origine = "États-Unis", Precision = 59, VictoiresParKO = 10, ImageUrl = "/images/max.jpg", Ratio = new ratiocombat(25, 8, 0), Age = 31 });
            Combattants.Add(new Combattant() { Id = 11, IdCategorie = 1, Nom = "Dustin Poirier", Poid = "Poids Plume", EstChampion = false, Description = "Contender poids léger", Reach = 72, Origine = "États-Unis", Precision = 54, VictoiresParKO = 14, ImageUrl = "/images/thediamond.jpg", Ratio = new ratiocombat(30, 9, 0), Age = 34 });
            Combattants.Add(new Combattant() { Id = 12, IdCategorie = 1, Nom = "Jose Aldo", Poid = "Poids Plume", EstChampion = false, Description = "Légende et ancien champion", Reach = 70, Origine = "Brésil", Precision = 51, VictoiresParKO = 17, ImageUrl = "/images/aldo.jpg", Ratio = new ratiocombat(32, 9, 0), Age = 37 });


            foreach (var c in Categories)
            {
                c.Combattants = new List<Combattant>();
                c.Combattants.AddRange(Combattants.Where(e => e.IdCategorie == c.Id));

               // c.Combattants = new List<Combattant>();

                
                //var combatDansCategorie = Combattants.Where(e => e.IdCategorie == c.Id).ToList();
                //c.Combattants.AddRange(combatDansCategorie);
            }

            foreach (var c in Combattants)
            {
                c.PoidCategorie = c.PoidCategorie = Categories.Where(x => x.Id == c.IdCategorie).Single();
            }


        }

    }
    
}
