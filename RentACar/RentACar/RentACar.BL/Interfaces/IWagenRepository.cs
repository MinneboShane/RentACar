using RentACar.BL.Model;

namespace RentACar.BL.Interfaces {
    public interface IWagenRepository {

        Wagen SchrijfWagenInDB( Wagen wagen );
        bool BestaatWagen( Wagen wagen );
        Wagen SelecteerWagen( Wagen wagen );
        public Wagen UpdateBeschikbaarheid( Wagen wagen );
        IReadOnlyList<Wagen> SelecteerWagens();
    }
}
