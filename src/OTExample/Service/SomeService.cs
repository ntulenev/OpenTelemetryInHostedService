using OTExample.Metrics;

namespace OTExample.Service
{
    public class SomeService : BackgroundService
    {
        public SomeService(IMetricsUtil metrics)
        {
            _metrics = metrics ?? throw new ArgumentNullException(nameof(metrics));
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                stoppingToken.ThrowIfCancellationRequested();
                await DoWorkAsync(stoppingToken);

            }
        }

        private async Task DoWorkAsync(CancellationToken ct)
        {
            using var _ = _metrics.MeasureTime();
            await Task.Delay(_rnd.Next(1000, 5000), ct); // Some work
        }

        private readonly IMetricsUtil _metrics;
        private readonly Random _rnd = new();
    }
}
