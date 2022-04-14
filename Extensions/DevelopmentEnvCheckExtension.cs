
public static class DevelopmentEnvCheckExtension
{
public static WebApplication DevelopmentEnvCheck(this WebApplication app)
{
    if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1"));
    }

    return app;
}
}
