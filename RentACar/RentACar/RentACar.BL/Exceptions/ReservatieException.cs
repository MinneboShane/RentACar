namespace RentACar.BL.Exceptions {
    internal class ReservatieException : Exception {
        public ReservatieException( string message ) : base( message ) { }

        public ReservatieException( string message , Exception innerException ) : base( message , innerException ) { }
    }
}
