namespace ObraSocial_App.Web
{
    using Business;
    using Dato.Helper;
    using Dato.ModelsAcceso.Entities;
    using Dato.ModelsCore;
    using Dato.ModelsCore.Entities;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>(cfg =>
            {
                cfg.User.RequireUniqueEmail = true;
                cfg.Password.RequireDigit = false;
                cfg.Password.RequiredUniqueChars = 0;
                cfg.Password.RequireLowercase = false;
                cfg.Password.RequireNonAlphanumeric = false;
                cfg.Password.RequireUppercase = false;
                cfg.Password.RequireDigit = false;
                cfg.Password.RequiredLength = 6;
            }).AddEntityFrameworkStores<DataContextCore>();

            services.AddControllersWithViews();
            services.AddMvc();
            services.AddDbContext<DataContextCore>(cfg => cfg.UseSqlServer(Configuration.GetConnectionString("dbOsdopCoreEntities")));
            //services.AddDbContext<DBConRRHH>(options => options.UseSqlServer(Configuration.GetConnectionString("osdoprrhhEntities"))); //agregado de conexion string rrhh 
            services.AddDbContext<DBConAcceso>(options => options.UseSqlServer(Configuration.GetConnectionString("accesoEntities")));//agregado de conexion string acceso

            services.AddTransient<SeedDb>();
            services.AddTransient<SeedDbCoreInDato>();


            services.AddScoped<IRepository, Repository>(); //  por ahora se deja usa las otras tablas que estan en las bases internas de osdop
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IUserHelper, UserHelper>();
            services.AddScoped<aplicacionBusiness>();
            //services.AddScoped<IRepository, MockRepository>(); //se la interfaz para cambiar rapidamente entre repositorios Quizas uno de prueba y
            //luego el real... o para pruebas unitarias

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCookiePolicy();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
