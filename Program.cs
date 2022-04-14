var builder = WebApplication.CreateBuilder(args);
builder.Services.UseAutoMapper();
builder.Services.UseOdwsDbContext(builder);
builder.Services.UseSwagger();
builder.Host.UseSerilogExtension();
var app = builder.Build();
app.DevelopmentEnvCheck();
app.NoteEndpoints();
app.Run();

