namespace EFCoreMovies.Entities
{
    public class CinemaHall
    {
        public int Id { get; set; }
        public CinemaHallType CinemaHallType { get; set; }
        public decimal Cost { get; set; }
        public Currency Currency { get; set; }
        //Navigation property to Cinema(Foreign key)
        public int CinemaId { get; set; }
        //Optional for ease of query's
        public Cinema Cinema { get; set; }
        //Navigation property to Movie(Foreign key)
        public HashSet<Movie>Movies { get; set; }
    }
}
