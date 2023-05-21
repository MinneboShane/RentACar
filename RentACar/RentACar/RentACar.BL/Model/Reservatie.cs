using RentACar.BL.Exceptions;

namespace RentACar.BL.Model {
    public class Reservatie {
        System.Globalization.CultureInfo nlBe = new System.Globalization.CultureInfo( "nl-BE" );

        public Reservatie( int reservatienummer , DateTime datumReservering , Klant klant , DateTime startDatum , double aantalUren , decimal eenheidsPrijs , List<Wagen> wagens , List<Arrangement> arrangementen , Plaats startplaats , Plaats aankomsplaats ) {
            ZetReservatienummer( reservatienummer );
            ZetDatumReservering( datumReservering );
            ZetKlant( klant );
            ZetStartDatum( startDatum );
            ZetAantalUren( aantalUren );
            ZetEenheidsprijs( eenheidsPrijs );
            ZetWagens( wagens );
            ZetArrangementen( arrangementen );
            ZetStartplaats( startplaats );
            ZetAankomstplaats( aankomsplaats );
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


        public void ZetReservatienummer( int nummer ) {
            if ( nummer <= 0 )
                throw new ReservatieException( "ZetReservatienummer" );
            Reservatienummer = nummer;
        }

        public void ZetDatumReservering( DateTime datum ) {
            if ( datum == DateTime.MinValue )
                throw new ReservatieException( "ZetDatumReservatie" );

            DateTime moment;
            bool gelukt = DateTime.TryParseExact( datum.ToString() , "dd/MM/yyyy hh:mm" , nlBe , System.Globalization.DateTimeStyles.None , out moment );

            if ( !gelukt ) {
                throw new ReservatieException( "ZetDatumReservatie - parcen niet gelukt" );
            }
            DatumReservering = datum;
        }

        public void ZetKlant( Klant klant ) {
            if ( klant == null )
                throw new ReservatieException( "ZetKlant - is null" );
            if ( Klant == klant )
                throw new ReservatieException( "ZetKlant - zelfde klant" );
            if ( Klant != null ) {
                if ( Klant.HeeftReservatie( this ) )
                    Klant.VerwijderKlant( this );
            }
            if ( !klant.HeeftReservatie( this ) ) {
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

    }
}
