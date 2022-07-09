namespace EFCoreMovies.Entities
{
    public class Message
    {
        //Relationship twice with the same entity (person)
        public int Id { get; set; }
        public string Content { get; set; }
        public int SenderId { get; set; }
        public Person Sender { get; set; }
        public int RecieverId { get; set; }
        public Person Reciever { get; set; }
       
    }
}
