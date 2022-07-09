namespace EFCoreMovies.Entities
{
    public class RentMovie
    {
        public int Id { get; set; }
        public int MovieID { get; set; }
        public DateTime EndOfRental { get; set; }
        public int PaymentId { get; set; }
        //Navigitional Properties
        public Payment Payment { get; set; }
        public Movie Movie { get; set; }

    }
}
