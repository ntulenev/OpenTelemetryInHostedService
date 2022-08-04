using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace OTExample.Metrics
{
    public class MetricsUtil : IMetricsUtil, IDisposable
    {
        public MetricsUtil()
        {
            _activitySource = new ActivitySource(MetricsConstantcs.SERVICE_NAME);
        }

        public void Dispose() => _activitySource.Dispose();

        public IDisposable MeasureTime([CallerMemberName] string name = "") =>
            _activitySource.StartActivity(name) ?? throw new ArgumentException($"No activity listeners for {name}", nameof(name));

        private readonly ActivitySource _activitySource;
    }
}
