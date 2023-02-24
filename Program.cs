//Additions added at the advice of https://www.youtube.com/watch?v=R23v4lgHYQI&list=PLdo4fOcmZ0oW8nviYduHq7bmKode-p8Wy&index=10

namespace MyWebApp.Website
{
public class Program 
{
public static void Main(string[] args)
{

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//My little additions
builder.Services.AddServerSideBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

//My little addtions 2.0 Electric Boogaloo
app.MapBlazorHub();

app.Run();

}
}
}