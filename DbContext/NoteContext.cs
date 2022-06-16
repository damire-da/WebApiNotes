using Microsoft.EntityFrameworkCore;
using WebApiNotes.Model;

namespace WebApiNotes;

public class NoteContext : DbContext
{
    public DbSet<Note> Note { get; set; }

    public NoteContext(DbContextOptions<NoteContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}