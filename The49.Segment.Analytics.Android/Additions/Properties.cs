namespace Segment;

public partial class Properties
{
    public string? Category
    {
        get => GetCategory();
        set => SetCategory(value);
    }

    public string? Coupon
    {
        get => GetCoupon();
        set => SetCoupon(value);
    }

    public string? Currency
    {
        get => GetCurrency();
        set => SetCurrency(value);
    }

    public double Discount
    {
        get => GetDiscount();
        set => SetDiscount(value);
    }

    public string? Name
    {
        get => GetName();
        set => SetName(value);
    }

    public string? OrderId
    {
        get => GetOrderId();
        set => SetOrderId(value);
    }

    public string? Path
    {
        get => GetPath();
        set => SetPath(value);
    }

    public double Price
    {
        get => GetPrice();
        set => SetPrice(value);
    }

    public string? ProductId
    {
        get => GetProductId();
        set => SetProductId(value);
    }

    public string? Referrer
    {
        get => GetReferrer();
        set => SetReferrer(value);
    }

    public bool IsRepeatCustomer
    {
        get => GetIsRepeatCustomer();
        set => SetIsRepeatCustomer(value);
    }

    public double Revenue
    {
        get => GetRevenue();
        set => SetRevenue(value);
    }

    public double Shipping
    {
        get => GetShipping();
        set => SetShipping(value);
    }

    public double Total
    {
        get => GetTotal();
        set => SetTotal(value);
    }

    public string? Sku
    {
        get => GetSku();
        set => SetSku(value);
    }

    public double Tax
    {
        get => GetTax();
        set => SetTax(value);
    }

    public double Subtotal
    {
        get => GetSubtotal();
        set => SetSubtotal(value);
    }

    public string? Url
    {
        get => GetUrl();
        set => SetUrl(value);
    }

    public double Value
    {
        get => GetValue();
        set => SetValue(value);
    }

    public string? Title
    {
        get => GetTitle();
        set => SetTitle(value);
    }
    public IList<Product>? Products
    {
        get => GetProducts();
        set => SetProducts(value?.ToArray());
    }
}


