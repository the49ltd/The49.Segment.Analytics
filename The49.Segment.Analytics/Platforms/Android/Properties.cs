using SegmentProperties = Segment.Properties;

namespace The49.Segment.Analytics;

public class Properties : SegmentProperties
{
    public new IList<Segment.Analytics.Product>? Products
    {
        // TODO: Handle this scenario
        get => new List<Segment.Analytics.Product>();
        set => base.Products = value.Cast<Product>().ToList();
    }
}
