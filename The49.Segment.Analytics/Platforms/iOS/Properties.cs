namespace The49.Segment.Analytics;

public partial class Properties: ValueMap
{
    // Common Properties
    const string REVENUE_KEY = "revenue";
    const string CURRENCY_KEY = "currency";
    const string VALUE_KEY = "value";
    // Screen Properties
    const string PATH_KEY = "path";
    const string REFERRER_KEY = "referrer";
    const string TITLE_KEY = "title";
    const string URL_KEY = "url";
    // Ecommerce API
    const string NAME_KEY = "name"; // used by product too
    const string CATEGORY_KEY = "category";
    const string SKU_KEY = "sku";
    const string PRICE_KEY = "price";
    const string ID_KEY = "id";
    const string ORDER_ID_KEY = "orderId";
    const string TOTAL_KEY = "total";
    const string SUBTOTAL_KEY = "subtotal";
    const string SHIPPING_KEY = "shipping";
    const string TAX_KEY = "tax";
    const string DISCOUNT_KEY = "discount";
    const string COUPON_KEY = "coupon";
    const string PRODUCTS_KEY = "products";
    const string REPEAT_KEY = "repeat";

    public string? Category
    {
        get => (string?)this[CATEGORY_KEY];
        set => this[CATEGORY_KEY] = value;
    }

    public string? Coupon
    {
        get => (string?)this[COUPON_KEY];
        set => this[COUPON_KEY] = value;
    }

    public string? Currency
    {
        get => (string?)this[CURRENCY_KEY];
        set => this[CURRENCY_KEY] = value;
    }

    public double Discount
    {
        get => (double)this[DISCOUNT_KEY];
        set => this[DISCOUNT_KEY] = value;
    }

    public string? Name
    {
        get => (string?)this[NAME_KEY];
        set => this[NAME_KEY] = value;
    }

    public string? OrderId
    {
        get => (string?)this[ORDER_ID_KEY];
        set => this[ORDER_ID_KEY] = value;
    }

    public string? Path
    {
        get => (string?)this[PATH_KEY];
        set => this[PATH_KEY] = value;
    }

    public double Price
    {
        get => (double)this[PRICE_KEY];
        set => this[PRICE_KEY] = value;
    }

    public string? ProductId
    {
        get => (string?)this[ID_KEY];
        set => this[ID_KEY] = value;
    }

    public string? Referrer
    {
        get => (string?)this[REFERRER_KEY];
        set => this[REFERRER_KEY] = value;
    }

    public bool IsRepeatCustomer
    {
        get => (bool)this[REPEAT_KEY];
        set => this[REPEAT_KEY] = value;
    }

    public double Revenue
    {
        get => (double)this[REVENUE_KEY];
        set => this[REVENUE_KEY] = value;
    }

    public double Shipping
    {
        get => (double)this[SHIPPING_KEY];
        set => this[SHIPPING_KEY] = value;
    }

    public double Total
    {
        get => (double)this[TOTAL_KEY];
        set => this[TOTAL_KEY] = value;
    }

    public string? Sku
    {
        get => (string?)this[SKU_KEY];
        set => this[SKU_KEY] = value;
    }

    public double Tax
    {
        get => (double)this[TAX_KEY];
        set => this[TAX_KEY] = value;
    }

    public double Subtotal
    {
        get => (double)this[SUBTOTAL_KEY];
        set => this[SUBTOTAL_KEY] = value;
    }

    public string? Url
    {
        get => (string?)this[URL_KEY];
        set => this[URL_KEY] = value;
    }

    public double Value
    {
        get => (double)this[VALUE_KEY];
        set => this[VALUE_KEY] = value;
    }

    public string? Title
    {
        get => (string?)this[TITLE_KEY];
        set => this[TITLE_KEY] = value;
    }

    public IList<Product>? Products
    {
        get => ((Product[]?)this[PRODUCTS_KEY])?.ToList();
        set => this[PRODUCTS_KEY] = value.ToArray();
    }
}


