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

        public void UpdatePlaats( Plaats nieuwePlaats ) {
            if ( nieuwePlaats == null )
                throw new PlaatsManagerException( "UpdatePlaats - no input" );
            if ( string.IsNullOrWhiteSpace( nieuwePlaats.Plaatsnaam ) )
                throw new PlaatsManagerException( "UpdatePlaats - Plaatsnaam is null" );

            try {

                if ( repo.BestaatPlaats( nieuwePlaats ) ) {
                    Plaats plaats = repo.SelecteerPlaats( nieuwePlaats.Plaatsnaam );
                    bool changed = false;

                    if ( plaats.Plaatsnaam != nieuwePlaats.Plaatsnaam ) {
                        plaats.ZetPlaatsnaam( nieuwePlaats.Plaatsnaam );
                        changed = true;
                    }

                    if ( !changed )
                        throw new PlaatsManagerException( "UpdatePlaats - no changes" );

                    repo.UpdatePlaats( plaats );
                } else
                    throw new PlaatsManagerException( "updatePlaats - plaats niet gevonden" );


            } catch ( PlaatsManagerException ) {

                throw;
            } catch ( Exception e ) {
                throw new PlaatsManagerException( "UpdatePlaats" , e );
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
