using RentACar.BL.Model;

namespace RentACar.BL.Interfaces {
    public interface IWagenRepository {

        void SchrijfWagenInDB( Wagen wagen );
        bool BestaatWagen( Wagen wagen );
        Wagen SelecteerWagen( Wagen wagen );
        bool IsBeschikbaar( Wagen wagen );
        IReadOnlyList<Wagen> SelecteerWagens( string merk , string type );
    }
}
