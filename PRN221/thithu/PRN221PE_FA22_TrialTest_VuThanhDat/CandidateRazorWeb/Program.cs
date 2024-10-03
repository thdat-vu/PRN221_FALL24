using Candidate_Repositories;
using Candidate_Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
// Add Scoped <Interface, Class> here
// Add Repo + Service
builder.Services.AddScoped<IJobPostingRepo, JobPostingRepo>();
builder.Services.AddScoped<IJobPostingService, JobPosingService>();

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

app.Run();
