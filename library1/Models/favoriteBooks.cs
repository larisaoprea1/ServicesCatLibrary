namespace library1.Models
{
    public class favoriteBooks
    {
        public int userID { get; set; }
        public virtual user? user { get; set; }
        public int bookID { get; set; }
        public virtual book? book { get; set; }
    }
}
