using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiNotes.Model;
namespace WebApiNotes.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NoteController : ControllerBase
{
    private NoteContext db;

    public NoteController(NoteContext context)
    {
        db = context;
    }

    [HttpGet]
    public JsonResult GetNotes()
    {
        return new JsonResult(db.Note.ToList());
    }
    
    [HttpGet("{id}")]
    [ActionName("Note")]
    public JsonResult GetNoteById(int id)
    {
        return new JsonResult(db.Note.FirstOrDefault(note => note.NoteId == id));
    }
    
    [HttpPost]
    [ActionName("AddNote")]
    public JsonResult AddNote(Note note)
    {
        db.Note.Add(note);
        db.SaveChanges();
        return new JsonResult("Added successfully!");
    }
    
    [HttpPut]
    [ActionName("Update")]
    public JsonResult UpdateNote(Note note)
    {
        db.Note.Update(note);
        db.SaveChanges();
        return new JsonResult("Update successfully!");
    }
    
    [HttpDelete("{id}")]
    [ActionName("Delete")]
    public JsonResult DeleteNote(int id)
    {
        var note = db.Note.FirstOrDefault(x => x.NoteId == id);
        db.Note.Remove(note);
        db.SaveChanges();
        return new JsonResult("Delete successfully!");
    }
}