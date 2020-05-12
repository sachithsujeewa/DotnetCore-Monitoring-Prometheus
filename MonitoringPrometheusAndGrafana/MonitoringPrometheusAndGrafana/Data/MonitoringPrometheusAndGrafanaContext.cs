using Microsoft.EntityFrameworkCore;
using MonitoringPrometheusAndGrafana.Models;

namespace MonitoringPrometheusAndGrafana.Data
{
    public class MonitoringPrometheusAndGrafanaContext : DbContext
    {
        public MonitoringPrometheusAndGrafanaContext (DbContextOptions<MonitoringPrometheusAndGrafanaContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
