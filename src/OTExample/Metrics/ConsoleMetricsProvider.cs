using OpenTelemetry;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace OTExample.Metrics
{
    public static class ConsoleMetricsProvider
    {
        public static IDisposable Init()
        {
            return Sdk.CreateTracerProviderBuilder()
           .AddSource(MetricsConstantcs.SERVICE_NAME)
           .SetResourceBuilder(
                ResourceBuilder.CreateDefault()
               .AddService(serviceName: MetricsConstantcs.SERVICE_NAME))
           .AddConsoleExporter()
           .Build();
        }
    }
}
