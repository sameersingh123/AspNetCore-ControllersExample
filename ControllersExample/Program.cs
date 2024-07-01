var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();  //Adds all the controller classes as services.
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();  //Enables the static files to be served from the wwwroot folder.

app.UseRouting();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();  //Enables the routing for each action method in the controller classes.
//});

app.MapControllers();  //adds all the action methods as endpoints //Combines the above three lines of code.(UseRouting, UseEndpoints)

app.Run();
