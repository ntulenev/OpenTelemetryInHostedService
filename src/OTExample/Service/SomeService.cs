namespace OTExample.Service
{
    public class SomeService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                stoppingToken.ThrowIfCancellationRequested();

                await Task.Delay(_rnd.Next(1000, 5000), stoppingToken); // Some work
            }
        }

        private readonly Random _rnd = new();
    }
}
