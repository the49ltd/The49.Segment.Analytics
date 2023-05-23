using Foundation;
using SegmentAnalytics = Segment.Analytics;

namespace The49.Segment.Analytics;

public partial class Analytics : IAnalytics
{
    public void Alias(string newId)
    {
        SegmentAnalytics.Shared.Alias(newId);
    }

    public void Group(string groupId)
    {
        SegmentAnalytics.Shared.Group(groupId);
    }

    public void Group(string groupId, Traits traits)
    {
        SegmentAnalytics.Shared.Group(groupId, ToNSDictionary(traits));
    }

    public void Group(string groupId, Traits traits, Options options)
    {
        SegmentAnalytics.Shared.Group(groupId, ToNSDictionary(traits), ToNSDictionary(options));
    }

    public void Identify(string userId)
    {
        SegmentAnalytics.Shared.Identify(userId);
    }

    public void Identify(string userId, Traits traits)
    {
        SegmentAnalytics.Shared.Identify(userId, ToNSDictionary(traits));
    }

    public void Identify(string userId, Traits traits, Options options)
    {
        SegmentAnalytics.Shared.Identify(userId, ToNSDictionary(traits), ToNSDictionary(options));
    }

    public void Screen(string eventName)
    {
        SegmentAnalytics.Shared.Screen(eventName);
    }

    public void Screen(string eventName, Properties properties)
    {
        SegmentAnalytics.Shared.Screen(eventName, ToNSDictionary(properties));
    }

    public void Screen(string eventName, Properties properties, Options options)
    {
        SegmentAnalytics.Shared.Screen(eventName, ToNSDictionary(properties), ToNSDictionary(options));
    }

    public void Track(string eventName)
    {
        SegmentAnalytics.Shared.Track(eventName);
    }

    public void Track(string eventName, Properties properties)
    {
        SegmentAnalytics.Shared.Track(eventName, ToNSDictionary(properties));
    }

    public void Track(string eventName, Properties properties, Options options)
    {
        SegmentAnalytics.Shared.Track(eventName, ToNSDictionary(properties), ToNSDictionary(options));
    }

    static NSDictionary<NSString, NSObject>  ToNSDictionary(IDictionary<string, object> d)
    {
        return NSDictionary<NSString, NSObject>.FromObjectsAndKeys(d.Values.Select(val =>
        {
            if(val is Array arr)
            {
                var l = new List<NSObject>();
                foreach (var item in arr)
                {
                    if (item is IDictionary<string, object> dict)
                    {
                        l.Add(ToNSDictionary(dict));
                    }
                    else
                    {
                        l.Add(NSObject.FromObject(item));
                    }
                }
                return NSArray.FromNSObjects(l.ToArray());
            } else if (val is IDictionary<string, object> dict)
            {
                return ToNSDictionary(dict);
            }
            else if (val is DateTime dt)
            {
                var udt = dt.ToUniversalTime();
                return (NSDate)DateTime.SpecifyKind(udt, DateTimeKind.Utc);
            }
            return val;
        }).ToArray(), d.Keys.ToArray());
    }
}
