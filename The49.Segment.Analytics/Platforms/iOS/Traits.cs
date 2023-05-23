namespace The49.Segment.Analytics;

public partial class Traits: ValueMap
{
    const string AVATAR_KEY = "avatar";
    const string CREATED_AT_KEY = "createdAt";
    const string DESCRIPTION_KEY = "description";
    const string EMAIL_KEY = "email";
    const string FAX_KEY = "fax";
    const string NAME_KEY = "name";
    const string PHONE_KEY = "phone";
    const string WEBSITE_KEY = "website";
    // For Identify Calls
    const string AGE_KEY = "age";
    const string BIRTHDAY_KEY = "birthday";
    const string FIRST_NAME_KEY = "firstName";
    const string GENDER_KEY = "gender";
    const string LAST_NAME_KEY = "lastName";
    const string TITLE_KEY = "title";
    const string USERNAME_KEY = "username";
    // For Group calls
    const string EMPLOYEES_KEY = "employees";
    const string INDUSTRY_KEY = "industry";
    // Address
    const string ADDRESS_KEY = "address";

    public Address? Address
    {
        get => (Address?)this[ADDRESS_KEY];
        set => this[ADDRESS_KEY] = value;
    }

    public int Age
    {
        get => (int)this[AGE_KEY];
        set => this[AGE_KEY] = value;
    }

    public string? Avatar
    {
        get => (string?)this[AVATAR_KEY];
        set => this[AVATAR_KEY] = value;
    }

    public DateTime Birthday
    {
        get => (DateTime)this[BIRTHDAY_KEY];
        set => this[BIRTHDAY_KEY] = value;
    }

    public string? CreatedAt
    {
        get => (string?)this[CREATED_AT_KEY];
        set => this[CREATED_AT_KEY] = value;
    }

    public string? Description
    {
        get => (string?)this[DESCRIPTION_KEY];
        set => this[DESCRIPTION_KEY] = value;
    }

    public string? Email
    {
        get => (string?)this[EMAIL_KEY];
        set => this[EMAIL_KEY] = value;
    }

    public string? Fax
    {
        get => (string?)this[FAX_KEY];
        set => this[FAX_KEY] = value;
    }

    public string? FirstName
    {
        get => (string?)this[FIRST_NAME_KEY];
        set => this[FIRST_NAME_KEY] = value;
    }

    public string? Gender
    {
        get => (string?)this[GENDER_KEY];
        set => this[GENDER_KEY] = value;
    }

    public string? Industry
    {
        get => (string?)this[INDUSTRY_KEY];
        set => this[INDUSTRY_KEY] = value;
    }

    public string? LastName
    {
        get => (string?)this[LAST_NAME_KEY];
        set => this[LAST_NAME_KEY] = value;
    }

    public string? Name
    {
        get => (string?)this[NAME_KEY];
        set => this[NAME_KEY] = value;
    }

    public string? Phone
    {
        get => (string?)this[PHONE_KEY];
        set => this[PHONE_KEY] = value;
    }

    public string? Title
    {
        get => (string?)this[TITLE_KEY];
        set => this[TITLE_KEY] = value;
    }

    public string? Username
    {
        get => (string?)this[USERNAME_KEY];
        set => this[USERNAME_KEY] = value;
    }

    public string? Website
    {
        get => (string?)this[WEBSITE_KEY];
        set => this[WEBSITE_KEY] = value;
    }

    public long Employees
    {
        get => (long)this[EMPLOYEES_KEY];
        set => this[EMPLOYEES_KEY] = value;
    }
}
