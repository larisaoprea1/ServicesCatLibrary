using System.ComponentModel;
namespace library1.Models
{
    public class mainGenre
    {
         
        public int mainGenreID { get; set; }
        public string? mainGenre_name { get; set; }
        public ICollection<book>? books { get; set; }
    }
}
