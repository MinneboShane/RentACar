using RentACar.BL.Model;

namespace RentACar.BL.Interfaces {
    public interface IPlaatsRepository {

        Plaats SchrijfPlaatsInDB( Plaats plaats );
        bool BestaatPlaats( Plaats plaats );
        void UpdatePlaats( Plaats plaats );

        Plaats SelecteerPlaats( string plaats );
        IReadOnlyList<Plaats> SelecteerPlaatsen( string plaatsnaam );
    }
}
