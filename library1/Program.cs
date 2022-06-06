using Microsoft.EntityFrameworkCore;
using library1.Services;
using library1.Services.Interfaces;
using library1.Repositories;
using library1.Repositories.Interfaces;
using System.Text.Json.Serialization; 
using Microsoft.AspNetCore.Identity;
using library1.Models;

var builder = WebApplication.CreateBuilder(args);
/*var connectionString = builder.Configuration.GetConnectionString("library1ContextConnection") ?? throw new InvalidOperationException("Connection string 'library1ContextConnection' not found.");

builder.Services.AddDbContext<library1Context>(options =>
    options.UseSqlServer(connectionString));;*/
builder.Services.AddRazorPages();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedEmail = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<libraryContext>();builder.Services.AddDbContext<libraryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("libraryDB")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Add(new ServiceDescriptor(typeof(ILog), new ConsoleLogger()));
builder.Services.AddScoped<ILibraryRepository, LibraryRepository>();
builder.Services.AddScoped<ILibraryService, LibraryService>();
builder.Services.AddScoped<IAuthorsRepository, AuthorsRepository>();
builder.Services.AddScoped<IAuthorsService, AuthorsService>();
builder.Services.AddScoped<IMainGenreRepository, MainGenreRepository>();
builder.Services.AddScoped<IMainGenreService, MainGenreService>();
builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddScoped<IGenreService, GenreService>();
builder.Services.AddScoped<ITypeOfBooksRepository, TypeOfBooksRepository>();
builder.Services.AddScoped<ITypeOfBooksService, TypeOfBooksService>();
builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>(); 
 builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
});

//builder.Services.AddDbContext<libraryContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("libraryDB")));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
