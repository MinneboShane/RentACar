using RentACar.BL.Exceptions;

namespace RentACar.BL.Model {
    public class Adres {

        public Adres( string straatnaam , int huisnummer , int? busnummer , string plaats , string postcode ) {
            Straatnaam = straatnaam;
            Huisnummer = huisnummer;
            Busnummer = busnummer;
            Plaats = plaats;
            Postcode = postcode;
        }

        public string Straatnaam { get; set; }
        public int Huisnummer { get; set; }
        public int? Busnummer { get; set; }
        public string Plaats { get; set; }
        public string Postcode { get; set; }

        public void ZetStraatnaam( string straatnaam ) {
            if ( string.IsNullOrWhiteSpace( Straatnaam ) )
                throw new AdresException( "ZetStraatnaam)" );
        }
    }
}
