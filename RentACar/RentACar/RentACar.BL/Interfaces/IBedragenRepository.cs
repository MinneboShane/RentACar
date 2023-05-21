namespace RentACar.BL.Interfaces {
    public interface IBedragenRepository {

        void BerekenSubtotaalExBtw( decimal subExBtw );
        void BerekenSubtotaalInBtw( decimal subInBtw );
        void BerekenTotaalExBtw( decimal totExBtw );
        void BerekenTotaalInBtw( decimal totInBtw );

    }
}
