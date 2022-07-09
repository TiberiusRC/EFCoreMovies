using Microsoft.EntityFrameworkCore;

namespace EFCoreMovies.Entities
{   //Creates specific index of property and will be unique
    [Index(nameof(Name),IsUnique=true)]
    public class Genre
    {

        public int Id { get; set; }
        public string Name { get; set; }
        //Navigation property to Movie (foreignkey)(many to many relation)
        public bool IsDeleted { get; set; }
        public HashSet<Movie> Movies { get; set; }
    }
}
