using RentACar.BL.Exceptions;

namespace RentACar.BL.Model {
    public class Reservatie {
        public Reservatie( int reservatienummer , DateTime datumReservering , Klant klant , DateTime startDatum , TimeSpan startTijd , double aantalUren , decimal eenheidsPrijs , List<Wagen> wagens , Arrangement arrangement , Plaats startplaats , Plaats aankomsplaats ) {
            ZetReservatienummer( reservatienummer );
            ZetDatumReservering( datumReservering );
            ZetKlant( klant );
            ZetStartDatum( startDatum );
            ZetStartTijd( startTijd );
            ZetAantalUren( aantalUren );
            ZetEenheidsprijs( eenheidsPrijs );
            ZetWagens( wagens );
            ZetArrangement( arrangement );
            ZetStartplaats( startplaats );
            ZetAankomstplaats( aankomsplaats );
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

        public void ZetReservatienummer( int nummer ) {
            if ( nummer <= 0 )
                throw new ReservatieException( "ZetReservatienummer" );
            Reservatienummer = nummer;
        }

        public void ZetDatumReservering( DateTime datum ) {
            if ( datum == DateTime.MinValue )
                throw new ReservatieException( "ZetDatumReservatie" );
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
            StartDatum = startdatum;
        }

        public void ZetStartTijd( TimeSpan startTijd ) {
            if ( StartTijd == TimeSpan.Zero )
                throw new ReservatieException( "ZetStartTijd" );
            StartTijd = startTijd;
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

        public void ZetArrangement( Arrangement arrangement ) {
            if ( arrangement == null )
                throw new ReservatieException( "ZetArrangement" );
            Arrangement = arrangement;
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
        }

    }
}
