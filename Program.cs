using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Odws.Models;
using Serilog;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    EnvironmentName = Environments.Development
});

builder.Services.UseAutoMapper();
builder.Services.UseOdwsDbContext(builder);
builder.Services.UseSwagger();
builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.Console());
var app = builder.Build();

#region Environment check
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1"));
}
#endregion

app.MapGet("/Notes", async (OdwsDatabaseContext context) =>
{

    var notes = await context.Notes.ToListAsync();
    return notes;
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

app.Run();