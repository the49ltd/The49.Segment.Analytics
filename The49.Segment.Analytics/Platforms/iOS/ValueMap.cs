namespace The49.Segment.Analytics;

public class ValueMap: Dictionary<string, object>
{
    public void Set(string key, object value)
    {
        this[key] = value;
    }
}

