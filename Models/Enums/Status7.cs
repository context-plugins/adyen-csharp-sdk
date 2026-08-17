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
[JsonConverter(typeof(StringEnumConverter<Status7>))]
public sealed record Status7 : StringEnum<Status7>
{
    private Status7(string value) : base(value)
    {
    }

    public static readonly Status7 Archived = new("archived");

    public static readonly Status7 Error = new("error");

    public static readonly Status7 Invalid = new("invalid");

    public static readonly Status7 Processing = new("processing");

    public static readonly Status7 Ready = new("ready");

    public static Status7 FromValue(string value) => FromValueCore(value);
}
