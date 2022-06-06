using library1.Models;
using library1.Repositories.Interfaces;

namespace library1.Repositories
{
    public class LibraryRepository : RepositoryBase<book>, ILibraryRepository
    {
        public LibraryRepository(libraryContext libraryContext)
            : base(libraryContext)
        {
        }
    }
    public class AuthorsRepository : RepositoryBase<author>, IAuthorsRepository
    {
        public AuthorsRepository(libraryContext libraryContext)
            : base(libraryContext)
        {
        }
    }
    public class MainGenreRepository : RepositoryBase<mainGenre>, IMainGenreRepository
    {
        public MainGenreRepository(libraryContext libraryContext)
            : base(libraryContext)
        {
        }
    }
    public class GenreRepository : RepositoryBase<genre>, IGenreRepository
    {
        public GenreRepository(libraryContext libraryContext)
            : base(libraryContext)
        {
        }
    }
    public class TypeOfBooksRepository : RepositoryBase<typeOfBook>, ITypeOfBooksRepository
    {
        public TypeOfBooksRepository(libraryContext libraryContext)
            : base(libraryContext)
        {
        }
    }
}