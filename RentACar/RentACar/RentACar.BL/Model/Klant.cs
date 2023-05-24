using RentACar.BL.Exceptions;

namespace RentACar.BL.Model {
    public class Klant {

        public Klant( string klantnummer , string voornaam , string naam , string straat , int huisnummer , int? busnummer , string gemeente , string postcode , string btwNummer ) {
            ZetKlantnummer( klantnummer );
            ZetVoornaam( voornaam );
            ZetNaam( naam );
            ZetStraat( straat );
            ZetHuisnummer( huisnummer );
            if ( busnummer != null )
                ZetBusnummer( busnummer );
            ZetGemeente( gemeente );
            ZetPostcode( postcode );
            if ( btwNummer != null )
                ZetBtwNummer( btwNummer );
        }

        public string Klantnummer { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public string Straat { get; set; }
        public int Huisnummer { get; set; }
        public int? Busnummer { get; set; }
        public string Gemeente { get; set; }
        public string Postcode { get; set; }
        public string BtwNummer { get; set; }
        private List<Reservatie> _reservaties = new List<Reservatie>();



        public bool HeeftReservatie { get; set; }

        public IReadOnlyList<Reservatie> Reservaties() {
            return _reservaties.AsReadOnly();
        }

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

        public void ZetStraat( string straat ) {
            if ( string.IsNullOrWhiteSpace( straat ) )
                throw new KlantException( "ZetStraat - is null" );
            Straat = straat.Trim();
        }

        public void ZetHuisnummer( int nummer ) {
            if ( nummer <= 0 )
                throw new KlantException( "ZetHuisnummer" );
            Huisnummer = nummer;
        }

        public void ZetBusnummer( int? busnummer ) {
            if ( !busnummer.HasValue && busnummer <= 0 )
                throw new KlantException( "ZetBusnummer" );
            Busnummer = busnummer;
        }

        public void ZetGemeente( string gemeente ) {
            if ( string.IsNullOrWhiteSpace( gemeente ) )
                throw new KlantException( "ZetGemeente" );
            Gemeente = gemeente.Trim();
        }

        public void ZetPostcode( string postcode ) {
            if ( string.IsNullOrWhiteSpace( postcode ) )
                throw new KlantException( "ZetPostcode" );
            Postcode = postcode.Trim();
        }

        public void ZetBtwNummer( string? btwNummer ) {
            if ( string.IsNullOrWhiteSpace( btwNummer ) )
                throw new KlantException( "ZetBtwNummer - is null" );
            BtwNummer = btwNummer.Trim();
        }

    }
}