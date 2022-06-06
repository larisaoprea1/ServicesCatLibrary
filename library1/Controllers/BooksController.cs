using library1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;
using library1.Services;
using library1.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace library1
{
    public class BooksController : Controller
    {

        // private readonly libraryContext _db;
        private ILibraryService _libraryService;
        private IAuthorsService _authorsService;
        private IMainGenreService _maingenreService;
        private IGenreService _genreService;
        private ITypeOfBooksService _typeOfBooksService;

        public BooksController(ILibraryService libraryService, IAuthorsService authorsService, IMainGenreService maingenreService,IGenreService genreService, ITypeOfBooksService typeOfBooksService)
        {
           
            _libraryService = libraryService;
            _authorsService = authorsService;
            _maingenreService = maingenreService;
            _genreService = genreService;
            _typeOfBooksService = typeOfBooksService;

        }
        [Authorize]
        public IActionResult Books(){

            return View();

        }
        [Authorize]
        public IActionResult GetAllBooks(){
             var books = _libraryService.GetBooks();
                return Json(books);
        }
        [Authorize]
        public IActionResult abook()
        {
            /* IEnumerable<book> bookList = _db.books.ToList();*/
            // var pageNumber = page ?? 1;
            // var pageSize = 12;
            // var bookList = _db.books.Include("genres").Include("mainGenres").Include("typeOfBooks").Include("authors").Where(b => b.typeOfBooks.typeOfBookID == 1).Where(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null).OrderBy(y => y.bookID).ToList().ToPagedList(pageNumber, pageSize);
            return View();
        }
        [Authorize]
        public IActionResult DetailsBook(int id)
        {
            var book = new book();
            book = _libraryService.FindID(id);
            return View(book);
        }
        
        [Authorize]
        public IActionResult GetAbook(){

                var books = _libraryService.GetAbooks();
                return Json(books);
        }
        [Authorize]
        public IActionResult action()
        {
    
            return View();
        }
        [Authorize]
        public IActionResult GetActionbook(){
                var books = _libraryService.GetActionbooks();
                return Json(books);
        }
        [Authorize]
        public IActionResult adventure()
        {
            return View();
        }
        [Authorize]
        public IActionResult GetAdventurebook(){
                var books = _libraryService.GetAdventurebooks();
                return Json(books);
        }
        [Authorize]
        public IActionResult bio()
        {
            return View();
        }
        [Authorize]
        public IActionResult GetBiobook(){
                var books = _libraryService.GetBiobooks();
                return Json(books);
        }
        [Authorize]
        public IActionResult cbook()
        {
            return View();
        }
        [Authorize]
        public IActionResult GetCbook(){
                var books = _libraryService.GetCbooks();
                return Json(books);
        }
        [Authorize]
        public IActionResult drama()
        {
            return View();
        }
        [Authorize]
        public IActionResult GetDramabook(){
                var books = _libraryService.GetDramabooks();
                return Json(books);
        }
        [Authorize]
        public IActionResult fhistory()
        {
            return View();
        }
        [Authorize]
        public IActionResult GetFHistorybook(){
                var books = _libraryService.GetFHistorybooks();
                return Json(books);
        }
        [Authorize]
        public IActionResult fiction()
        {
            return View();
        }
        [Authorize]
        public IActionResult GetFictionbook(){
                var books = _libraryService.GetFictionbooks();
                return Json(books);
        }
        [Authorize]
        public IActionResult learn()
        {
            return View();
        }
        [Authorize]
        public IActionResult GetLearnbook(){
                var books = _libraryService.GetLearnbooks();
                return Json(books);
        }
        [Authorize]
        public IActionResult nonfhistory()
        {
            return View();
        }
        [Authorize]
        public IActionResult GetNonFHistorybook(){
                var books = _libraryService.GetNonFHistorybooks();
                return Json(books);
        }
        [Authorize]
        public IActionResult nonFiction()
        {
            return View();
        }
        [Authorize]
        public IActionResult GetNonFictionbook(){
                var books = _libraryService.GetNonFictionbooks();
                return Json(books);
        }
        [Authorize]
        public IActionResult romance()
        {
            return View();
        }
        [Authorize]
        public IActionResult GetRomancebook(){
                var books = _libraryService.GetRomancebooks();
                return Json(books);
        }
        [Authorize]
        public IActionResult tbook()
        {
            return View();
        }
        [Authorize]
        public IActionResult GetTbook(){
                var books = _libraryService.GetTbooks();
                return Json(books);
        }
        
    //     private void PopulateLookups(book books)
    //     {
    //         var author = _db.authors.OrderBy(p => p.author_firstname).ToList();
    //         ViewBag.authorID = author.Select(p => new SelectListItem
    //         {
    //             Value = p.authorID.ToString(),
    //             Text = p.author_firstname + " " + p.author_lastname,
    //             Selected = p.authorID == books.authorID,
    //         });

    //         var genre = _db.genres.OrderBy(p => p.genreID).ToList();
    //         ViewBag.genreID = genre.Select(p => new SelectListItem
    //         {
    //             Value = p.genreID.ToString(),
    //             Text = p.genre_name,
    //             Selected = p.genreID == books.genreID,
    //         });

    //         var mainGenre = _db.mainGenres.OrderBy(p => p.mainGenreID).ToList();
    //         ViewBag.mainGenreID = mainGenre.Select(p => new SelectListItem
    //         {
    //             Value = p.mainGenreID.ToString(),
    //             Text = p.mainGenre_name,
    //             Selected = p.mainGenreID == books.mainGenreID,
    //         });

    //         var type = _db.typeOfBooks.OrderBy(p => p.typeOfBookID).ToList();
    //         ViewBag.typeOfBookID = type.Select(p => new SelectListItem
    //         {
    //             Value = p.typeOfBookID.ToString(),
    //             Text = p.typeOfBook_name,
    //             Selected = p.typeOfBookID == books.typeOfBookID,
    //         });
    //     }

        [Authorize(Roles = "Administrator")] 
        public IActionResult insertBook()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")] 
        public IActionResult insertBook(book books)
        {
            _libraryService.AddBook(books);
            return RedirectToAction("books");
        }
        public IActionResult PopulateAuthors(){
            var authors = _authorsService.GetAuthors();
            return Json(authors);
        }
        public IActionResult PopulateMainGenre(){
            var mainGenres = _maingenreService.GetMainGenre();
            return Json(mainGenres);
        }
        public IActionResult PopulateGenre(){
            var genres = _genreService.GetGenre();
            return Json(genres);
        }
        public IActionResult PopulateType(){
            var types = _typeOfBooksService.GetType();
            return Json(types);
        }

        [Authorize(Roles = "Administrator")] 
        public IActionResult deleteBook(int id)
        {   
            var book = new book();
            book = _libraryService.FindID(id);
            _libraryService.DeleteBook(book);
            return Redirect(Request.Headers["Referer"]);
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")] 
        public IActionResult editBook(int id)
        {   
            var book = new book();
            book = _libraryService.FindID(id);
            return View(book);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")] 
        public IActionResult editBook(book books)
        {
              _libraryService.EditBook(books);
               
            return RedirectToAction("fiction");

        }

        [HttpGet]
        [Route("Books/searchBooks/{search?}")]
        public IActionResult searchBooks(string search){
            var book = _libraryService.GetBooksSearch(search);
            return Json(book);
        }
    }
}

