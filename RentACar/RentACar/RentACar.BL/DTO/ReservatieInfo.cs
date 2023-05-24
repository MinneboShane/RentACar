using RentACar.BL.Model;

namespace RentACar.BL.DTO {
    public class ReservatieInfo {

        public ReservatieInfo( int reservatienummer , DateTime datumReservering , Klant klant , DateTime startDatum , double aantalUren , decimal eenheidsPrijs , List<Wagen> wagens , List<Arrangement> arrangementen , Plaats startplaats , Plaats aankomsplaats , decimal subtotaalExBtw , decimal subtotaalInBtw , decimal totaalExBtw , decimal totaalInBtw ) {
            Reservatienummer = reservatienummer;
            DatumReservering = datumReservering;
            Klant = klant;
            StartDatum = startDatum;
            AantalUren = aantalUren;
            EenheidsPrijs = eenheidsPrijs;
            Wagens = wagens;
            Arrangementen = arrangementen;
            Startplaats = startplaats;
            Aankomsplaats = aankomsplaats;
            SubtotaalExBtw = subtotaalExBtw;
            SubtotaalInBtw = subtotaalInBtw;
            TotaalExBtw = totaalExBtw;
            TotaalInBtw = totaalInBtw;
        }

        public int Reservatienummer { get; set; }
        public DateTime DatumReservering { get; set; }
        public Klant Klant { get; set; }
        public DateTime StartDatum { get; set; }
        public double AantalUren { get; set; }
        public decimal EenheidsPrijs { get; set; }
        public List<Wagen> Wagens { get; set; }
        public List<Arrangement> Arrangementen { get; set; }
        public Plaats Startplaats { get; set; }
        public Plaats Aankomsplaats { get; set; }
        public decimal SubtotaalExBtw { get; set; }
        public decimal SubtotaalInBtw { get; set; }
        public decimal TotaalExBtw { get; set; }
        public decimal TotaalInBtw { get; set; }

        public override string? ToString() {
            return $"{Reservatienummer}, {DatumReservering}, {Klant}, {StartDatum}, {AantalUren}, {EenheidsPrijs}, {Wagens}, {Arrangementen}, {Startplaats}, {Aankomsplaats}, {SubtotaalExBtw}, {SubtotaalInBtw}, {TotaalExBtw}, {TotaalInBtw}";
        }
    }
}
