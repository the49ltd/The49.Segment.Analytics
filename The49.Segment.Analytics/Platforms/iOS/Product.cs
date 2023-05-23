namespace The49.Segment.Analytics;

public class Product: ValueMap
{
    const string ID_KEY = "id";
    const string PRODUCT_ID_KEY = "product_id";
    const string SKU_KEY = "sku";
    const string NAME_KEY = "name";
    const string PRICE_KEY = "price";

    public Product(string id, string sku, double price)
    {
        this[ID_KEY] = id;
        this[SKU_KEY] = sku;
        this[PRICE_KEY] = price;
    }
}
