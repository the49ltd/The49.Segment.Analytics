# The49.Segment.Analytics.Android

.NET for Android bindings of the [analytics-android](https://github.com/segmentio/analytics-android) library from Segment


```cs
var analytics = new Segment.Analytics.Builder(Platform.AppContext, "<writeKey>")
    .TrackApplicationLifecycleEvents()
    .RecordScreenViews()
    .Build();

Segment.Analytics.SetSingletonInstance(analytics);

Segment.Analytics.With(Platform.AppContext).Track("CustomEvent");
```