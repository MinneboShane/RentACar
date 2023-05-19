namespace RentACar.BL.Exceptions {
    internal class ArrangementManagerException : Exception {
        public ArrangementManagerException( string message ) : base( message ) { }

        public ArrangementManagerException( string message , Exception innerException ) : base( message , innerException ) { }

    }
}
