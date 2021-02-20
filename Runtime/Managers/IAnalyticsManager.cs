using System.Collections.Generic;
using HephaestusMobile.AnalyticsSubsytem.Providers;

namespace HephaestusMobile.AnalyticsSubsytem.Managers {
    public interface IAnalyticsManager {
        List<IAnalyticsProvider> AnalyticsProviders { get; set; }
        void Initialize();
        void AddAnalyticsProvider(IAnalyticsProvider analyticsProvider);
        void LogEvent(string eventName);
        void LogEvent(string eventName, object eventParameters);
        void LogEvent(string eventName, string eventParameterName, double eventParameter);
        void LogEvent(string eventName, string eventParameterName, int eventParameter);
        void LogEvent(string eventName, string eventParameterName, float eventParameter);
        void LogEvent(string eventName, string eventParameterName, long eventParameter);
        void LogEvent(string eventName, string eventParameterName, string eventParameter);
        void SetUserProperty(string propertyName, string propertyValue);
    }
}
