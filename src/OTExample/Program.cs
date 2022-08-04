using OTExample.Metrics;
using OTExample.Service;

using var _ = ConsoleMetricsProvider.Init();

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IMetricsUtil, MetricsUtil>();
builder.Services.AddHostedService<SomeService>();

var app = builder.Build();
await app.RunAsync();
