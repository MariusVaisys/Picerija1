namespace Picerija.Models
{
    public class UzsakymoInfo
    {
        public int UzsakymoInfoId  { get; set; }
        public int UzsakymoId { get; set; }
        public int PicaId { get; set; }
        public int Kiekis { get; set; }
        public decimal Kaina { get; set; }
        public Pica Pica { get; set; }
        public Uzsakymas Uzsakymas { get; set; }
    }
}