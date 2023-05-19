using RentACar.BL.Model;

namespace RentACar.BL.Interfaces {
    public interface IAdresRepository {

        void SchrijfAdresInDB( Adres adres );
        bool BestaatAdres( Adres adres );
        Adres SelecteerAdres( Adres adres );
        IReadOnlyList<Adres> SelecteerAdressen( Adres adres );
    }
}
