using CongestionTaxCalculator.Application.SeedWorks;
using CongestionTaxCalculator.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string Policy = "AllowAll";

builder.Services.AddCors(options => options.AddPolicy(Policy, p => p.AllowAnyOrigin()
                                                                    .AllowAnyMethod()
                                                                    .AllowAnyHeader()));
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationLayerEntryPoint).Assembly));
builder.Services.AddAutoMapper(typeof(ApplicationLayerEntryPoint).Assembly);

builder.Services.AddAppDbContext(builder.Configuration.GetConnectionString("DefaultConnection"));
builder.Services.AddRepositories();
builder.Services.AddUnitOfWork();
builder.Services.AddServices();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}
app.EnsureMigrationOfContext<AppDbContext>();

app.Run();
