using A2Mac1.Costino.Application.Extensions;
using A2Mac1.Costino.Application.MappingProfiles;
using A2Mac1.Costino.Application.Services.Contracts;
using A2Mac1.Costino.Application.Services.ProjectService;
using A2Mac1.Costino.DataAccess.Contracts;
using A2Mac1.Costino.DataAccess.Data;
using A2Mac1.Costino.DataAccess.Repositories;

using NLog;

LogFactory? logger = LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>();
builder.Services.AddTransient<DataSeeder>();
builder.Services.AddAutoMapper(typeof(IMappingProfilesMarker));
builder.Services.AddScoped<IEquipmentRepository, EquipmentRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<IProjectService, ProjectService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
}); ;

builder.Services.AddControllers();
builder.Services.ConfigureLoggerService();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication? app = builder.Build();

using IServiceScope? serviceScop = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();

try
{
    DataContext? context = serviceScop.ServiceProvider.GetService<DataContext>();

    if (context is null)
    {
        Console.WriteLine("Data context was null while initializing app");
        return;
    }

    await DataSeeder.Seed(context);
}
catch (Exception ex)
{
    Console.WriteLine($"Error while initializing data context:{Environment.NewLine}{ex}");
    return;
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();