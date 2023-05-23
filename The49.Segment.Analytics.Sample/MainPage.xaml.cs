using The49.Segment.Analytics;

namespace AnalyticsAndroid;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnTrackClicked(object sender, EventArgs e)
    {
        Analytics.Default.Track("Testing");
        var p = new Properties
        {
            Category = "Electronics",
            Coupon = "SALE20",
            Currency = "USD",
            Discount = 10.5,
            Name = "Smartphone",
            OrderId = "ORD123456",
            Path = "/electronics/smartphone",
            Price = 599.99,
            ProductId = "PROD789",
            Referrer = "https://example.com",
            IsRepeatCustomer = true,
            Revenue = 549.99,
            Shipping = 9.99,
            Total = 609.98,
            Sku = "SMRTPHN123",
            Tax = 45.0,
            Subtotal = 554.99,
            Url = "https://example.com/product/PROD789",
            Value = 5.0,
            Title = "Example Smartphone",
            Products = new List<Product>
            {
                new Product("PROD123", "Headphones", 49.99),
                new Product("PROD456", "Charging Cable", 9.99)
            }
        };
        p.Set("customProp", 67);
        Analytics.Default.Track("Testing", p);
    }
    private void OnIdentifyClicked(object sender, EventArgs e)
    {
        Analytics.Default.Identify("user@provider.com");
        var t = new Traits
        {
            Age = 21,
            Address = new Address
            {
                City = "City",
                Country = "Country",
                PostalCode = "PostalCode",
                State = "ZZ",
                Street = "Street",
            },
            Avatar = "Avatar",
            Birthday = new DateTime(1990, 6, 2),
            Description = "Description",
            Email = "email@email.email",
            Employees = 49,
            Fax = "Fax",
            FirstName = "FirstName",
            Gender = "Gender",
            Industry = "Industry",
            LastName = "LastName",
            Name = "Name",
            Phone = "Phone",
            Title = "Title",
            Username = "Username",
            Website = "https://the49.com",
            CreatedAt = "CreatedAt"
        };
        t.Set("customProp", true);
        Analytics.Default.Identify("user@provider.com", t);
    }
    private void OnGroupClicked(object sender, EventArgs e)
    {
        Analytics.Default.Group("Testing");
        var t = new Traits
        {
            Age = 21,
            Address = new Address
            {
                City = "City",
                Country = "Country",
                PostalCode = "PostalCode",
                State = "ZZ",
                Street = "Street",
            },
            Avatar = "Avatar",
            Birthday = new DateTime(1990, 6, 2),
            Description = "Description",
            Email = "email@email.email",
            Employees = 49,
            Fax = "Fax",
            FirstName = "FirstName",
            Gender = "Gender",
            Industry = "Industry",
            LastName = "LastName",
            Name = "Name",
            Phone = "Phone",
            Title = "Title",
            Username = "Username",
            Website = "https://the49.com",
            CreatedAt = "CreatedAt"
        };
        t.Set("customProp", true);
        Analytics.Default.Group("groupId", t);
    }
    private void OnAliasClicked(object sender, EventArgs e)
    {
        Analytics.Default.Alias("newId");
    }
    private void OnScreenClicked(object sender, EventArgs e)
    {
        Analytics.Default.Screen("Screen");
        var p = new Properties
        {
            Category = "Electronics",
            Coupon = "SALE20",
            Currency = "USD",
            Discount = 10.5,
            Name = "Smartphone",
            OrderId = "ORD123456",
            Path = "/electronics/smartphone",
            Price = 599.99,
            ProductId = "PROD789",
            Referrer = "https://example.com",
            IsRepeatCustomer = true,
            Revenue = 549.99,
            Shipping = 9.99,
            Total = 609.98,
            Sku = "SMRTPHN123",
            Tax = 45.0,
            Subtotal = 554.99,
            Url = "https://example.com/product/PROD789",
            Value = 5.0,
            Title = "Example Smartphone",
            Products = new List<Product>
            {
                new Product("PROD123", "Headphones", 49.99),
                new Product("PROD456", "Charging Cable", 9.99)
            }
        };
        p.Set("customProp", 89);
        Analytics.Default.Screen("Screen", p);
    }
}

