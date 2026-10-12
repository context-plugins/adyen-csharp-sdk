using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DataCenter
{
    /// <summary>
    /// The unique <see href="https://docs.adyen.com/development-resources/live-endpoints#live-url-prefix">live URL prefix</see> for your live endpoint. Each data center has its own live URL prefix.
    /// <para>
    /// This field is empty for requests made in the test environment.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("livePrefix")]
    public string? LivePrefix { get; init; }

    /// <summary>
    /// The name assigned to a data center, for example <b>EU</b> for the European data center. Possible values are:
    /// <list type="bullet">
    ///   <item><description><b>default</b>: the European data center. This value is always returned in the test environment.</description></item>
    ///   <item><description><b>AU</b></description></item>
    ///   <item><description><b>EU</b></description></item>
    ///   <item><description><b>US</b></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
