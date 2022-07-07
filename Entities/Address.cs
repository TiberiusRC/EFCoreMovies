using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMovies.Entities
{
    //[NotMapped]// This ensure that no tables or extra columns will be created in the database , but will be usable.
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Province { get; set; }
        public int Country { get; set; }
    }
}
