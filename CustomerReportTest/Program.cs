using Blazored.SessionStorage;
using CustomerReportTest.Components;
using CustomerReportTest.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<OrganizationService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7220/");
});

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddBlazorBootstrap();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<OrganizationService>();
builder.Services.AddBlazoredSessionStorage();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
