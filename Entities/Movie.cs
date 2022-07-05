namespace EFCoreMovies.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool InCinemas { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PosterUrl { get; set; }
        //Navigation property to Genre (foreignkey)(many to many relation)
        public HashSet<Genre>Genres { get; set; }
        //Navigation property to CinemaHall (Foreign key)
        public HashSet<CinemaHall>CinemaHalls{ get; set; }
        //Navigation property to MovieActor (Foreign key)(non skip method)
        public HashSet<MovieActor> MovieActors { get; set; }
    }
}
