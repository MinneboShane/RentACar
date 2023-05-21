using RentACar.BL.Interfaces;

namespace RentACar.BL.Managers {
    public class BedragenManager {

        private IBedragenRepository bedragenRepo;
        private IArrangementRepository arrangementRepo;


        public BedragenManager( IBedragenRepository bedragenRepo , IArrangementRepository arrangementRepo ) {
            this.bedragenRepo = bedragenRepo;
            this.arrangementRepo = arrangementRepo;
        }

        public void BerekenSubtotaalExBtw( decimal subExBtw ) {

        }
    }
}
