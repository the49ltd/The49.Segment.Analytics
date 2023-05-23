namespace Segment;

public partial class Traits
{
    public Address? Address
    {
        get => new Address(GetAddress()!);
        set => SetAddress(value?.InternalAddress);
    }

    public int Age
    {
        get => GetAge();
        set => SetAge(value);
    }

    public string? Avatar
    {
        get => GetAvatar();
        set => SetAvatar(value);
    }

    public DateTime Birthday
    {
        get {
            var javaDate = GetBirthday();
            long javaTicks = javaDate.Time / 1000L; // Convert milliseconds to seconds
            long csharpTicks = javaTicks + 62135596800000L; // Add the offset between Java and C# epoch
            return new DateTime(csharpTicks, DateTimeKind.Utc);
        }
        set
        {
            DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            long csharpTicks = (value.ToUniversalTime() - unixEpoch).Ticks;
            long javaTicks = csharpTicks / TimeSpan.TicksPerMillisecond;

            SetBirthday(new Java.Util.Date(javaTicks));
        }
    }

    public string? CreatedAt
    {
        get => GetCreatedAt();
        set => SetCreatedAt(value);
    }

    public string? Description
    {
        get => GetDescription();
        set => SetDescription(value);
    }

    public string? Email
    {
        get => GetEmail();
        set => SetEmail(value);
    }

    public long Employees
    {
        get => GetEmployees();
        set => SetEmployees(value);
    }

    public string? Fax
    {
        get => GetFax();
        set => SetFax(value);
    }

    public string? FirstName
    {
        get => GetFirstName();
        set => SetFirstName(value);
    }

    public string? Gender
    {
        get => GetGender();
        set => SetGender(value);
    }

    public string? Industry
    {
        get => GetIndustry();
        set => SetIndustry(value);
    }

    public string? LastName
    {
        get => GetLastName();
        set => SetLastName(value);
    }

    public string? Name
    {
        get => GetName();
        set => SetName(value);
    }

    public string? Phone
    {
        get => GetPhone();
        set => SetPhone(value);
    }

    public string? Title
    {
        get => GetTitle();
        set => SetTitle(value);
    }

    public string? Username
    {
        get => GetUsername();
        set => SetUsername(value);
    }

    public string? Website
    {
        get => GetWebsite();
        set => SetWebsite(value);
    }

}
