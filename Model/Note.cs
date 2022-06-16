namespace WebApiNotes.Model;

public class Note
{
    
    public int NoteId { get; set; }
    
    public string Title { get; set; }
    
    public string TextNote { get; set; }
    
    public DateTime DateCreated { get; set; }
    
    public DateTime DateChanged { get; set; }
}