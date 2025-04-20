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
            
            
            Categories.Add(new Categories() { Id = 1, Nom = "Poids Plume", nombreCombattants=79 ,Poids = 145, ImageCombattantLegende = "~/images/Topuria.jpg", Description= "Les <span class=\"rouge\">poids plumes</span> en UFC sont des combattants pesant entre 136 et 145 livres. Cette catégorie, riche en talents, est célèbre pour sa combinaison de vitesse, de technique et de puissance. Les athlètes de cette division sont souvent parmi les plus dynamiques et explosifs, offrant des combats spectaculaires. Des stars comme Conor McGregor, qui a remporté le titre en 2015, et Ilia Topuria, champion actuel, ont marqué cette catégorie par leurs performances impressionnantes. Leurs styles variés, allant du striking au grappling, rendent chaque affrontement imprévisible et excitant pour les fans. En somme, le poids plume en UFC est synonyme de compétitivité intense et de moments mémorables dans l'histoire du sport. \U0001f94a" });
            Categories.Add(new Categories() { Id = 2, Nom = "Poids Moyen", nombreCombattants= 101, Poids = 185, ImageCombattantLegende = "~/images/alexpeiraacceuil.jpg", Description= "Les <span class=\"rouge\">poids moyens</span> en UFC sont des combattants pesant entre 171 et 185 livres. Cette catégorie est réputée pour sa diversité de styles et sa compétitivité intense. Les combattants de cette division combinent souvent puissance, endurance et technique, rendant leurs combats imprévisibles et passionnants. Des légendes comme Anderson Silva, connu pour son striking exceptionnel et sa longue série de victoires, ont marqué l'histoire de cette catégorie. Plus récemment, Israel Adesanya s'est distingué avec son style unique et ses performances spectaculaires. Les combats de poids moyen offrent souvent des moments mémorables et des retournements de situation inattendus, captivant les fans du monde entier. En somme, cette division incarne parfaitement l'essence de l'arts martiaux mixtes. 🥋" });
            Categories.Add(new Categories() { Id = 3, Nom = "Poids Lourd",nombreCombattants=42 ,Poids = 265, ImageCombattantLegende = "~/images/AcceuilJonJones.jpg", Description= "Les<span class=\"rouge\">poids Lourds</span> en UFC sont des combattants pesant entre 206 et 265 livres. Cette catégorie est synonyme de puissance brute, avec des athlètes capables de finir un combat en un seul coup de poing. Des légendes comme Randy Couture, Cain Velasquez et Stipe Miocic ont marqué l'histoire de cette division avec leurs compétences polyvalentes et leurs performances mémorables. Jon Jones, l'un des plus grands combattants de tous les temps, a également fait une transition réussie dans cette catégorie en 2023, remportant le titre des poids lourds. Sa force, son expérience et son incroyable palmarès en font une figure emblématique de cette division. En somme, la catégorie des poids lourds en UFC incarne la quintessence de la puissance et de l'adrénaline, attirant des fans du monde entier par ses confrontations intenses et imprévisibles. 💥" });
            Combattants.Add(new Combattant() { Id = 1, IdCategorie = 1, Nom = "Ilia Topuria", EstActif=true, Poid = "Poids Plume", EstChampion = true, Description = "Champion actuel", Reach = 69, Origine = "Espagne", Precision = 55, VictoiresParKO = 12, ImageUrl = "/images/topuriach.jpg", Ratio = new ratiocombat(16, 0, 0), Age = 26 });
            Combattants.Add(new Combattant() { Id = 2, IdCategorie = 1, Nom = "Conor McGregor", EstActif=false, Poid = "Poids Plume", EstChampion = false, Description = "Ancien champion", Reach = 74, Origine = "Irlande", Precision = 50, VictoiresParKO = 19, ImageUrl = "/images/conor.jpg", Ratio = new ratiocombat(22, 6, 0), Age = 35 });
            Combattants.Add(new Combattant() { Id = 3, IdCategorie = 2, Nom = "Alex Pereira", EstActif =true ,Poid = "Poids Moyen", EstChampion = true, Description = "Champion actuel", Reach = 79, Origine = "Brésil", Precision = 60, VictoiresParKO = 7, ImageUrl = "/images/alexprc.jpg", Ratio = new ratiocombat(12, 3, 0), Age = 33 });
            Combattants.Add(new Combattant() { Id = 4, IdCategorie = 2, Nom = "Sean Strickland", EstActif =true, Poid = "Poids Moyen", EstChampion = false, Description = "Ancien champion des poids moyens", Reach = 76, Origine = "États-Unis", Precision = 52, VictoiresParKO = 11, ImageUrl = "/images/stricland.jpg", Ratio = new ratiocombat(29, 7, 0), Age = 32 });
            Combattants.Add(new Combattant() { Id = 5, IdCategorie = 2, Nom = "Israel Adesanya", EstActif=true, Poid = "Poids Moyen", EstChampion = false, Description = "Ancien champion des poids moyens", Reach = 80, Origine = "Nouvelle-Zélande", Precision = 58, VictoiresParKO = 16, ImageUrl = "/images/IA.jpg", Ratio = new ratiocombat(24, 5, 0), Age = 34 });
            Combattants.Add(new Combattant() { Id = 6, IdCategorie = 3, Nom = "Daniel Cormier", Poid = "Poids Lourd", EstChampion = false, Description = "Ancien double champion", Reach = 72, Origine = "États-Unis", Precision = 48, VictoiresParKO = 10, ImageUrl = "/images/DC.jpg", Ratio = new ratiocombat(22, 3, 0), Age = 44 });
            Combattants.Add(new Combattant() { Id = 7, IdCategorie = 2, Nom = "Paulo Costa",EstActif= true ,Poid = "Poids Moyen", EstChampion = false, Description = "Contender poids moyen", Reach = 72, Origine = "Brésil", Precision = 49, VictoiresParKO = 11, ImageUrl = "/images/paulocosta.jpg", Ratio = new ratiocombat(14, 4, 0), Age = 31 });
            Combattants.Add(new Combattant() { Id = 8, IdCategorie = 1, Nom = "Alexander Volkanovski", EstActif=true, Poid = "Poids Plume", EstChampion = false, Description = "Ancien champion poids plume", Reach = 71, Origine = "Australie", Precision = 57, VictoiresParKO = 13, ImageUrl = "/images/volk.jpg", Ratio = new ratiocombat(26, 5, 0), Age = 35 });
            Combattants.Add(new Combattant() { Id = 9, IdCategorie = 3, Nom = "Tom Aspinall", EstActif=true, Poid = "Poids Lourd", EstChampion = true, Description = "Champion intérimaire des poids lourds", Reach = 78, Origine = "Angleterre", Precision = 56, VictoiresParKO = 10, ImageUrl = "/images/Aspinall.jpg", Ratio = new ratiocombat(15, 3, 0), Age = 30 });
            Combattants.Add(new Combattant() { Id = 10, IdCategorie = 1, Nom = "Max Holloway", EstActif = true, Poid = "Poids Plume", EstChampion = false, Description = "Ancien champion poids plume", Reach = 69, Origine = "États-Unis", Precision = 59, VictoiresParKO = 10, ImageUrl = "/images/max.jpg", Ratio = new ratiocombat(25, 8, 0), Age = 31 });
            Combattants.Add(new Combattant() { Id = 11, IdCategorie = 1, Nom = "Dustin Poirier", EstActif = false, Poid = "Poids Plume", EstChampion = false, Description = "Contender poids léger", Reach = 72, Origine = "États-Unis", Precision = 54, VictoiresParKO = 14, ImageUrl = "/images/thediamond.jpg", Ratio = new ratiocombat(30, 9, 0), Age = 34 });
            Combattants.Add(new Combattant() { Id = 12, IdCategorie = 1, Nom = "Jose Aldo", EstActif = false, Poid = "Poids Plume", EstChampion = false, Description = "Légende et ancien champion", Reach = 70, Origine = "Brésil", Precision = 51, VictoiresParKO = 17, ImageUrl = "/images/aldo.jpg", Ratio = new ratiocombat(32, 9, 0), Age = 37 });


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
