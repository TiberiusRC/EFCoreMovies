// used NetTopologySuite.Geometries to use location coordinates (Point value)
using NetTopologySuite.Geometries;

namespace EFCoreMovies.Entities
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Point Location { get; set; }
        //Navigation property to CinemaOffer(Foreign key)(one to one relation)
        public CinemaOffer CinemaOffer { get; set; }
        //Hashset might cause issues with the order , ifso then use List.( one to many relation)
        public HashSet<CinemaHall>CinemaHall { get; set; }
        public Address Address { get; set; }


    }
}
