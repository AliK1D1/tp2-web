namespace tp2.Models
{
    public class ratiocombat 
    {
        public ratiocombat(int victoire, int defaites, int nuls) {
            Victoires = victoire;
            Defaites = defaites;
            Nuls = nuls;
        }
        public int Victoires { get; set; }
        public int Defaites { get; set; }
        public int Nuls { get; set; }
        
        public override string ToString()
        {
            return $"{Victoires}-{Defaites}-{Nuls}";
        }
    }
}
