using System.ComponentModel.DataAnnotations;

namespace EFCoreMovies.DTOs
{
    //Created to only access the name property in the api
    public class GenreCreationDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
