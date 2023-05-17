namespace RentACar.BL.Model {
    public class Adres {

        public Adres( string straatNaam , int huisNummer , int? busNummer , string plaats , string postcode ) {
            StraatNaam = straatNaam;
            HuisNummer = huisNummer;
            BusNummer = busNummer;
            Plaats = plaats;
            Postcode = postcode;
        }

        public string StraatNaam { get; set; }
        public int HuisNummer { get; set; }
        public int? BusNummer { get; set; }
        public string Plaats { get; set; }
        public string Postcode { get; set; }

    }
}
