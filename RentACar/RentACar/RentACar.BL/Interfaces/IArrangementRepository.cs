using RentACar.BL.Model;

namespace RentACar.BL.Interfaces {
    public interface IArrangementRepository {

        Arrangement SchrijfArrangementInDB( Arrangement arrangement );
        bool BestaatArrangement( Arrangement arrangement );
        void UpdateArrangement( Arrangement arrangement );
        Arrangement SelecteerArrangement( string plaatsnaam );
        IReadOnlyList<Arrangement> SelecteerArrangementen( string plaatsnaam );
    }
}
