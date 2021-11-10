using Astro.Data;
using Astro.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Astro
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<AppUser, AppRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders().AddDefaultUI();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddServerSideBlazor();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                // Normally, you would have .MapBlazorHub() and /MapFallbackToPage("/_Host") here.
                //
                // The change below puts your Blazor content under /Blazor (YourSite.com/Blazor/SomePage). This serves a few purposes:
                //  - Eliminates the possibility of conflicts with existing MVC routes.
                //  - Ordinarily, Blazor takes over the default route (YourSite.com with no path) which can be problematic.
                //    Our goal is to avoid interfering with existing MVC behavior.
                // 
                // Some day, if the entire MVC app is ever completely re-worked in Blazor, you could change this
                // back to the typical settings, tweak a few other minor changes in _Host that support this, and perhaps have a party.
                endpoints.MapBlazorHub("/Blazor/_blazor");
                endpoints.MapFallbackToPage("~/Blazor/{*clientroutes:nonfile}", "/Blazor/_Host");
            });
        }
    }
}