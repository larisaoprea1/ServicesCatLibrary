using library1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace library1
{
    public class BooksController : Controller
    {

        private readonly libraryContext _db;
        public BooksController(libraryContext db)
        {
            _db = db;
        }
        public IActionResult abook(string search, int? page)
        {
            /* IEnumerable<book> bookList = _db.books.ToList();*/
            var pageNumber = page ?? 1;
            var pageSize = 12;
            var bookList = _db.books.Include("genres").Include("mainGenres").Include("typeOfBooks").Include("authors").Where(b => b.typeOfBooks.typeOfBookID == 1).Where(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null).OrderBy(y => y.bookID).ToList().ToPagedList(pageNumber, pageSize);
            return View(bookList);
        }
        public IActionResult action(string search, int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 12;
            var bookList = _db.books.Include("genres").Include("mainGenres").Include("typeOfBooks").Include("authors").Where(b => b.genres.genreID == 1).Where(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null).OrderBy(y => y.bookID).ToList().ToPagedList(pageNumber, pageSize);
            return View(bookList);
        }
        public IActionResult adventure(string search, int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 12;
            var bookList = _db.books.Include("genres").Include("mainGenres").Include("typeOfBooks").Include("authors").Where(b => b.genres.genreID == 2).Where(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null).OrderBy(y => y.bookID).ToList().ToPagedList(pageNumber, pageSize);
            return View(bookList);
        }
        public IActionResult bio(string search, int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 12;
            var bookList = _db.books.Include("genres").Include("mainGenres").Include("typeOfBooks").Include("authors").Where(b => b.genres.genreID == 6).Where(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null).OrderBy(y => y.bookID).ToList().ToPagedList(pageNumber, pageSize);
            return View(bookList);
        }
        public IActionResult cbook(string search, int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 12;
            var bookList = _db.books.Include("genres").Include("mainGenres").Include("typeOfBooks").Include("authors").Where(b => b.typeOfBooks.typeOfBookID == 3).Where(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null).OrderBy(y => y.bookID).ToList().ToPagedList(pageNumber, pageSize);
            return View(bookList);
        }
        public IActionResult drama(string search, int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 12;
            var bookList = _db.books.Include("genres").Include("mainGenres").Include("typeOfBooks").Include("authors").Where(b => b.genres.genreID == 5).Where(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null).OrderBy(y => y.bookID).ToList().ToPagedList(pageNumber, pageSize);
            return View(bookList);
        }
        public IActionResult fhistory(string search, int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 12;
            var bookList = _db.books.Include("genres").Include("mainGenres").Include("typeOfBooks").Include("authors").Where(b => b.genres.genreID == 3 && b.mainGenres.mainGenreID == 1).Where(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null).OrderBy(y => y.bookID).ToList().ToPagedList(pageNumber, pageSize);
            return View(bookList);
        }
        public IActionResult fiction(string search, int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 12;
            var bookList = _db.books.Include("genres").Include("mainGenres").Include("typeOfBooks").Include("authors").Where(b => b.mainGenres.mainGenreID == 1).Where(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null).OrderBy(y => y.bookID).ToList().ToPagedList(pageNumber, pageSize);
            return View(bookList);
        }
        public IActionResult learn(string search, int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 12;
            var bookList = _db.books.Include("genres").Include("mainGenres").Include("typeOfBooks").Include("authors").Where(b => b.genres.genreID == 7).Where(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null).OrderBy(y => y.bookID).ToList().ToPagedList(pageNumber, pageSize);
            return View(bookList);
        }
        public IActionResult nonfhistory(string search, int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 12;
            var bookList = _db.books.Include("genres").Include("mainGenres").Include("typeOfBooks").Include("authors").Where(b => b.genres.genreID == 3 && b.mainGenres.mainGenreID == 2).Where(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null).OrderBy(y => y.bookID).ToList().ToPagedList(pageNumber, pageSize);
            return View(bookList);
        }
        public IActionResult nonFiction(string search, int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 12;
            var bookList = _db.books.Include("genres").Include("mainGenres").Include("typeOfBooks").Include("authors").Where(b => b.mainGenres.mainGenreID == 2).Where(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null).OrderBy(y => y.bookID).ToList().ToPagedList(pageNumber, pageSize);
            return View(bookList);
        }
        public IActionResult romance(string search, int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 12;
            var bookList = _db.books.Include("genres").Include("mainGenres").Include("typeOfBooks").Include("authors").Where(b => b.genres.genreID == 4).Where(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null).OrderBy(y => y.bookID).ToList().ToPagedList(pageNumber, pageSize);
            return View(bookList);
        }
        public IActionResult tbook(string search, int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 12;
            var bookList = _db.books.Include("genres").Include("mainGenres").Include("typeOfBooks").Include("authors").Where(b => b.typeOfBooks.typeOfBookID == 2).Where(x => x.authors.author_firstname.Contains(search) || x.authors.author_lastname.Contains(search) || x.book_title.Contains(search) || (x.authors.author_firstname + " " + x.authors.author_lastname).Contains(search) || search == null).OrderBy(y => y.bookID).ToList().ToPagedList(pageNumber, pageSize);
            return View(bookList);
        }

        private void PopulateLookups(book books)
        {
            var author = _db.authors.OrderBy(p => p.author_firstname).ToList();
            ViewBag.authorID = author.Select(p => new SelectListItem
            {
                Value = p.authorID.ToString(),
                Text = p.author_firstname + " " + p.author_lastname,
                Selected = p.authorID == books.authorID,
            });

            var genre = _db.genres.OrderBy(p => p.genreID).ToList();
            ViewBag.genreID = genre.Select(p => new SelectListItem
            {
                Value = p.genreID.ToString(),
                Text = p.genre_name,
                Selected = p.genreID == books.genreID,
            });

            var mainGenre = _db.mainGenres.OrderBy(p => p.mainGenreID).ToList();
            ViewBag.mainGenreID = mainGenre.Select(p => new SelectListItem
            {
                Value = p.mainGenreID.ToString(),
                Text = p.mainGenre_name,
                Selected = p.mainGenreID == books.mainGenreID,
            });

            var type = _db.typeOfBooks.OrderBy(p => p.typeOfBookID).ToList();
            ViewBag.typeOfBookID = type.Select(p => new SelectListItem
            {
                Value = p.typeOfBookID.ToString(),
                Text = p.typeOfBook_name,
                Selected = p.typeOfBookID == books.typeOfBookID,
            });
        }

        [HttpGet]

        public IActionResult insertBook()
        {
            book books = new book();
            PopulateLookups(books);
            return View(books);
        }

        [HttpPost]

        public IActionResult insertBook(book books)
        {
            if (ModelState.IsValid)
            {
                _db.books.Add(books);
                _db.SaveChanges();
                return RedirectToAction("fiction");
            }
            PopulateLookups(books);
            return View(books);
        }

        public IActionResult deleteBook(int id)
        {
            book books = _db.books.Find(id);
            _db.books.Remove(books);
            _db.SaveChanges();
            return Redirect(Request.Headers["Referer"]);
        }

        [HttpGet]

        public IActionResult editBook(int id)
        {
            var books = _db.books.Where( b => b.bookID == id).FirstOrDefault();
            PopulateLookups(books);
            return View(books);
        }

        [HttpPost]

        public IActionResult editBook(book books)
        {
            if (ModelState.IsValid)
            {
                var book = _db.books.Where(b => b.bookID == books.bookID).FirstOrDefault();
                _db.books.Remove(book);
                _db.books.Add(books);
                _db.SaveChanges();
               
            }
            return RedirectToAction("fiction");

        }
    }
}
