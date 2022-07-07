using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMovies.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        //Properrty field for flexible mapping
        private string _name; //(fields are with underscore))
        public string Name {
            get { return _name; }
            set 
            {   //sets the first letter of each word to uppercase and the rest to lowercase
                _name = string.Join(' ',
                    value.Split(' ')
                    .Select(n => n[0].ToString().ToUpper() + n.Substring(1).ToLower()).ToArray());
            }
        }
        public string Biography { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [NotMapped]
        public int? Age { get
            {
                if (!DateOfBirth.HasValue)
                {
                    return null;
                }
                var dob = DateOfBirth.Value;
                var age = DateTime.Today.Year - dob.Year;
                if (new DateTime(DateTime.Today.Year,dob.Month,dob.Day) > DateTime.Today)
                {
                    age--;
                }
                return age;
            }}

        //Navigation property to MovieActor (Foreign key)(non skip method)
        public HashSet<MovieActor> MovieActors { get; set; }
        public Address Address { get; set; }
    }
}
