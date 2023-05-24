using RentACar.BL.Exceptions;

namespace RentACar.BL.Model {
    public class Wagen {

        public Wagen( string merk , string model , string bouwjaar , bool isBeschikbaar ) {
            ZetMerk( merk );
            ZetModel( model );
            ZetBouwjaar( bouwjaar );
            ZetBeschikbaarheid( isBeschikbaar );
        }

        public string Merk { get; set; }
        public string Model { get; set; }
        public string Bouwjaar { get; set; }
        public bool IsBeschikbaar { get; set; }

        public void ZetMerk( string merk ) {
            if ( string.IsNullOrWhiteSpace( merk ) )
                throw new WagenException( "ZetMerk" );
            Merk = merk;
        }

        public void ZetModel( string model ) {
            if ( string.IsNullOrWhiteSpace( model ) )
                throw new WagenException( "ZetModel" );
            Model = model;
        }

        public void ZetBouwjaar( string bouwjaar ) {
            if ( string.IsNullOrWhiteSpace( bouwjaar ) )
                throw new WagenException( "ZetBouwjaar" );
            Bouwjaar = bouwjaar;
        }

        public void ZetBeschikbaarheid( bool isBeschikbaar ) {
            if ( !isBeschikbaar )
                throw new WagenException( "ZetBeschikbaarheid" );
            IsBeschikbaar = isBeschikbaar;
        }
    }
}
