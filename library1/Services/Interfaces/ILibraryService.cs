using library1.Models;

namespace library1.Services.Interfaces
{
    public interface ILibraryService
    {
        List<book> GetBooks();
        List<book> GetAbooks();
        List<book> GetActionbooks();
        List<book> GetAdventurebooks();
        List<book> GetBiobooks();
        List<book> GetCbooks();
        List<book> GetDramabooks();
        List<book> GetFHistorybooks();
        List<book> GetFictionbooks();
        List<book> GetLearnbooks();
        List<book> GetNonFHistorybooks();
        List<book> GetNonFictionbooks();
        List<book> GetRomancebooks();
        List<book> GetTbooks();
        void AddBook(book books);
        void DeleteBook(book books);
        book FindID(int id);
        void EditBook(book books);
        List<book> GetBooksSearch(string search);
    }
    public interface IAuthorsService
    {
        List<author> GetAuthors();
    }
    public interface IMainGenreService
    {
        List<mainGenre> GetMainGenre();
    }
    public interface IGenreService
    {
        List<genre> GetGenre();
    }
    public interface ITypeOfBooksService
    {
        List<typeOfBook> GetType();
    }
}