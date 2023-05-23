namespace The49.Segment.Analytics;

public class Address : ValueMap
{
    const string ADDRESS_CITY_KEY = "city";
    const string ADDRESS_COUNTRY_KEY = "country";
    const string ADDRESS_POSTAL_CODE_KEY = "postalCode";
    const string ADDRESS_STATE_KEY = "state";
    const string ADDRESS_STREET_KEY = "street";

    public string? City
    {
        get => (string?)this[ADDRESS_CITY_KEY];
        set => this[ADDRESS_CITY_KEY] = value;
    }

    public string? Country
    {
        get => (string?)this[ADDRESS_COUNTRY_KEY];
        set => this[ADDRESS_COUNTRY_KEY] = value;
    }

    public string? PostalCode
    {
        get => (string?)this[ADDRESS_POSTAL_CODE_KEY];
        set => this[ADDRESS_POSTAL_CODE_KEY] = value;
    }

    public string? State
    {
        get => (string?)this[ADDRESS_STATE_KEY];
        set => this[ADDRESS_STATE_KEY] = value;
    }

    public string? Street
    {
        get => (string?)this[ADDRESS_STREET_KEY];
        set => this[ADDRESS_STREET_KEY] = value;
    }
}
