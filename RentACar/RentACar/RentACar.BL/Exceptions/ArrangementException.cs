namespace RentACar.BL.Exceptions {
    internal class ArrangementException : Exception {

        public ArrangementException( string message ) : base( message ) { }

        public ArrangementException( string message , Exception innerException ) : base( message , innerException ) { }

    }
}
