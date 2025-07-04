using Microsoft.AspNetCore.Builder;


var builder = WebApplication.CreateBuilder(args); 
builder.Services.AddControllersWithViews(); 
builder.Services.AddSingleton<tp2.Models.BaseDeDonnees>();
var app = builder.Build();
 

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseStaticFiles(new StaticFileOptions
    {
        OnPrepareResponse = context => context.Context.Response.Headers.Add("Cache-Control", "no-cache")
    });
}
else
{
    app.UseStaticFiles();
}

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllerRoute(
          name: "default",
          pattern: "{controller}/{action}/{id?}",
          defaults: new { controller = "Home", action = "Index" }
        );
});

app.Run();

// Doc
// Environnements: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-7.0
// Fichiers statiques et wwwroot : https://learn.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-7.0
// Gestion de la cache : https://learn.microsoft.com/en-us/aspnet/core/performance/caching/response?view=aspnetcore-7.0