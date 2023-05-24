using RentACar.BL.Model;

namespace RentACar.BL.Interfaces {
    public interface IReservatieRepository {

        Reservatie SchrijfReservatieInDB( Reservatie reservatie );
    }
}
