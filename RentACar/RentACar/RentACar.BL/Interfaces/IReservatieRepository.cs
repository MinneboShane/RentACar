using RentACar.BL.Model;

namespace RentACar.BL.Interfaces {
    public interface IReservatieRepository {

        void SchrijfReservatieInDB( Reservatie reservatie );
        bool BestaatReservatie( Reservatie reservatie );
        bool BestaatReservatie( int reservatienummer );
        Reservatie SelecteerReservatie( Wagen wagen );
        IReadOnlyList<Reservatie> SelecteerReservaties( int nummer );
    }
}
