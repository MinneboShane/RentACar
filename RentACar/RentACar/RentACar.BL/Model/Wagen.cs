using RentACar.BL.Exceptions;

namespace RentACar.BL.Model {
    public class Wagen {

        public Wagen( string merk , string type , string bouwjaar ) {
            Merk = merk;
            Type = type;
            Bouwjaar = bouwjaar;
        }

        public string Merk { get; set; }
        public string Type { get; set; }
        public string Bouwjaar { get; set; }

        public void ZetMerk( string merk ) {
            if ( string.IsNullOrWhiteSpace( merk ) )
                throw new WagenException( "ZetMerk" );
            Merk = merk;
        }

        public void ZetType( string type ) {
            if ( string.IsNullOrWhiteSpace( type ) )
                throw new WagenException( "ZetMerk" );
            Type = type;
        }

        public void ZetBouwjaar( string bouwjaar ) {
            if ( string.IsNullOrWhiteSpace( bouwjaar ) )
                throw new WagenException( "ZetBouwjaar" );
        }
    }
}
