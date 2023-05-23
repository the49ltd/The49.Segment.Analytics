namespace Segment;

public class Address
{
    readonly Traits.InternalAddress _address;

    public Address()
    {
        _address = new Traits.InternalAddress();
    }

    internal Address(Traits.InternalAddress address)
    {
        _address = address;
    }

    internal Traits.InternalAddress InternalAddress => _address;

    public string? City
    {
        get => _address.GetCity();
        set => _address.SetCity(value);
    }

    public string? Country
    {
        get => _address.GetCountry();
        set => _address.SetCountry(value);
    }

    public string? PostalCode
    {
        get => _address.GetPostalCode();
        set => _address.SetPostalCode(value);
    }

    public string? State
    {
        get => _address.GetState();
        set => _address.SetState(value);
    }

    public string? Street
    {
        get => _address.GetStreet();
        set => _address.SetStreet(value);
    }
}
