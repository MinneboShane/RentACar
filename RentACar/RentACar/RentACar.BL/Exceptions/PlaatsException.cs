namespace RentACar.BL.Exceptions {
    internal class PlaatsException : Exception {
        public PlaatsException( string message ) : base( message ) { }

        public PlaatsException( string message , Exception innerException ) : base( message , innerException ) { }

    }
}
