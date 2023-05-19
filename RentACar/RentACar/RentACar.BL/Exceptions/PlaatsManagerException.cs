namespace RentACar.BL.Exceptions {
    internal class PlaatsManagerException : Exception {
        public PlaatsManagerException( string message ) : base( message ) { }

        public PlaatsManagerException( string message , Exception innerException ) : base( message , innerException ) { }

    }
}
