namespace The49.Segment.Analytics;

public partial class Analytics
{
    public static IAnalytics Default => Application.Current.Handler.MauiContext.Services.GetService<IAnalytics>();
}
