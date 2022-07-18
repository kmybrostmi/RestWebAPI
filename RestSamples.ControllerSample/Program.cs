using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddNewtonsoftJson();

builder.Services.Configure<MvcNewtonsoftJsonOptions>(c =>
{
    c.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
});

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();
