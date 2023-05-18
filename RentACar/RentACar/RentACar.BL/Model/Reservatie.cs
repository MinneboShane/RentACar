namespace RentACar.BL.Model {
    internal class Reservatie {


        public int Nummer { get; set; }
        public DateTime DatumReservering { get; set; }
        public Klant Klant { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime StartTijd { get; set; }
        public double AantalUren { get; set; }
        public decimal EenheidsPrijs { get; set; }
        public List<Wagen> Wagens { get; set; }
        public Arrangement? Arrangement { get; set; }
        public Plaats? Startplaats { get; set; }
        public Plaats? Aankomsplaats { get; set; }

    }
}
