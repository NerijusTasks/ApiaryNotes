using ApiaryNotes.Web.Models;
using ApiaryNotes.Web.Models.Hive;
using ApiaryNotes.Web.Models.Notes;
using ApiaryNotes.Web.Models.Products;
using ApiaryNotes.Web.Models.Treatments;
using Microsoft.EntityFrameworkCore;

namespace ApiaryNotes.Web.Services
{
    public class AppsDbContext : DbContext
    {
        public AppsDbContext(DbContextOptions<AppsDbContext> options) : base(options) { }

        public DbSet<Hives> Hives { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<BeeBread> BeeBreads { get; set; }
        public DbSet<Honey> Honeys { get; set; }
        public DbSet<Pollen> Pollens { get; set; }
        public DbSet<Wax> Waxes { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<ApiarySection> ApiarySections { get; set; }

    }
}

