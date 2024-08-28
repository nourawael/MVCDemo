namespace MVCDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseRouting();
            app.UseStaticFiles();

            #region 
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You are at Home Page");
            //    });


            //    endpoints.MapGet("/Products/{id?: int?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["id"];
            //        if (idData is not null)
            //        {
            //            int id = Convert.ToInt32(idData);
            //            await context.Response.WriteAsync($"You requested Product with id ->{id}");
            //        }
            //        else
            //            await context.Response.WriteAsync("You are at Products Page");

            //    });
            //    endpoints.MapGet("/Books/{id}/{author:alpha:minlength(4):maxlength(6)}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //        string author = context.Request.RouteValues["author"].ToString();

            //        await context.Response.WriteAsync($"You requested Product with id ->{id} and author-> {author}");
            //    });
            //});
            //app.Run(async (HttpContent) => 
            //{
            //    await HttpContent.Response.WriteAsync("Your Requested Page Not found");

            //});
            #endregion


            app.MapControllerRoute(
                name:"default",
                pattern: "/{Controller=Home}/{Action=Index}",
                defaults: new {Controller="Home", Action="Index"}
                );


            app.Run();
        }
    }
}
