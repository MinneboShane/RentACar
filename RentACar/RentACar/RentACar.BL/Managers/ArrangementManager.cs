using RentACar.BL.Exceptions;
using RentACar.BL.Interfaces;
using RentACar.BL.Model;

namespace RentACar.BL.Managers {
    public class ArrangementManager {

        private IArrangementRepository repo;

        public ArrangementManager( IArrangementRepository repo ) {
            this.repo = repo;
        }

        public Arrangement RegistreerArrangement( string type , int MaxAantalUur , decimal prijs , bool isVasteDuur ) {

            try {
                Arrangement arrangement = new Arrangement( type , MaxAantalUur , prijs , isVasteDuur );

                if ( !repo.BestaatArrangement( arrangement ) ) {
                    arrangement = repo.SchrijfArrangementInDB( arrangement );
                    return arrangement;
                } else
                    throw new ArrangementManagerException( "RegistreerArrangement - is null" );

            } catch ( ArrangementManagerException ) {

                throw;
            } catch ( Exception ex ) {
                throw new ArrangementManagerException( "RegistreerArrangement" , ex );
            }
        }

        public void UpdateArrangement( Arrangement NieuweArrangement ) {
            if ( NieuweArrangement == null )
                throw new ArrangementManagerException( "UpdateArrangement - is null" );
            if ( string.IsNullOrWhiteSpace( NieuweArrangement.Type ) )
                throw new ArrangementManagerException( "RegistreerArrangement - Type is null" );

            try {

                if ( repo.BestaatArrangement( NieuweArrangement ) ) {
                    Arrangement arrangement = repo.SelecteerArrangement( NieuweArrangement.Type );
                    bool changed = false;

                    if ( arrangement.Type != NieuweArrangement.Type ) {
                        arrangement.ZetType( NieuweArrangement.Type );
                        changed = true;
                    }

                    if ( ( ( arrangement.AantalUur.HasValue ) && ( arrangement.AantalUur != NieuweArrangement.AantalUur ) )
                        || ( ( NieuweArrangement.AantalUur.HasValue ) && ( !arrangement.AantalUur.HasValue ) ) ) {
                        arrangement.ZetAantalUren( ( int ) NieuweArrangement.AantalUur.Value );
                        changed = true;
                    }

                    if ( ( ( arrangement.Prijs.HasValue ) && ( arrangement.Prijs != NieuweArrangement.Prijs ) )
                        || ( ( NieuweArrangement.Prijs.HasValue ) && ( !arrangement.Prijs.HasValue ) ) ) {
                        arrangement.ZetPrijs( ( decimal ) NieuweArrangement.Prijs.Value );
                        changed = true;
                    }

                    if ( arrangement.IsVasteDuur != NieuweArrangement.IsVasteDuur ) {
                        arrangement.ZetIsVasteDuur( ( bool ) NieuweArrangement.IsVasteDuur );
                    }

                    if ( !changed )
                        throw new ArrangementManagerException( "UpdateArrangement - no changes" );

                    repo.UpdateArrangement( arrangement );
                } else
                    throw new ArrangementManagerException( "UpdateArrangement - arrangement niet gevonden" );

            } catch ( ArrangementManagerException ) {

                throw;
            } catch ( Exception e ) {
                throw new ArrangementManagerException( "UpdateArrangement" , e );
            }

        }

        public IReadOnlyList<Arrangement> SelecteerArrangementen( Arrangement arrangement ) {

            if ( arrangement == null )
                throw new ArrangementManagerException( "SelecteerArrangementen - no input)" );

            try {
                return repo.SelecteerArrangementen( arrangement.Type );

            } catch ( ArrangementManagerException ) {

                throw;
            } catch ( Exception e ) {
                throw new ArrangementManagerException( "SelecteerArrangementen" , e );
            }
        }
    }
}
