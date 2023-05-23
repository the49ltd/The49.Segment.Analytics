using SegmentProduct = Segment.Properties.Product;

namespace The49.Segment.Analytics;

public class Product : SegmentProduct
{
    public Product(string id, string sku, double price) : base(id, sku, price)
    {
    }
}
