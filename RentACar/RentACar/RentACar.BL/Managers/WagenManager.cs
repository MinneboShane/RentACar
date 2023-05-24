using RentACar.BL.Exceptions;
using RentACar.BL.Interfaces;
using RentACar.BL.Model;

namespace RentACar.BL.Managers {
    public class WagenManager {

        private IWagenRepository repo;

        public Wagen RegistreerWagen( string merk , string type , string bouwjaar , bool isBeschikbaar ) {

            try {
                Wagen wagen = new Wagen( merk , type , bouwjaar , isBeschikbaar );

                if ( !repo.BestaatWagen( wagen ) ) {
                    wagen = repo.SchrijfWagenInDB( wagen );
                    return wagen;
                } else
                    throw new WagenManagerException( "RegistreerWagen - wagen bestaat al" );

            } catch ( WagenManagerException ) {

                throw;
            } catch ( Exception e ) {
                throw new WagenManagerException( "RegistreerWagen" , e );
            }
        }

        public void UpdateBeschikbaarheid( Wagen nieuweWagen ) {
            if ( nieuweWagen == null )
                throw new WagenManagerException( "UpdateWagen - wagen is null" );

            try {

                if ( repo.BestaatWagen( nieuweWagen ) ) {

                    Wagen wagen = repo.SelecteerWagen( nieuweWagen );
                    bool changed = false;

                    if ( wagen.IsBeschikbaar != nieuweWagen.IsBeschikbaar ) {
                        wagen.ZetBeschikbaarheid( nieuweWagen.IsBeschikbaar );
                        changed = true;
                    }

                    if ( !changed )
                        throw new WagenManagerException( "UpdateWagen - no changes" );

                    repo.UpdateBeschikbaarheid( nieuweWagen );
                } else
                    throw new WagenManagerException( "UpdateWagen - wagen niet gevonden" );

            } catch ( WagenManagerException ) {

                throw;
            } catch ( Exception e ) {

                throw new WagenManagerException( "UpdateWagen" , e );
            }
        }

        public IReadOnlyList<Wagen> SelecteerWagens() {
            try {

                return repo.SelecteerWagens();

            } catch ( WagenManagerException ) {

                throw;
            } catch ( Exception e ) {

                throw new WagenManagerException( "SelecteerWagens" , e );
            }
        }

    }
}
