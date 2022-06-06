using library1.Models;
using library1.Repositories.Interfaces;
using library1.Services.Interfaces;

namespace library1.Services
{

    // LIBRARY SERVICE

    public class LibraryService : ILibraryService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public LibraryService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        //get all books

        public List<book> GetBooks()
        {
            var books = new List<book>();
            books = _repositoryWrapper.LibraryRepository.FindByCondition2(x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return books;
        }
        //add book
         public void AddBook(book books){
            _repositoryWrapper.LibraryRepository.Create(books);
            _repositoryWrapper.Save();
        }
        //delete book
        public void DeleteBook(book books){
            _repositoryWrapper.LibraryRepository.Delete(books);
            _repositoryWrapper.Save();
        }
        //edit book
        public void EditBook(book books){
            _repositoryWrapper.LibraryRepository.Update(books);
            _repositoryWrapper.Save();
        }
        //find by id with included tables
        public book FindID(int id){
            var book = new book();
            book = _repositoryWrapper.LibraryRepository.FindObject(b => b.bookID == id, x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors);
            return book;
        }
        public List<book> GetBooksSearch(string search){
            var book = new List<book>();
            book = _repositoryWrapper.LibraryRepository.FindByCondition(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null, x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return book;
        }

        public List<book> GetAbooks(){ 
            var bookList = _repositoryWrapper.LibraryRepository.FindByCondition(b => b.typeOfBooks.typeOfBookID == 1, x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return bookList;
        }
        public List<book> GetActionbooks(){ 
            var bookList = _repositoryWrapper.LibraryRepository.FindByCondition(b => b.genres.genreID == 1, x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return bookList;
        }
        public List<book> GetAdventurebooks(){          
            var bookList = _repositoryWrapper.LibraryRepository.FindByCondition(b => b.genres.genreID == 2, x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return bookList;
        }
        public List<book> GetBiobooks(){  
            var bookList = _repositoryWrapper.LibraryRepository.FindByCondition(b => b.genres.genreID == 6, x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return bookList;
        }
        public List<book> GetCbooks(){ 
            var bookList = _repositoryWrapper.LibraryRepository.FindByCondition(b => b.typeOfBooks.typeOfBookID == 3, x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return bookList;
        }
        public List<book> GetDramabooks(){  
            var bookList = _repositoryWrapper.LibraryRepository.FindByCondition(b => b.genres.genreID == 5, x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return bookList;
        }
        public List<book> GetFHistorybooks(){  
            var bookList = _repositoryWrapper.LibraryRepository.FindByCondition(b => b.genres.genreID == 3 && b.mainGenres.mainGenreID == 1 , x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return bookList;
        }
        public List<book> GetFictionbooks(){  
            var bookList = _repositoryWrapper.LibraryRepository.FindByCondition(b => b.mainGenres.mainGenreID == 1 , x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return bookList;
        }
        
        public List<book> GetLearnbooks(){  
            var bookList = _repositoryWrapper.LibraryRepository.FindByCondition(b => b.genres.genreID == 7 , x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return bookList;
        }
        
        public List<book> GetNonFHistorybooks(){  
            var bookList = _repositoryWrapper.LibraryRepository.FindByCondition(b => b.genres.genreID == 3 && b.mainGenres.mainGenreID == 2  , x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return bookList;
        }
        
        public List<book> GetNonFictionbooks(){  
            var bookList = _repositoryWrapper.LibraryRepository.FindByCondition(b=> b.mainGenres.mainGenreID == 2  , x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return bookList;
        }
        public List<book> GetRomancebooks(){  
            var bookList = _repositoryWrapper.LibraryRepository.FindByCondition(b => b.genres.genreID == 4 , x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return bookList;
        }
        public List<book> GetTbooks(){  
            var bookList = _repositoryWrapper.LibraryRepository.FindByCondition(b => b.typeOfBooks.typeOfBookID == 2, x=> x.genres, x=> x.mainGenres, x=> x.typeOfBooks, x=> x.authors).ToList();
            return bookList;
        }
       
         
    }

    // AUTHOR SERVICE

    public class AuthorsService : IAuthorsService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public AuthorsService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public List<author> GetAuthors(){
            var authors = new List<author>();
            authors = _repositoryWrapper.AuthorsRepository.FindAll().ToList();
            return authors;
        }
    }

    // MAIN GENRE SERVICE

    public class MainGenreService : IMainGenreService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public MainGenreService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public List<mainGenre> GetMainGenre(){
            var mainGenres = new List<mainGenre>();
            mainGenres = _repositoryWrapper.MainGenreRepository.FindAll().ToList();
            return mainGenres;
        }
    }

    // GENRE SERVICE

    public class GenreService : IGenreService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public GenreService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public List<genre> GetGenre(){
            var genres = new List<genre>();
            genres = _repositoryWrapper.GenreRepository.FindAll().ToList();
            return genres;
        }
    }
    public class TypeOfBooksService : ITypeOfBooksService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public TypeOfBooksService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public List<typeOfBook> GetType(){
            var types = new List<typeOfBook>();
            types = _repositoryWrapper.TypeOfBooksRepository.FindAll().ToList();
            return types;
        }
    }
}