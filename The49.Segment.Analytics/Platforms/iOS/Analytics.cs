using System.Collections;
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

    static NSObject ToPlatform(object val)
    {
        if (val is NSObject nsObj)
        {
            return nsObj;
        }
        if (val is string s)
        {
            return NSObject.FromObject(s);
        }
        else if (val is DateTime dt)
        {
            var udt = dt.ToUniversalTime();
            return (NSDate)DateTime.SpecifyKind(udt, DateTimeKind.Utc);
        }
        else if (val is IDictionary<string, object> dict)
        {
            return ToNSDictionary(dict);
        }
        else if (val is IEnumerable arr)
        {
            var l = new List<NSObject>();
            foreach (var item in arr)
            {
                l.Add(ToPlatform(item));
            }
            return NSArray.FromNSObjects(l.ToArray());
        }
        return NSObject.FromObject(val);
    }

    static NSDictionary<NSString, NSObject> ToNSDictionary(IDictionary<string, object> d)
    {
        return NSDictionary<NSString, NSObject>.FromObjectsAndKeys(d.Values.Select(ToPlatform).ToArray(), d.Keys.ToArray());
    }
}
