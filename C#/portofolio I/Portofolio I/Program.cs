var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
app.MapGet("/", () => "Hello World!");

app.Run();

///////////////////////////

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/test2", (int num)){
    if(if num%2==0){"this is Even number"}

    }
}