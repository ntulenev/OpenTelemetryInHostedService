using System.Runtime.CompilerServices;

namespace OTExample.Metrics
{
    public interface IMetricsUtil
    {
        public IDisposable MeasureTime([CallerMemberName] string name = "");
    }
}
