using RentACar.BL.Exceptions;

namespace RentACar.BL.Model {
    public class Plaats {

        public Plaats( string plaatsnaam ) {
            ZetPlaatsnaam( plaatsnaam );
        }

        public string Plaatsnaam { get; set; }

        public void ZetPlaatsnaam( string plaatsnaam ) {
            if ( plaatsnaam == null )
                throw new PlaatsException( "ZetPlaatsnaam" );
        }
    }
}
