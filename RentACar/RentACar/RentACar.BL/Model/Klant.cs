using RentACar.BL.Exceptions;

namespace RentACar.BL.Model {
    public class Klant {

        internal Klant( string voornaam , string naam , Adres adres , string? btwNummer ) {
            ZetVoornaam( voornaam );
            ZetNaam( naam );
            ZetAdres( adres );
            if ( btwNummer != null )
                ZetBtwNummer( btwNummer );
        }
        internal Klant( string klantnummer , string voornaam , string naam , Adres adres , string? btwNummer ) : this( voornaam , naam , adres , btwNummer ) {
            ZetKlantnummer( klantnummer );
        }

        public string Klantnummer { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public Adres Adres { get; set; }
        public string BtwNummer { get; set; }

        public void ZetKlantnummer( string klantnummer ) {
            if ( string.IsNullOrEmpty( klantnummer ) )
                throw new KlantException( "ZetKlantnummer - is null" );
            Klantnummer = klantnummer.Trim();
        }

        public void ZetVoornaam( string voornaam ) {
            if ( string.IsNullOrWhiteSpace( voornaam ) )
                throw new KlantException( "ZetVoornaam - is null" );
            Voornaam = voornaam.Trim();
        }

        public void ZetNaam( string naam ) {
            if ( string.IsNullOrWhiteSpace( naam ) )
                throw new KlantException( "ZetNaam - is null" );
            Naam = naam.Trim();
        }

        public void ZetAdres( Adres adres ) {
            if ( adres == null )
                throw new KlantException( "ZetAdres - is null" );
            Adres = adres;
        }

        public void ZetBtwNummer( string? btwNummer ) {
            if ( string.IsNullOrWhiteSpace( btwNummer ) )
                throw new KlantException( "ZetBtwNummer - is null" );
            BtwNummer = btwNummer.Trim();
        }

        public void MaakReservatie() {

        }

        public void WijzigReservatie() {

        }

        public void VerwijderReservatie() {

        }


    }
}