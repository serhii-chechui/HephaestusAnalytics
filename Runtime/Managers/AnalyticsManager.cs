using System.Collections.Generic;
using HephaestusMobile.AnalyticsSubsytem.Providers;

namespace HephaestusMobile.AnalyticsSubsytem.Managers {
    public class AnalyticsManager : IAnalyticsManager {
        public List<IAnalyticsProvider> AnalyticsProviders { get; set; }

        public void Initialize() {
            AnalyticsProviders = new List<IAnalyticsProvider>();
        }

        public void AddAnalyticsProvider(IAnalyticsProvider analyticsProvider) {
            AnalyticsProviders.Add(analyticsProvider);
        }

        public void LogEvent(string eventName) {
            foreach (var analyticsProvider in AnalyticsProviders) {
                analyticsProvider.LogEvent(eventName);
            }
        }

        public void LogEvent(string eventName, object eventParameters) {
            foreach (var analyticsProvider in AnalyticsProviders) {
                analyticsProvider.LogEvent(eventName, eventParameters);
            }
        }

        public void LogEvent(string eventName, string eventParameterName, double eventParameter) {
            foreach (var analyticsProvider in AnalyticsProviders) {
                analyticsProvider.LogEvent(eventName, eventParameterName, eventParameter);
            }
        }

        public void LogEvent(string eventName, string eventParameterName, int eventParameter) {
            foreach (var analyticsProvider in AnalyticsProviders) {
                analyticsProvider.LogEvent(eventName, eventParameterName, eventParameter);
            }
        }

        public void LogEvent(string eventName, string eventParameterName, float eventParameter) {
            foreach (var analyticsProvider in AnalyticsProviders) {
                analyticsProvider.LogEvent(eventName, eventParameterName, eventParameter);
            }
        }

        public void LogEvent(string eventName, string eventParameterName, long eventParameter) {
            foreach (var analyticsProvider in AnalyticsProviders) {
                analyticsProvider.LogEvent(eventName, eventParameterName, eventParameter);
            }
        }

        public void LogEvent(string eventName, string eventParameterName, string eventParameter) {
            foreach (var analyticsProvider in AnalyticsProviders) {
                analyticsProvider.LogEvent(eventName, eventParameterName, eventParameter);
            }
        }

        public void SetUserProperty(string propertyName, string propertyValue) {
            foreach (var analyticsProvider in AnalyticsProviders) {
                analyticsProvider.SetUserProperty(propertyName, propertyValue);
            }
        }
    }
}
