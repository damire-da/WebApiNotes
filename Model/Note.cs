using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace WebApiNotes.Model;

public class Note
{
    
    private readonly DateTime _date = DateTime.Now;
    public Note()
    {
        DateCreated = DateTime.Now;
        DateChanged = DateTime.Now;
    }
    public int NoteId { get; set; }
    
    public string Title { get; set; }
    
    public string TextNote { get; set; }
    
    [Column(TypeName="datetime2")]
    public DateTime? DateCreated { get; set; }
    [Column(TypeName="datetime2")]
    public DateTime? DateChanged { get; set; }
}