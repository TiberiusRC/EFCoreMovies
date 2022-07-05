namespace EFCoreMovies.Entities
{
    public class CinemaHall
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        //Navigation property to Cinema(Foreign key)
        public int CinemaId { get; set; }
        //Optional for ease of query's
        public Cinema Cinema { get; set; }
    }
}
