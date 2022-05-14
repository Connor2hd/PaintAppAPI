using Microsoft.EntityFrameworkCore;
using PaintAppAPI.Models;

namespace PaintAppAPI.Models
{
    public class PaintContext : DbContext
    {
        public PaintContext(DbContextOptions<PaintContext> options)
            : base(options)
        {
        }

        public DbSet<Paint>? PaintItems { get; set; } = null!;

        public DbSet<Manufacturer>? Manufacturer { get; set; }

        public DbSet<PaintAppAPI.Models.PaintGroup>? PaintGroup { get; set; }

        public DbSet<PaintAppAPI.Models.UserPaint>? UserPaint { get; set; }

        public DbSet<PaintAppAPI.Models.User>? User { get; set; }
    }
}
