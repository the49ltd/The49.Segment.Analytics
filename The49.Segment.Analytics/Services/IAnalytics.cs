namespace The49.Segment.Analytics;

public interface IAnalytics
{
    public void Track(string eventName);
    public void Track(string eventName, Properties properties);
    public void Track(string eventName, Properties properties, Options options);

    public void Identify(string userId);
    public void Identify(string userId, Traits traits);
    public void Identify(string userId, Traits traits, Options options);

    public void Screen(string eventName);
    public void Screen(string eventName, Properties properties);
    public void Screen(string eventName, Properties properties, Options options);

    public void Group(string groupId);
    public void Group(string groupId, Traits traits);
    public void Group(string groupId, Traits traits, Options options);

    public void Alias(string newId);

}
