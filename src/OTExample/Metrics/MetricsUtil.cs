using System.Runtime.CompilerServices;

namespace OTExample.Metrics
{
    public class MetricsUtil : IMetricsUtil
    {
        public IDisposable MeasureTime([CallerMemberName] string name = "")
        {
            throw new NotImplementedException();
        }
    }
}
