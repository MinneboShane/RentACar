namespace RentACar.BL.Exceptions {
    internal class ReservatieManagerException : Exception {
        public ReservatieManagerException( string message ) : base( message ) { }

        public ReservatieManagerException( string message , Exception innerException ) : base( message , innerException ) { }

    }
}
