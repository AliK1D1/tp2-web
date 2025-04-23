namespace tp2.ViewModels
{
    public class CritereRechercheViewModel
    {
        public string Champ { get; set; }
        public bool PoidLourd { get; set; }
        public bool PoidMoyen { get; set; }
        public bool PoidPlume { get; set; }
        public int min { get; set; }
        public int max { get; set; }
        public string MotCles { get; set; }
    }
}
