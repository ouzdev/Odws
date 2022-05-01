using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Odws.Models;
using Odws.Utilities.Result;

public static class NoteEndpoint
{
    public static WebApplication NoteEndpoints(this WebApplication app)
    {
        app.MapGet("/Notes", async (OdwsDatabaseContext context, IMapper mapper) =>
        {
           var notes = await context.Notes.ToListAsync();
           var notesDto = mapper.Map<List<NoteReadDto>>(notes);
           return new SuccessDataResult<List<NoteReadDto>>(notesDto,"Notes retrieved");
        });
        app.MapPost("/Notes", async (NoteCreateDto addNote, OdwsDatabaseContext context, IMapper mapper) =>
        {
            var _mappedUser = mapper.Map<Note>(addNote);
            await context.Notes.AddAsync(_mappedUser);
            await context.SaveChangesAsync();
        });
        app.MapPost("/Notes/{id}", async (NoteUpdateDto updateNote, OdwsDatabaseContext context, IMapper mapper) =>
        {
            var _mappedUser = mapper.Map<Note>(updateNote);
            context.Notes.Update(_mappedUser);
            await context.SaveChangesAsync();
        });
        app.MapDelete("/Notes/{id}", async (OdwsDatabaseContext context, int id) =>
        {
            var note = await context.Notes.FirstOrDefaultAsync(x => x.Id == id);
            if (note == null)
            {
                return;
            }
            context.Notes.Remove(note);
            await context.SaveChangesAsync();
        });

        return app;
    }
}