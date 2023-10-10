using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Data.EFCore;
using RepositoryPattern.Models;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsController : MyMDBController<Star, EfCoreStarRepository>
    {
        public StarsController(EfCoreStarRepository repository) : base(repository)
        {

        }
    }
}
