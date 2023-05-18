namespace RentACar.BL.Model {
    internal class Wagen {
        public Wagen( string merk , string type , string bouwjaar ) {
            Merk = merk;
            Type = type;
            Bouwjaar = bouwjaar;
        }

        public string Merk { get; set; }
        public string Type { get; set; }
        public string Bouwjaar { get; set; }
    }
}
