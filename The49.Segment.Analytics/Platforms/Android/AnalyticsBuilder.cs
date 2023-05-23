using Android.Content;
using SegmentAnalytics = Segment.Analytics;

namespace The49.Segment.Analytics;

public class AnalyticsBuilder : IAnalyticsBuilder
{
    private SegmentAnalytics.Builder _builder;

    public AnalyticsBuilder(Context context, string writeKey)
    {
        _builder = new SegmentAnalytics.Builder(context, writeKey);
    }

    public SegmentAnalytics Build()
    {
        return _builder.Build();
    }

    public IAnalyticsBuilder RecordScreenViews()
    {
        _builder.RecordScreenViews();
        return this;
    }

    public IAnalyticsBuilder TrackApplicationLifecycleEvents()
    {
        _builder.TrackApplicationLifecycleEvents();
        return this;
    }
}