using RentACar.BL.DTO;
using RentACar.BL.Model;

namespace RentACar.BL.Interfaces {
    public interface IKlantRepository {

        Klant SchrijfKlantInDB( Klant klant );
        bool BestaatKlant( Klant klant );
        bool BestaatKlant( string klantnummer );
        Klant SelecteerKlant( string klantnummer );
        void UpdateKlant( Klant klant );
        IReadOnlyList<KlantInfo> SelecteerKlanten();
    }
}
