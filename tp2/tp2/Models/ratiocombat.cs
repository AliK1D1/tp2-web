namespace tp2.Models
{
    public class ratiocombat (int victoire, int defaites, int nuls)
    {
        public int Victoires { get; set; }
        public int Defaites { get; set; }
        public int Nuls { get; set; }

        public override string ToString()
        {
            return $"{Victoires}-{Defaites}-{Nuls}";
        }
    }
}
