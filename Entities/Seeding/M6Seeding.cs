using Microsoft.EntityFrameworkCore;

namespace EFCoreMovies.Entities.Seeding
{
    public static class M6Seeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var tiberius = new Person() { Id = 1, Name = "Tiberius" };
            var samantha = new Person() { Id = 2, Name = "Samantha" };

            var message1 = new Message { Id = 1, Content = "Heehoo , Samantha!!",SenderId =tiberius.Id,RecieverId=samantha.Id };
            var message2 = new Message { Id = 2, Content = "HooooooooHeeeeeeee Tiberius!!",SenderId = samantha.Id,RecieverId=tiberius.Id };
            var message3 = new Message { Id = 3, Content = "Wanna Hang??", SenderId = tiberius.Id, RecieverId = samantha.Id };
            var message4 = new Message { Id = 4, Content = "Hell Yeah , i'll bring the booze!!", SenderId = samantha.Id, RecieverId = tiberius.Id };

            modelBuilder.Entity<Person>().HasData(tiberius, samantha);
            modelBuilder.Entity<Message>().HasData(message1, message2, message3, message4);


        }
    }
}
