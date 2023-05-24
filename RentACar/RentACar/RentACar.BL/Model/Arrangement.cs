using RentACar.BL.Exceptions;

namespace RentACar.BL.Model {
    public class Arrangement {
        public Arrangement( string type , int aantalUren , decimal prijs , bool isVasteduur ) {
            ZetType( type );
            ZetAantalUren( aantalUren );
            ZetPrijs( prijs );
            ZetIsVasteDuur( isVasteduur );
        }

        public string Type { get; set; }
        public int? AantalUur { get; set; }
        public decimal? Prijs { get; set; }
        public bool? IsVasteDuur { get; set; }
        public decimal Subtotaal { get; set; }

        public void ZetType( string type ) {
            if ( type == null )
                throw new ArrangementException( "ZetType" );
            Type = type;
        }

        public void ZetAantalUren( int aantalUren ) {
            if ( aantalUren <= 0 )
                throw new ArrangementException( "ZetAantalUren" );
            if ( ( IsVasteDuur.Value ) && aantalUren > 11 )
                throw new ArrangementException( "ZetAantalUren - maximum 11 uur" );
            if ( IsVasteDuur.Value )
                AantalUur = 7;
            else
                AantalUur = aantalUren;
        }

        public void ZetPrijs( decimal prijs ) {
            if ( prijs <= 0 )
                throw new ArrangementException( "ZetPrijsPerUur" );
            Prijs = prijs;
        }

        public void ZetIsVasteDuur( bool isVasteDuur ) {
            if ( isVasteDuur )
                IsVasteDuur = true;
            else
                IsVasteDuur = false;
        }

        public void ZetSubtotaal( decimal subtotaal ) {
            if ( subtotaal <= 0 )
                throw new ArrangementException( "ZetSubtotaal" );
            Subtotaal = subtotaal;
        }
    }
}
