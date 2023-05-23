using SegmentAnalytics = Segment.Analytics;
using SegmentAnalyticsConfiguration = Segment.AnalyticsConfiguration;

namespace The49.Segment.Analytics;

public class AnalyticsBuilder : IAnalyticsBuilder
{
    SegmentAnalyticsConfiguration _configuration;

    public AnalyticsBuilder(string writeKey)
    {
        _configuration = SegmentAnalyticsConfiguration.ConfigurationWithWriteKey(writeKey);
    }

    public void Build()
    {
        SegmentAnalytics.Setup(_configuration);
    }

    public IAnalyticsBuilder RecordScreenViews()
    {
        _configuration.RecordScreenViews = true;
        return this;
    }

    public IAnalyticsBuilder TrackApplicationLifecycleEvents()
    {
        _configuration.TrackApplicationLifecycleEvents = true;
        return this;
    }
}