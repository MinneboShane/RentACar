namespace RentACar.BL.Exceptions {
    internal class AdresException : Exception {
        public AdresException( string message ) : base( message ) { }

        public AdresException( string message , Exception innerException ) : base( message , innerException ) { }
    }
}
