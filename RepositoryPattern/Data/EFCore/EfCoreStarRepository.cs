using RepositoryPattern.Models;

namespace RepositoryPattern.Data.EFCore
{
    public class EfCoreStarRepository : EfCoreRepository<Star, RepositoryPatternContext>
    {
        public EfCoreStarRepository(RepositoryPatternContext context) : base(context)
        {

        }
    }
}
