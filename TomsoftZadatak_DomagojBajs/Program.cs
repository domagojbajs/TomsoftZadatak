using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient("api", c=>
{
    c.BaseAddress = new Uri(configuration.GetValue<string>("ApiUrl"));
    c.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue(
        "Basic", Convert.ToBase64String(
            System.Text.ASCIIEncoding.ASCII.GetBytes(configuration.GetValue<string>(
               "Login"))));
});
//builder.Services.AddHttpClient() dovrsit dodavanje apija iz appsettings

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
