using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Astro.Areas.Identity.IdentityHostingStartup))]

namespace Astro.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}