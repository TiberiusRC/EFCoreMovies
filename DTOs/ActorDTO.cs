namespace EFCoreMovies.DTOs
{
    public class ActorDTO
    {
        //Showable columns in query (filter method)
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
