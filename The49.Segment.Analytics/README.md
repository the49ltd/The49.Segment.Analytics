# The49.Segment.Analytics

.NET MAUI bindings of the [analytics-android](https://github.com/segmentio/analytics-android) and [analytics-ios](https://github.com/segmentio/analytics-ios) library from Segment

## Usage

Setup the library in your MauiProgram.cs

```cs
var builder = MauiApp.CreateBuilder();

builder
    .UseMauiApp<App>()
    .UseAnalytics("<writeKey>", cfg =>
    {
        cfg
        .TrackApplicationLifecycleEvents()
        .RecordScreenViews();
    });

return builder.Build();
```

Use Analytics methods by using `Analytics.Default`:


```cs
Analytics.Default.Track("Testing");
```
