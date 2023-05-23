using SegmentAnalytics = Segment.Analytics;

namespace The49.Segment.Analytics;

public partial class Analytics : IAnalytics
{
    SegmentAnalytics _analytics;

    public void Alias(string newId)
    {
        _analytics.Alias(newId);
    }

    public void Group(string groupId)
    {
        _analytics.Group(groupId);
    }

    public void Group(string groupId, Traits traits)
    {
        _analytics.Group(groupId);
    }

    public void Group(string groupId, Traits traits, Options options)
    {
        _analytics.Group(groupId, traits, options);
    }

    public void Identify(string userId)
    {
        _analytics.Identify(userId);
    }

    public void Identify(string userId, Traits traits)
    {
        _analytics.Identify(userId, traits, null);
    }

    public void Identify(string userId, Traits traits, Options options)
    {
        _analytics.Identify(userId, traits, options);
    }

    public void Screen(string eventName)
    {
        _analytics.Screen(eventName);
    }

    public void Screen(string eventName, Properties properties)
    {
        _analytics.Screen(eventName, properties);
    }

    public void Screen(string eventName, Properties properties, Options options)
    {
        _analytics.Screen(null, eventName, properties, options);
    }

    public void Track(string eventName)
    {
        _analytics.Track(eventName);
    }

    public void Track(string eventName, Properties properties)
    {
        _analytics.Track(eventName, properties);
    }

    public void Track(string eventName, Properties properties, Options options)
    {
        _analytics.Track(eventName, properties, options);
    }

    internal void Setup(AnalyticsBuilder builder)
    {
        _analytics = builder.Build();
    }
}
