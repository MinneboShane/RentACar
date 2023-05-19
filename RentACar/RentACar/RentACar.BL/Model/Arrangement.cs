using RentACar.BL.Exceptions;

namespace RentACar.BL.Model {
    public class Arrangement {
        public Arrangement( string type ) {
            ZetType( type );
        }

        public string Type { get; set; }
        public double? AantalUren { get; set; }
        public decimal? PrijsPerUur { get; set; }
        public bool? IsVasteDuur { get; set; }

        public void ZetType( string type ) {
            if ( type == null )
                throw new ArrangementException( "ZetType" );
            Type = type;
        }

        public void ZetAantalUren( double aantalUren ) {
            if ( aantalUren <= 0 )
                throw new ArrangementException( "ZetAantalUren" );
            AantalUren = aantalUren;
        }

        public void ZetPrijsPerUur( decimal prijs ) {
            if ( prijs <= 0 )
                throw new ArrangementException( "ZetPrijsPerUur" );
            PrijsPerUur = prijs;
        }

        public void ZetIsVasteDuur( bool isVasteDuur ) {
            if ( isVasteDuur )
                IsVasteDuur = true;
            else
                IsVasteDuur = false;
        }

    }
}
