namespace RentACar.BL.Exceptions {
    internal class WagenManagerException : Exception {
        public WagenManagerException( string message ) : base( message ) { }

        public WagenManagerException( string message , Exception innerException ) : base( message , innerException ) { }

    }
}
