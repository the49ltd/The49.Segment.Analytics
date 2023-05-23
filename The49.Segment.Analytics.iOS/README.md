# The49.Segment.Analytics.iOS

.NET for iOS bindings of the [analytics-ios](https://github.com/segmentio/analytics-ios) library from Segment


```cs
var configuration = Segment.AnalyticsConfiguration.ConfigurationWithWriteKey("<writeKey>");

Segment.Analytics.Setup(configuration);

Segment.Analytics.Shared.Track("CustomEvent");
```