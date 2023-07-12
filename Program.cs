global using FastEndpoints;
using Coupon.GetCouponList;
using Dom;
using FastEndpoints.Swagger; //add this
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder();
builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument(); //define a swagger document
builder.Services.AddDbContext<FastEndPoints_DemoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<Data>();
var app = builder.Build();
app.UseAuthorization();
app.UseFastEndpoints();
app.UseSwaggerGen(); //add this
app.Run();
