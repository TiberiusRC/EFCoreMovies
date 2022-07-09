using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMovies.Entities
{
    //[NotMapped]// This ensure that no tables or extra columns will be created in the database , but will be usable.
    [Owned]//Almost the same idea as table splitting
    public class Address
    {
        //public int Id { get; set; } Because it's OWNED it will use the Id of the main/principal entity.
        public string Street { get; set; }
        public int Province { get; set; }
        [Required]// Needs atleast one required property
        public int Country { get; set; }
    }
}
