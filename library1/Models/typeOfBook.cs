using System.ComponentModel;
namespace library1.Models
{
    public class typeOfBook
    {
        
        public int typeOfBookID { get; set; }
        public string? typeOfBook_name { get; set; }
        public ICollection<book>? books { get; set; }
    }
}
