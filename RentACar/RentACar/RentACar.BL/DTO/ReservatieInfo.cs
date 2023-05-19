using RentACar.BL.Model;

namespace RentACar.BL.DTO {
    public class ReservatieInfo {
        public ReservatieInfo( int reservatienummer , DateTime datumReservering , Klant klant , DateTime startDatum , TimeSpan startTijd , double aantalUren , decimal eenheidsPrijs , List<Wagen> wagens , Arrangement arrangement , Plaats startplaats , Plaats aankomsplaats ) {
            Reservatienummer = reservatienummer;
            DatumReservering = datumReservering;
            Klant = klant;
            StartDatum = startDatum;
            StartTijd = startTijd;
            AantalUren = aantalUren;
            EenheidsPrijs = eenheidsPrijs;
            Wagens = wagens;
            Arrangement = arrangement;
            Startplaats = startplaats;
            Aankomsplaats = aankomsplaats;
        }

        public int Reservatienummer { get; set; }
        public DateTime DatumReservering { get; set; }
        public Klant Klant { get; set; }
        public DateTime StartDatum { get; set; }
        public TimeSpan StartTijd { get; set; }
        public double AantalUren { get; set; }
        public decimal EenheidsPrijs { get; set; }
        public List<Wagen> Wagens { get; set; }
        public Arrangement Arrangement { get; set; }
        public Plaats Startplaats { get; set; }
        public Plaats Aankomsplaats { get; set; }

        public override string? ToString() {
            return $"{Reservatienummer}, {DatumReservering}, {Klant}, {StartDatum}, {StartTijd}, {AantalUren}, {EenheidsPrijs}, {Wagens}, {Arrangement}, {Startplaats}, {Aankomsplaats}";
        }
    }
}
