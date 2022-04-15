
using System.ComponentModel;
namespace library1.Models
{
    public class author
    {   
         
        public int authorID { get; set; }
        public string? author_firstname { get; set; }
        public string? author_lastname { get; set; }
        public ICollection<book>? books { get; set; }
}
}
