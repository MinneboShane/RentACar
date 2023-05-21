namespace RentACar.BL.Exceptions {
    public class BedragenManagerException : Exception {
        public BedragenManagerException( string message ) : base( message ) { }

        public BedragenManagerException( string message , Exception innerException ) : base( message , innerException ) { }
    }
}
