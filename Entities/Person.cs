using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMovies.Entities
{
    public class Person
    {
        //Getting two relations from Message entity
        public int Id { get; set; }
        public string Name { get; set; }

        // Letting EFCore know to which entities these belong InverseProperty
        [InverseProperty("Sender")]
        public List<Message> SentMessages { get; set; }
        [InverseProperty("Reciever")]
        public List<Message> RecievedMessages { get; set; }
    }
}
