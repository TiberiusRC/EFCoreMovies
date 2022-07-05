namespace EFCoreMovies.Entities
{
    public class CinemaOffer
    {
        public int Id { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public decimal DiscountPercentage { get; set; }
        //Navigation property to Cinema(Foreign key)
        public int CinemaId { get; set; }
    }
}
