using MOM3.Models;
using Microsoft.EntityFrameworkCore;

namespace MOM3.Data;

public class Mom3DbContext : DbContext {
    public Mom3DbContext(DbContextOptions<Mom3DbContext> options) : base(options) { }

    public DbSet<BookModel> Books { get; set; }
    public DbSet<GenreModel> Genres { get; set; }
}

//dsf