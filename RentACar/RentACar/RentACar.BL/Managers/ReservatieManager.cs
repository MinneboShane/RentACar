using RentACar.BL.DTO;
using RentACar.BL.Exceptions;
using RentACar.BL.Interfaces;
using RentACar.BL.Model;

namespace RentACar.BL.Managers {
    public class ReservatieManager {

        private IReservatieRepository reservatieRepo;
        private IKlantRepository klantRepo;

        public ReservatieManager( IReservatieRepository reservatieRepository , IKlantRepository klantRepository ) {
            this.reservatieRepo = reservatieRepository;
            this.klantRepo = klantRepository;
        }

        public Reservatie RegistreerReservatie( KlantInfo klantInfo , ReservatieInfo reservatieInfo ) {

            if ( klantInfo == null )
                throw new ReservatieManagerException( "RegistreerReservatie - klant is null" );

            if ( string.IsNullOrWhiteSpace( klantInfo.Klantnummer ) )
                throw new ReservatieManagerException( "RegistreerReservatie - klantnummer is null" );


            try {

                Reservatie reservatie = null;

                if ( reservatieInfo == null ) {

                    Klant klant = klantRepo.SelecteerKlant( klantInfo.Klantnummer );

                    reservatie = new Reservatie( reservatieInfo.Reservatienummer
                       , reservatieInfo.DatumReservering , klant , reservatieInfo.StartDatum
                       , reservatieInfo.AantalUren , reservatieInfo.EenheidsPrijs , reservatieInfo.Wagens
                       , reservatieInfo.Arrangementen
                       , reservatieInfo.Startplaats , reservatieInfo.Aankomsplaats , reservatieInfo.SubtotaalExBtw
                       , reservatieInfo.SubtotaalInBtw , reservatieInfo.TotaalExBtw , reservatieInfo.TotaalInBtw );

                } else
                    throw new ReservatieManagerException( "RegistreerReservatie - registratie bestaat al" );

                return reservatieRepo.SchrijfReservatieInDB( reservatie );

            } catch ( ReservatieManagerException ) {

                throw;
            } catch ( Exception e ) {
                throw new ReservatieManagerException( "RegistreerReservatie" , e );
            }
        }
    }
}
