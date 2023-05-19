namespace RentACar.BL.Exceptions {
    internal class AdresManagerException : Exception {
        public AdresManagerException( string message ) : base( message ) { }

        public AdresManagerException( string message , Exception innerException ) : base( message , innerException ) { }

    }
}
