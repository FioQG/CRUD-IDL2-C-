using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace WebApiAutores
{
    public class Startup(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString ("defaultConnection")));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("vl", new OpenApiInfo
                {
                    Title = "WebApiAutores",
                    Version = "v1",
                });
            });
        }
    }
}
