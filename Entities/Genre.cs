namespace EFCoreMovies.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Navigation property to Movie (foreignkey)(many to many relation)
        public HashSet<Movie> Movies { get; set; }
    }
}
