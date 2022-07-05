namespace EFCoreMovies.Entities
{
    public class MovieActor
    {
        // Intermediary class for Non skip relation method.

        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public string Character { get; set; }
        public int Order { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }
}
