using Microsoft.EntityFrameworkCore;
using RajwadiBus.Web.Shared;

namespace RajwadiBus.Web.Server.Data
{
    public class RajwadiBusDBContext : DbContext
    {
        public RajwadiBusDBContext(DbContextOptions<RajwadiBusDBContext> options) : base(options) { }

        public DbSet<BusMaster> BusMasters { get; set; }
    }
}