using OTExample.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHostedService<SomeService>();
var app = builder.Build();
await app.RunAsync();
