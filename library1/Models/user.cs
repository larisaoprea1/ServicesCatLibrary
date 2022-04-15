namespace library1.Models
{
    public class user
    {
        public int userID { get; set; }
        public string? user_firstname { get; set; }
        public string? user_lastname { get; set; }
        public string? username { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public ICollection<favoriteBooks>? favoriteBooks { get; set; }
        public ICollection<placeHoldBooks>? placeHoldBooks { get; set; }

    }
}
