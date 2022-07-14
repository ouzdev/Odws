using Odws.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(p => p.AddPolicy("odwsapp", builder =>
 {
     builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
 }));
builder.Services.AddPersistenceService(builder.Configuration);
builder.Services.UseSwagger();
builder.Host.UseSerilogExtension();
var app = builder.Build();
app.DevelopmentEnvCheck();
app.UseCors("odwsapp");
app.NoteEndpoints();
app.Run();

