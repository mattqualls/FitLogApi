using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitLogApi.Models
{
    public class FitLogApiDbContext : DbContext
    {
        public FitLogApiDbContext(DbContextOptions<FitLogApiDbContext> options)
      : base(options)
    { }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<SessionType> SessionTypes { get; set; }
    }
}
