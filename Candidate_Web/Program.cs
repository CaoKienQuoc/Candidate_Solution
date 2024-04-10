using CandidateRepository.IRepository;
using CandidateRepository.Repository;
using CandidateService.IService;
using CandidateService.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSession();

builder.Services.AddScoped<IHRAccountService, HRAccountService>();
builder.Services.AddScoped<IHRAccountRepository, HRAccountRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
