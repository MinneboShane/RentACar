namespace RentACar.BL.DTO {
    public class KlantInfo {
        public KlantInfo( string klantNummer , string voornaam , string naam , string adres , string? btwNummer ) {
            KlantNummer = klantNummer;
            Voornaam = voornaam;
            Naam = naam;
            Adres = adres;
            BtwNummer = btwNummer;
        }

        public string KlantNummer { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }
        public string BtwNummer { get; set; }

        public override string? ToString() {
            return $"{KlantNummer}, {Voornaam}, {Naam}, {Adres}, {BtwNummer}";
        }
    }
}
