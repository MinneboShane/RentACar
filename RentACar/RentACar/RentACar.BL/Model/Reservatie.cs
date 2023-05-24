using RentACar.BL.Exceptions;

namespace RentACar.BL.Model {
    public class Reservatie {
        System.Globalization.CultureInfo nlBe = new System.Globalization.CultureInfo( "nl-BE" );

        public Reservatie( int reservatienummer , DateTime datumReservering , Klant klant , DateTime startDatum , double aantalUren , decimal eenheidsPrijs , List<Wagen> wagens , List<Arrangement> arrangementen , Plaats startplaats , Plaats aankomsplaats , decimal subtotaalExBtw , decimal subtotaalInBtw , decimal totaalExBtw , decimal totaalInBtw ) {
            ZetReservatienummer( reservatienummer );
            ZetDatumReservering();
            ZetKlant( klant );
            ZetStartDatum( startDatum );
            ZetAantalUren( aantalUren );
            ZetEenheidsprijs( eenheidsPrijs );
            ZetWagens( wagens );
            ZetArrangementen( arrangementen );
            ZetStartplaats( startplaats );
            ZetAankomstplaats( aankomsplaats );
            ZetSubtotaalExBtw( subtotaalExBtw );
            ZetSubtotaalInBtw( subtotaalInBtw );
            ZetTotaalExBtw( totaalExBtw );
            ZetTotaalInBtw( totaalInBtw );
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


        public void ZetReservatienummer( int nummer ) {
            if ( nummer <= 0 )
                throw new ReservatieException( "ZetReservatienummer" );
            Reservatienummer = nummer;
        }

        public void ZetDatumReservering() {
            DatumReservering = DateTime.Now;
        }

        public void ZetKlant( Klant klant ) {
            if ( klant == null )
                throw new ReservatieException( "ZetKlant - is null" );
            if ( Klant == klant )
                throw new ReservatieException( "ZetKlant - zelfde klant" );
            if ( Klant != null ) {
                if ( Klant.HeeftReservatie )
                    throw new ReservatieException( "ZetKlant - klant heeft al een reservatie" );
                else
                    Klant = klant;
            }


        }

        public void ZetStartDatum( DateTime startdatum ) {

            if ( startdatum == DateTime.MinValue )
                throw new ReservatieException( "ZetStartDatum" );
            DateTime moment;
            bool gelukt = DateTime.TryParseExact( startdatum.ToString() , "dd/MM/yyyy hh:mm" , nlBe , System.Globalization.DateTimeStyles.None , out moment );

            if ( !gelukt ) {
                throw new ReservatieException( "ZetStartdatum - parcen niet gelukt" );
            }

            StartDatum = moment;
        }

        public void ZetAantalUren( double uren ) {
            if ( uren <= 0 )
                throw new ReservatieException( "ZtAantalUren" );
            AantalUren = uren;
        }

        public void ZetEenheidsprijs( decimal prijs ) {
            if ( prijs <= 0 )
                throw new ReservatieException( "ZetEenheidsprijs" );
            EenheidsPrijs = prijs;
        }

        public void ZetArrangementen( List<Arrangement> arrangementen ) {
            if ( arrangementen.Count == 0 )
                throw new ReservatieException( "ZetArrangementen" );
            Arrangementen = arrangementen;
        }

        public void ZetStartplaats( Plaats plaats ) {
            if ( plaats == null )
                throw new ReservatieException( "ZetStartplaats" );
            Startplaats = plaats;
        }
        public void ZetAankomstplaats( Plaats plaats ) {
            if ( plaats == null )
                throw new ReservatieException( "ZetAankomstplaats" );
            Aankomsplaats = plaats;
        }

        public void ZetWagens( List<Wagen> wagens ) {
            if ( wagens.Count == 0 )
                throw new ReservatieException( "ZetWagens" );
            Wagens = wagens;
        }

        public void ZetSubtotaalExBtw( decimal subExBtw ) {
            if ( subExBtw <= 0 )
                throw new ReservatieException( "ZetSubtotaalExBtw" );
            SubtotaalExBtw = subExBtw;
        }

        public void ZetSubtotaalInBtw( decimal subInBtw ) {
            if ( subInBtw <= 0 )
                throw new ReservatieException( "ZetSubtotaalInBtw" );
            SubtotaalInBtw = subInBtw;
        }

        public void ZetTotaalExBtw( decimal totExBtw ) {
            if ( totExBtw <= 0 )
                throw new ReservatieException( "ZetTotaalExBtw" );
            TotaalExBtw = totExBtw;
        }

        public void ZetTotaalInBtw( decimal totInBtw ) {
            if ( totInBtw <= 0 )
                throw new ReservatieException( "ZetTotaalInBtw" );
            TotaalInBtw = totInBtw;
        }

    }
}