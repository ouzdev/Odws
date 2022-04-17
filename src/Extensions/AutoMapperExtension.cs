using AutoMapper;

public static class AutoMapperExtension
{
    public static IServiceCollection UseAutoMapper(this IServiceCollection services)
    {
        var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new NoteProfile());
});
        IMapper autoMapper = mappingConfig.CreateMapper();
        services.AddSingleton(autoMapper);
        return services;
    }
}