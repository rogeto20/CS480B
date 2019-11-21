using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using quotable.core;
using quotable.core.data;
using System;
using System.Collections.Generic;
using System.IO;

namespace quotable.api
{
    /// <summary>
    /// This is the startup class for the API
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// This is the startup constructor
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// This Configurations object for the startup class
        /// </summary>
        public IConfiguration Configuration { get; }

        /// This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            // setup to use a sqlite database
            services.AddDbContext<QuoteContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

        }

        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<QuoteContext>();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                PopulateDatabase(context);
            }
        }

        private static void PopulateDatabase(QuoteContext context)
        {
            string[] lines = File.ReadAllLines(Constants.RemoteFilePath);


            Quotes quote1 = new Quotes();
            //quote.Id = Array.IndexOf(lines, line);
            quote1.Quote = "This is a test";

            //QuoteAuthor quoteAuthor = new QuoteAuthor() { Quote = quote1, Author = author };
            //context.AddRange(quoteAuthor);
            //context.SaveChanges();

            foreach (string line in lines)
            {
                Author author = new Author()
                {
                    FirstName = "Ray",
                    LastName = "Hudson"
                };
                Quotes quote = new Quotes();
                quote.Quote = line;
                
                QuoteAuthor quoteAuthor = new QuoteAuthor() { Quote = quote, Author = author };
                context.AddRange(quoteAuthor);
                context.SaveChanges();
            }
        }
    }
}
