namespace RentACar.BL.Exceptions {
    public class BedragenException : Exception {

        public BedragenException( string message ) : base( message ) { }

        public BedragenException( string message , Exception innerException ) : base( message , innerException ) { }
    }

}
