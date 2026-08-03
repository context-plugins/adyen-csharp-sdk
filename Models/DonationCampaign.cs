using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DonationCampaign
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amounts")]
    public Amounts? Amounts { get; init; }

    /// <summary>
    /// The URL for the banner of the nonprofit or campaign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bannerUrl")]
    public string? BannerUrl { get; init; }

    /// <summary>
    /// The name of the donation campaign..
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("campaignName")]
    public string? CampaignName { get; init; }

    /// <summary>
    /// The cause of the nonprofit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("causeName")]
    public string? CauseName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("donation")]
    public Donation? Donation { get; init; }

    /// <summary>
    /// The unique campaign ID of the donation campaign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The URL for the logo of the nonprofit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logoUrl")]
    public string? LogoUrl { get; init; }

    /// <summary>
    /// The description of the nonprofit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nonprofitDescription")]
    public string? NonprofitDescription { get; init; }

    /// <summary>
    /// The name of the nonprofit organization that receives the donation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nonprofitName")]
    public string? NonprofitName { get; init; }

    /// <summary>
    /// The website URL of the nonprofit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nonprofitUrl")]
    public string? NonprofitUrl { get; init; }

    /// <summary>
    /// The URL of the terms and conditions page of the nonprofit and the campaign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("termsAndConditionsUrl")]
    public string? TermsAndConditionsUrl { get; init; }
}
