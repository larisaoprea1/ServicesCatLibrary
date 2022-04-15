using System.ComponentModel;
namespace library1.Models
{
    public class book { 
    public int bookID { get; set; }

     [DisplayName("Title:")] 
    public string? book_title { get; set; }

     [DisplayName("Number of pages:")] 
    public string? book_pages { get; set; }

     [DisplayName("Year:")] 
    public int year { get; set; }

     [DisplayName("Cover of the book:")] 
    public string? cover_path { get; set; }

     [DisplayName("Is it place holded?")] 
    public string? placeHolded { get; set; }

     [DisplayName("Country:")] 
    public string? country { get; set; }

        //authors
        [DisplayName("Select author:")] 
        public int authorID { get; set; }
        public author? authors { get; set; }

        //genre
        [DisplayName("Select genre:")] 
        public int genreID { get; set; }
        public genre? genres { get; set; }

        //mainGenre
        [DisplayName("Select main genre:")]
        public int mainGenreID { get; set; }
        public mainGenre? mainGenres { get; set; }

        //typeOfBook
        [DisplayName("Select the type of the book:")] 
        public int typeOfBookID { get; set; }
        public typeOfBook? typeOfBooks { get; set; }
         public ICollection<favoriteBooks>? favoriteBooks { get; set; }
        public ICollection<placeHoldBooks>? placeHoldBooks { get; set; }

    }
}
