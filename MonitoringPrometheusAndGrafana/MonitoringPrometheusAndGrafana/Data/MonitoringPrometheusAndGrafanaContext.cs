using App.Metrics;
using Microsoft.EntityFrameworkCore;
using MonitoringPrometheusAndGrafana.Models;

namespace MonitoringPrometheusAndGrafana.Data
{
    public class MonitoringPrometheusAndGrafanaContext : DbContext
    {
        private readonly IMetrics _metrics;
        public MonitoringPrometheusAndGrafanaContext (DbContextOptions<MonitoringPrometheusAndGrafanaContext> options, IMetrics metrics)
            : base(options)
        {
            _metrics = metrics;
            _metrics.Measure.Counter.Increment(MetricsRegistry.CreatedDbConnectionCounter);
        }

        public DbSet<User> User { get; set; }
    }
}
