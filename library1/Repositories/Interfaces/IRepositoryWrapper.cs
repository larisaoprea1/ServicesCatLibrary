namespace library1.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        ILibraryRepository LibraryRepository { get; }
        IAuthorsRepository AuthorsRepository {get; }
        IMainGenreRepository MainGenreRepository {get; }
        IGenreRepository GenreRepository {get; }
        ITypeOfBooksRepository TypeOfBooksRepository {get; }
        void Save();
    }
}