using Microsoft.EntityFrameworkCore;
using App.Data.Context;
using App.Business.Services;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO.Converters;
using NetTopologySuite;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(o => o.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add services
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<PlaceService>();
builder.Services.AddScoped<CountryService>();
builder.Services.AddScoped<LoginService>();
builder.Services.AddScoped<LicenseService>();

builder.Services.AddControllers(options =>
{
    options.ModelMetadataDetailsProviders.Add(new SuppressChildValidationMetadataProvider(typeof(Polygon)));
});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    var geoJsonConverterFactory = new GeoJsonConverterFactory();
    options.JsonSerializerOptions.Converters.Add(geoJsonConverterFactory);
});

builder.Services.AddSingleton(NtsGeometryServices.Instance);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corsapp");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


