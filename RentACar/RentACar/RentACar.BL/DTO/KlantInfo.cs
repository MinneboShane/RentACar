namespace RentACar.BL.DTO {
    public class KlantInfo {
        public KlantInfo( string klantnummer , string voornaam , string naam , string straat , int huisnummer , int? busnummer , string gemeente , string postcode , string btwNummer ) {
            Klantnummer = klantnummer;
            Voornaam = voornaam;
            Naam = naam;
            Straat = straat;
            Huisnummer = huisnummer;
            Busnummer = busnummer;
            Gemeente = gemeente;
            Postcode = postcode;
            BtwNummer = btwNummer;
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

        public override string? ToString() {
            return $"{Klantnummer}, {Voornaam}, {Naam}, {Straat}, {Huisnummer}, {Busnummer}, {Gemeente}, {Postcode}, {BtwNummer}";
        }
    }
}
