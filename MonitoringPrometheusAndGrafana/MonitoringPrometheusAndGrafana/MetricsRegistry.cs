using App.Metrics;
using App.Metrics.Counter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringPrometheusAndGrafana
{
    public class MetricsRegistry
    {
        public static CounterOptions CreatedUserCounter => new CounterOptions
        {
            Name = "Created Users",
            Context = "UsersApi",
            MeasurementUnit = Unit.Calls
        };
        public static CounterOptions CreatedDbConnectionCounter => new CounterOptions
        {
            Name = "Created db Connections",
            Context = "Database",
            MeasurementUnit = Unit.Calls
        };
    }
}
