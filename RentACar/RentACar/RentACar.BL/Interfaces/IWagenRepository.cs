using RentACar.BL.Model;

namespace RentACar.BL.Interfaces {
    internal interface IWagenRepository {

        bool IsBeschikbaar( Wagen wagen );
    }
}
