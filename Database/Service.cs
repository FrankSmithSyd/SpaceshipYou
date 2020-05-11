using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Database
{
    public class Services
    {
        public Services()
        {
            var services = new ServiceCollection()
                .AddEntityFrameworkSqlServer()
                .AddSingleton<Services>()
                .BuildServiceProvider();
            
            
        }

//
//
//        private void AddDbContextToServices(ServiceCollection services)
//        {
//            services.AddDbContext<CalendarContext>(options => options.UseSqlServer (Configuration.GetConnectionString("DefaultConnection")));
//        }
    }
}