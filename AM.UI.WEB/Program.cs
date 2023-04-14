using AM.Application.Core.Interfaces;
using AM.Application.Core.Services;
using AM.ApplicationCore.Interfaces;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IServiceFlight,ServiceFlight>();
// meme logique que above IServiceFlight service=new ServiceFlight(UOW)
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
//meme logique que above IUnitofWork UOW=new UnitofWork(dbContext,Type)
builder.Services.AddDbContext<DbContext, AmContext>();
//DbContext dbContext=new AmContext();
builder.Services.AddSingleton<Type>(p=>typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
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
