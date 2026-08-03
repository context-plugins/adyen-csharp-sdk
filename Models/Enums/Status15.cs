using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the app. Possible values:
/// * <c>processing</c>: the app is being signed and converted to a format that the terminal can handle.
/// * <c>error</c>: something went wrong. Check that the app matches the <see href="https://docs.adyen.com/point-of-sale/android-terminals/app-requirements">requirements</see>.
/// * <c>invalid</c>: there is something wrong with the APK file of the app.
/// * <c>ready</c>: the app has been signed and converted.
/// * <c>archived</c>: the app is no longer available.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status15>))]
public sealed record Status15 : StringEnum<Status15>
{
    private Status15(string value) : base(value)
    {
    }

    public static readonly Status15 Archived = new("archived");

    public static readonly Status15 Error = new("error");

    public static readonly Status15 Invalid = new("invalid");

    public static readonly Status15 Processing = new("processing");

    public static readonly Status15 Ready = new("ready");

    public static Status15 FromValue(string value) => FromValueCore(value);
}
