using System.ComponentModel.DataAnnotations;

namespace EFCoreMovies.Entities
{   //Used for the lesson about table splitting
    public class CinemaDetail
    {
        public int Id { get; set; }
        [Required]
        public string History { get; set; }
        public string Values { get; set; }
        public string Missions { get; set; }
        public string CodeOfConduct { get; set; }
        //Navigational property
        public Cinema Cinema { get; set; }
    }
}
