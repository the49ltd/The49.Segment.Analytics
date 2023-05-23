namespace Segment;

public partial class ValueMap
{
    public static Java.Util.Date FromDateTime(DateTime dt)
    {
        DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        long csharpTicks = (dt.ToUniversalTime() - unixEpoch).Ticks;
        long javaTicks = csharpTicks / TimeSpan.TicksPerMillisecond;

        return new Java.Util.Date(javaTicks);
    }
    public static Java.Lang.Object BoxValue(object value)
    {
        if (value is bool boolValue)
        {
            return boolValue ? Java.Lang.Boolean.True : Java.Lang.Boolean.False;
        }
        else if (value is int intValue)
        {
            return new Java.Lang.Integer(intValue);
        }
        else if (value is double doubleValue)
        {
            return new Java.Lang.Double(doubleValue);
        }
        else if (value is float floatValue)
        {
            return new Java.Lang.Float(floatValue);
        }
        else if (value is long longValue)
        {
            return new Java.Lang.Long(longValue);
        }
        else if (value is short shortValue)
        {
            return new Java.Lang.Short(shortValue);
        }
        else if (value is sbyte byteValue)
        {
            return new Java.Lang.Byte(byteValue);
        }
        else if (value is char charValue)
        {
            return new Java.Lang.Character(charValue);
        }
        else if (value is string stringValue)
        {
            return new Java.Lang.String(stringValue);
        }
        else if (value is DateTime dt)
        {
            return FromDateTime(dt);
        }
        else
        {
            // For C# classes, return the value as is
            return (Java.Lang.Object)value;
        }
    }
    public void Set(string key, object value)
    {
        Put(key, BoxValue(value));
    }
}
