using RepositoryPattern.Models;

namespace RepositoryPattern.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, RepositoryPatternContext>
    {
        public EfCoreMovieRepository(RepositoryPatternContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
