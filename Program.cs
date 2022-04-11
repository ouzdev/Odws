using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Odws.Models;

#region Create Builder
var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    EnvironmentName = Environments.Development
});
#endregion

builder.Services.UseAutoMapper();
builder.Services.UseOdwsDbContext(builder);
builder.Services.UseSwagger();

var app = builder.Build();

#region Environment check
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1"));
}
#endregion


app.MapGet("/", () => "Odws Not Uygulamasına Hoşgeldiniz.");
app.MapGet("/Notes", async (OdwsDatabaseContext context) =>
{

    var notes =await context.Notes.ToListAsync();
    return notes;
});
app.MapPost("/Notes", async (NoteCreateDto addNote, OdwsDatabaseContext context,IMapper mapper) =>
{
      var _mappedUser = mapper.Map<Note>(addNote);
     await context.Notes.AddAsync(_mappedUser);
     await context.SaveChangesAsync();
}
    );

app.Run();