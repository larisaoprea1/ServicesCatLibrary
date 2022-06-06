using library1.Models;
using library1.Repositories.Interfaces;

namespace library1.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private libraryContext _libraryContext;
        private ILibraryRepository? _libraryRepository;
        private IAuthorsRepository? _authorsRepository;
        private IMainGenreRepository? _maingenreRepository;
        private IGenreRepository? _genreRepository;
        private ITypeOfBooksRepository? _typeOfBooksRepository;

        public ILibraryRepository LibraryRepository
        {
            get
            {
                if (_libraryRepository == null)
                {
                    _libraryRepository = new LibraryRepository(_libraryContext);
                }

                return _libraryRepository;
            }
        }
        public IAuthorsRepository AuthorsRepository
        {
            get
            {
                if (_authorsRepository == null)
                {
                    _authorsRepository = new AuthorsRepository(_libraryContext);
                }

                return _authorsRepository;
            }
        }
        public IMainGenreRepository MainGenreRepository
        {
            get
            {
                if (_maingenreRepository == null)
                {
                    _maingenreRepository = new MainGenreRepository(_libraryContext);
                }

                return _maingenreRepository;
            }
        }
        public IGenreRepository GenreRepository
        {
            get
            {
                if (_genreRepository == null)
                {
                    _genreRepository = new GenreRepository(_libraryContext);
                }

                return _genreRepository;
            }
        }
        public ITypeOfBooksRepository TypeOfBooksRepository
        {
            get
            {
                if (_typeOfBooksRepository == null)
                {
                    _typeOfBooksRepository = new TypeOfBooksRepository(_libraryContext);
                }

                return _typeOfBooksRepository;
            }
        }
        public RepositoryWrapper(libraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public void Save()
        {
            _libraryContext.SaveChanges();
        }
    }
}