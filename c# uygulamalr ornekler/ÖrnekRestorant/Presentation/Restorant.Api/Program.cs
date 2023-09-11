using Restorant.Persistence;
using FluentValidation.AspNetCore;
using Restorant.Application.ViewModel._Customer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

#region Services my
builder.Services.AddPersistanceService();
builder.Services.AddControllers().AddFluentValidation(c => c.RegisterValidatorsFromAssemblyContaining<VM_Customer_Create>());
#endregion



var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
