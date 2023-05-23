using The49.Segment.Analytics;

namespace AnalyticsAndroid;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseAnalytics("N4Ir9mzL8pDDNaH0Axd0zJFFVMrhRrgE", cfg =>
            {
                cfg
                .TrackApplicationLifecycleEvents()
                .RecordScreenViews();
            })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
}
