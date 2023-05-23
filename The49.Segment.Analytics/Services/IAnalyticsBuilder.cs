namespace The49.Segment.Analytics;


public interface IAnalyticsBuilder
{
    IAnalyticsBuilder TrackApplicationLifecycleEvents();
    IAnalyticsBuilder RecordScreenViews();
}
