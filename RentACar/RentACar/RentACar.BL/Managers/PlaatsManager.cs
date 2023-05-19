using RentACar.BL.Exceptions;
using RentACar.BL.Interfaces;
using RentACar.BL.Model;

namespace RentACar.BL.Managers {
    public class PlaatsManager {

        private IPlaatsRepository repo;

        public PlaatsManager( IPlaatsRepository repo ) {
            this.repo = repo;
        }

        public Plaats RegistreerPlaats( string plaatsnaam ) {

            try {
                Plaats plaats = new Plaats( plaatsnaam );

                if ( repo.BestaatPlaats( plaats ) ) {
                    plaats = repo.SchrijfPlaatsInDB( plaats );
                    return plaats;
                } else
                    throw new PlaatsManagerException( "BestaatPlaats - plaats bestaat al" );

            } catch ( PlaatsManagerException ) {

                throw;
            } catch ( Exception e ) {
                throw new PlaatsManagerException( "RegistreerPlaats" , e );
            }
        }

        public IReadOnlyList<Plaats> SelecteerPlaatsen( string plaatsnaam ) {
            if ( string.IsNullOrWhiteSpace( plaatsnaam ) )
                throw new PlaatsManagerException( "SelecteerPlaatsen - geen input" );

            try {

                return repo.SelecteerPlaatsen( plaatsnaam );

            } catch ( PlaatsManagerException ) {

                throw;
            } catch ( Exception e ) {

                throw new PlaatsManagerException( "SelecteerPlaatsen" , e );
            }
        }
    }
}
