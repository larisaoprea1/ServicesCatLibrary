using library1.Models;

namespace library1.Repositories.Interfaces
{
    public interface ILibraryRepository : IRepositoryBase<book>
    {
    }
    public interface IAuthorsRepository : IRepositoryBase<author>
    {
    }
    public interface IMainGenreRepository : IRepositoryBase<mainGenre>
    {
    }
    public interface IGenreRepository : IRepositoryBase<genre>
    {
    }
    public interface ITypeOfBooksRepository : IRepositoryBase<typeOfBook>
    {
    }
}