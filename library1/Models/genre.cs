using System.ComponentModel;
namespace library1.Models
{
    public class genre
    {
        
        public int genreID { get; set; }
        public string? genre_name { get; set; }
        public ICollection<book>? books { get; set; }
    }
}
