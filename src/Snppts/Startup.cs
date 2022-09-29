using Autofac;
using Autofac.Extensions.DependencyInjection;
using Snppts.AutofacModules;

namespace Snppts;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IContainer Container { get; private set; }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public IServiceProvider ConfigureServices(IServiceCollection services)
    {
        services.Configure<CookiePolicyOptions>(options =>
        {
            // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            options.CheckConsentNeeded = context => true;
            options.MinimumSameSitePolicy = SameSiteMode.None;
        });

        var mvcBuilder = services.AddMvc();
        mvcBuilder.AddMvcOptions((o) => o.EnableEndpointRouting = false);

        ////Added by Naweed Akram on 29-Sep-2022 to enable API on the website

        //Start of API related section 

        //Add Case Sentitive Json Naming ro response
        mvcBuilder.AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

        //Add in-memory caching
        services.AddMemoryCache();

        //Caching response for middlewares
        services.AddResponseCaching(x => x.UseCaseSensitivePaths = true);

        //Response compression for improved performance
        services.AddResponseCompression();

        //End of API related section 

        // Create the container builder.
        var builder = new ContainerBuilder();
        builder.Populate(services);
        builder.RegisterModule(new SnippetModule());
        
        Container = builder.Build();

        return new AutofacServiceProvider(this.Container);
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

        app.UseStaticFiles();
        app.UseCookiePolicy();

        ////Added by Naweed Akram on 29-Sep-2022 to enable API on the website

        //Start of API related section 

        app.UseRouting();
        app.UseResponseCompression();
        app.UseResponseCaching();

        //End of API related section 

        app.UseMvc(routes =>
        {
            routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}