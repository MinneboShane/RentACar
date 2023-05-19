namespace RentACar.BL.Exceptions {
    internal class WagenException : Exception {
        public WagenException( string message ) : base( message ) { }

        public WagenException( string message , Exception innerException ) : base( message , innerException ) { }
    }
}
