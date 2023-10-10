using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;

namespace RepositoryPattern.Data.EFCore
{
    public class RepositoryPatternContext : DbContext
    {
        public RepositoryPatternContext(DbContextOptions<RepositoryPatternContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
        public DbSet<Star> Stars { get; set; } = default!;
    }
}
