using RentACar.BL.Exceptions;

namespace RentACar.BL.Model {
    public class Bedragen {
        public Bedragen( decimal subtotaalExBtw , decimal subtotaalInBtw , decimal totaalExBtw , decimal totaalInBtw ) {
            ZetSubtotaalExBtw( subtotaalExBtw );
            ZetSubtotaalInBtw( subtotaalInBtw );
            ZetTotaalExBtw( totaalExBtw );
            ZetTotaalInBtw( totaalInBtw );
        }

        public decimal SubtotaalExBtw { get; set; }
        public decimal SubtotaalInBtw { get; set; }
        public decimal TotaalExBtw { get; set; }
        public decimal TotaalInBtw { get; set; }


        public void ZetSubtotaalExBtw( decimal subtotaalExBtw ) {
            if ( subtotaalExBtw < 0 )
                throw new BedragenException( "ZetSubtotaalExBtw" );
            SubtotaalExBtw = subtotaalExBtw;
        }

        public void ZetSubtotaalInBtw( decimal subtotaalInBtw ) {
            if ( subtotaalInBtw < 0 )
                throw new BedragenException( "ZetSubtotaalInBtw" );
            SubtotaalInBtw = subtotaalInBtw;
        }
        public void ZetTotaalExBtw( decimal totaalExBtw ) {
            if ( totaalExBtw < 0 )
                throw new BedragenException( "ZetTotaalExBtw" );
            TotaalExBtw = totaalExBtw;
        }
        public void ZetTotaalInBtw( decimal totaalInBtw ) {
            if ( totaalInBtw < 0 )
                throw new BedragenException( "ZetTotaalInBtw" );
            TotaalInBtw = totaalInBtw;
        }

    }
}
