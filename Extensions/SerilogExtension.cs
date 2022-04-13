using Serilog;

public static class SerilogExtension
{
    public static void UseSerilogExtension(this IHostBuilder builder)
    {
      builder.UseSerilog((ctx, lc) => lc
      .WriteTo.Debug()
    .WriteTo.Console()
    .WriteTo.Seq("http://localhost:5341")
    .WriteTo.File(@"logs\log.txt", rollingInterval: RollingInterval.Day));

    
    }
}