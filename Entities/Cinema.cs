// used NetTopologySuite.Geometries to use location coordinates (Point value)
using NetTopologySuite.Geometries;

namespace EFCoreMovies.Entities
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Point Location { get; set; }


    }
}
