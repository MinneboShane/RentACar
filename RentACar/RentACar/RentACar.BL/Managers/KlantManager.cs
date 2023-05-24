using RentACar.BL.DTO;
using RentACar.BL.Exceptions;
using RentACar.BL.Interfaces;
using RentACar.BL.Model;

namespace RentACar.BL.Managers {
    public class KlantManager {

        private IKlantRepository klantRepo;

        public KlantManager( IKlantRepository klantRepo ) {
            this.klantRepo = klantRepo;
        }

        public Klant RegistreerKlant( string klantnummer , string voornaam , string naam , string straat , int huisnr , int busnr , string gemeente , string postcode , string btwnr ) {

            try {

                Klant klant = new Klant( klantnummer , voornaam , naam , straat , huisnr , busnr , gemeente , postcode , btwnr );

                if ( !klantRepo.BestaatKlant( klant ) ) {
                    klant = klantRepo.SchrijfKlantInDB( klant );
                    return klant;
                } else
                    throw new KlantManagerException( "RegistreerKlant - klant bestaat al" );

            } catch ( KlantManagerException ) {

                throw;
            } catch ( Exception e ) {
                throw new KlantManagerException( "RegistreerKlant" , e );
            }
        }

        public void UpdateKlant( KlantInfo klantInfo ) {
            if ( klantInfo == null )
                throw new KlantManagerException( "UpdateKlant - klant bestaat niet" );

            if ( string.IsNullOrWhiteSpace( klantInfo.Klantnummer ) )
                throw new KlantManagerException( "UpdateKlant - klantnummer is null" );

            try {

                if ( klantRepo.BestaatKlant( klantInfo.Klantnummer ) ) {

                    Klant klant = klantRepo.SelecteerKlant( klantInfo.Klantnummer );

                    bool changed = false;

                    if ( klantInfo.Voornaam != klant.Voornaam ) {
                        klant.ZetVoornaam( klantInfo.Voornaam );
                        changed = true;
                    }

                    if ( klantInfo.Naam != klant.Naam ) {
                        klant.ZetNaam( klantInfo.Naam );
                        changed = true;
                    }

                    if ( klantInfo.Straat != klant.Straat ) {
                        klant.ZetStraat( klantInfo.Straat );
                        changed = true;
                    }

                    if ( klantInfo.Huisnummer != klant.Huisnummer ) {
                        klant.ZetHuisnummer( klantInfo.Huisnummer );
                        changed = true;
                    }

                    if ( klantInfo.Busnummer != klant.Busnummer ) {
                        klant.ZetBusnummer( klantInfo.Busnummer );
                        changed = true;
                    }

                    if ( klantInfo.Gemeente != klant.Gemeente ) {
                        klant.ZetGemeente( klantInfo.Gemeente );
                        changed = true;
                    }

                    if ( klantInfo.Postcode != klant.Postcode ) {
                        klant.ZetPostcode( klantInfo.Postcode );
                        changed = true;
                    }

                    if ( klantInfo.BtwNummer != klant.BtwNummer ) {
                        klant.ZetBtwNummer( klantInfo.BtwNummer );
                        changed = true;
                    }



                    if ( !changed )
                        throw new KlantManagerException( "UpdateKlant - no changes" );

                    klantRepo.UpdateKlant( klant );
                } else
                    throw new KlantManagerException( "UpdateKlant - klant niet gevonden" );

            } catch ( KlantManagerException ) {

                throw;
            } catch ( Exception e ) {
                throw new KlantManagerException( "UpdateKlant" , e );
            }

        }

        public IReadOnlyList<KlantInfo> SelecteerKlanten() {

            try {

                return klantRepo.SelecteerKlanten();

            } catch ( Exception ex ) {

                throw new KlantManagerException( "SelecteerKlanten" , ex );
            }

        }
    }
}
