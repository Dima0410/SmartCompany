using SmartCompany.Authentication;
using SmartCompany.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using SmartCompany.Data.Interfaces;
using SmartCompany.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContextFactory<DBContextTables>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

builder.Services.AddAuthenticationCore();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddSingleton<UserAccountService>();

builder.Services.AddScoped<IPurchase, PurchaseService>();
builder.Services.AddScoped<IOutlay, OutlayService>();
builder.Services.AddScoped<ISale, SaleService>();
builder.Services.AddScoped<IProfit, ProfitService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

//builder.Services.AddServerSideBlazor()
//    .AddHubOptions(options =>
//    {
//        options.ClientTimeoutInterval = TimeSpan.FromSeconds(30);
//        options.HandshakeTimeout = TimeSpan.FromSeconds(15);
//    });

//builder.Services.AddLocalization();
//app.UseRequestLocalization("ru");

app.Run();
