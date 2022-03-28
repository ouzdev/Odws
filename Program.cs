var builder = WebApplication.CreateBuilder(new WebApplicationOptions{
    EnvironmentName = Environments.Development
});
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.MapGet("/", () => "Hello World!");

app.Run();


