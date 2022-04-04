using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Odws.Models;

#region Create Builder
var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    EnvironmentName = Environments.Development
});
#endregion

#region AutoMapper
var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new NoteProfile());
});
IMapper autoMapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(autoMapper);
#endregion

#region Db context
var connectionString = builder.Configuration.GetConnectionString("PostgreSQLConnection");
builder.Services.AddDbContext<OdwsDatabaseContext>(x => x.UseNpgsql(connectionString));
#endregion

#region Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header'da Bearer eklemenize gerek yoktur. Örnek: \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
  {
    {
      new OpenApiSecurityScheme
      {
        Reference = new OpenApiReference
        {
          Type = ReferenceType.SecurityScheme,
          Id = "Bearer"
        },
        Scheme = "oauth2",
        Name = "Bearer",
        In = ParameterLocation.Header,

      },
      new List<string>()
    }});
});
#endregion

#region Builder build
var app = builder.Build();

#endregion

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


