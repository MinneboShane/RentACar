using RentACar.BL.Model;

namespace RentACar.BL.Interfaces {
    public interface IPlaatsRepository {

        Plaats SchrijfPlaatsInDB( Plaats plaats );
        bool BestaatPlaats( Plaats plaats );
        Plaats SelecteerPlaats( Plaats plaats );
        IReadOnlyList<Plaats> SelecteerPlaatsen( string plaatsnaam );
    }
}
