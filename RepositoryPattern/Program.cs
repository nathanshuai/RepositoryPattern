using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RepositoryPattern.Data.EFCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RepositoryPatternContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RepositoryPatternContext") ?? throw new InvalidOperationException("Connection string 'RepositoryPatternContext' not found.")));

// Add services to the container.
builder.Services.AddScoped<EfCoreMovieRepository>();
builder.Services.AddScoped<EfCoreStarRepository>();

// Add services to the container.
builder.Services.AddControllersWithViews(options =>
{
    options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true;
});

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
app.UseAuthorization();

app.MapControllers();

app.Run();
