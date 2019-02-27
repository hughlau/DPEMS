using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ResourceManagement;

namespace DpeMs.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.All));
            services.AddScoped<IResourceManifestProvider, ResourceManifestBuilder>();

            services.AddOrchardCms();

            services.Configure<IdentityOptions>(options =>

            {

                options.Password.RequireDigit = false;

                options.Password.RequireLowercase = false;

                options.Password.RequireUppercase = false;

                options.Password.RequireNonAlphanumeric = false;

                options.Password.RequiredUniqueChars = 3;

                options.Password.RequiredLength = 6;

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseOrchardCore();
        }
    }
}
