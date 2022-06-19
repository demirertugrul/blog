namespace EntityLayer.Concrete
{
    public class BlogRating
    {
        public int ID { get; set; }
        public int BlogID { get; set; }
        public int BlogTotalScore { get; set; }
        public int BlogRatingCount { get; set; }
    }
}
