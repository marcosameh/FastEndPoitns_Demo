global using FastEndpoints;
using Dom;
using FastEndPoint_Demo.Middleware;
using FastEndpoints.Swagger; //add this
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder();
builder.Services.AddDbContext<FastEndPoints_DemoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument();

var app = builder.Build();
app.UseAuthorization();
app.UseFastEndpoints();
app.UseSwaggerGen(); //add this
//app.UseMiddleware<ApiKeyAuthenticationMiddleware>();
app.Run();