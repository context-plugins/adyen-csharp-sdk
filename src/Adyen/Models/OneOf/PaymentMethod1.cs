using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models.OneOf;

/// <summary>
/// The type and required details of a payment method to use.
/// <para>
/// When <c>donationToken</c> is provided, the payment method is derived from the token and this field becomes optional.
/// </para>
/// <para>
/// If you are <see href="https://docs.adyen.com/development-resources/pci-dss-compliance-guide">PCI compliant</see>, and make donations using raw card details, you must explicitly provide the payment method details.
/// </para>
/// </summary>
[JsonConverter(typeof(PaymentMethod1Converter))]
public record PaymentMethod1
{
    private readonly Optional<ApplePayDonations> _applePayDonationsValue;

    private readonly Optional<PayWithGoogleDonations> _payWithGoogleDonationsValue;

    private readonly Optional<GooglePayDonations> _googlePayDonationsValue;

    private readonly Optional<CardDonations> _cardDonationsValue;

    private readonly Optional<IdealDonations> _idealDonationsValue;

    private readonly Optional<StoredPaymentMethod1> _storedPaymentMethod1Value;

    private PaymentMethod1(Optional<ApplePayDonations> applePayDonationsValue,
        Optional<PayWithGoogleDonations> payWithGoogleDonationsValue,
        Optional<GooglePayDonations> googlePayDonationsValue,
        Optional<CardDonations> cardDonationsValue,
        Optional<IdealDonations> idealDonationsValue,
        Optional<StoredPaymentMethod1> storedPaymentMethod1Value)
    {
        _applePayDonationsValue = applePayDonationsValue;
        _payWithGoogleDonationsValue = payWithGoogleDonationsValue;
        _googlePayDonationsValue = googlePayDonationsValue;
        _cardDonationsValue = cardDonationsValue;
        _idealDonationsValue = idealDonationsValue;
        _storedPaymentMethod1Value = storedPaymentMethod1Value;
    }

    public static PaymentMethod1 ApplePayDonations(ApplePayDonations value) =>
        new(Optional<ApplePayDonations>.Some(value), default, default, default, default, default);

    public static PaymentMethod1 PayWithGoogleDonations(PayWithGoogleDonations value) =>
        new(default, Optional<PayWithGoogleDonations>.Some(value), default, default, default, default);

    public static PaymentMethod1 GooglePayDonations(GooglePayDonations value) =>
        new(default, default, Optional<GooglePayDonations>.Some(value), default, default, default);

    public static PaymentMethod1 CardDonations(CardDonations value) =>
        new(default, default, default, Optional<CardDonations>.Some(value), default, default);

    public static PaymentMethod1 IdealDonations(IdealDonations value) =>
        new(default, default, default, default, Optional<IdealDonations>.Some(value), default);

    public static PaymentMethod1 StoredPaymentMethod1(StoredPaymentMethod1 value) =>
        new(default, default, default, default, default, Optional<StoredPaymentMethod1>.Some(value));

    public bool TryGetApplePayDonations(out ApplePayDonations value) => _applePayDonationsValue.TryGetValue(out value);

    public bool TryGetPayWithGoogleDonations(out PayWithGoogleDonations value) =>
        _payWithGoogleDonationsValue.TryGetValue(out value);

    public bool TryGetGooglePayDonations(out GooglePayDonations value) =>
        _googlePayDonationsValue.TryGetValue(out value);

    public bool TryGetCardDonations(out CardDonations value) => _cardDonationsValue.TryGetValue(out value);

    public bool TryGetIdealDonations(out IdealDonations value) => _idealDonationsValue.TryGetValue(out value);

    public bool TryGetStoredPaymentMethod1(out StoredPaymentMethod1 value) =>
        _storedPaymentMethod1Value.TryGetValue(out value);

    public static implicit operator PaymentMethod1(ApplePayDonations value) => ApplePayDonations(value);

    public static implicit operator PaymentMethod1(PayWithGoogleDonations value) => PayWithGoogleDonations(value);

    public static implicit operator PaymentMethod1(GooglePayDonations value) => GooglePayDonations(value);

    public static implicit operator PaymentMethod1(CardDonations value) => CardDonations(value);

    public static implicit operator PaymentMethod1(IdealDonations value) => IdealDonations(value);

    public static implicit operator PaymentMethod1(StoredPaymentMethod1 value) => StoredPaymentMethod1(value);
}

file sealed class PaymentMethod1Converter : JsonConverter<PaymentMethod1>
{
    public override PaymentMethod1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var typeProperty))
        {
            throw new JsonException("Missing required 'type' discriminator field");
        }
        var discriminator = typeProperty.GetString();
        return discriminator switch
        {
            "applepay" => PaymentMethod1.ApplePayDonations(root.Deserialize<ApplePayDonations>(options)!),
            "paywithgoogle" => PaymentMethod1.PayWithGoogleDonations(root.Deserialize<PayWithGoogleDonations>(
                options)!),
            "googlepay" => PaymentMethod1.GooglePayDonations(root.Deserialize<GooglePayDonations>(options)!),
            "scheme" or "networkToken" or "card" => PaymentMethod1.CardDonations(root.Deserialize<CardDonations>(
                options)!),
            "ideal" => PaymentMethod1.IdealDonations(root.Deserialize<IdealDonations>(options)!),
            "sepadirectdebit" => PaymentMethod1.StoredPaymentMethod1(root.Deserialize<StoredPaymentMethod1>(options)!),
            _ => throw new JsonException(
                $"JSON does not match ApplePayDonations or PayWithGoogleDonations or GooglePayDonations or CardDonations or IdealDonations or StoredPaymentMethod1 schemas: {root.ToString()}")
        };
    }

    public override void Write(Utf8JsonWriter writer, PaymentMethod1 value, JsonSerializerOptions options)
    {
        if (value.TryGetApplePayDonations(out var applePayDonationsValue))
        {
            JsonSerializer.Serialize(writer, applePayDonationsValue, options);
        }
        else if (value.TryGetPayWithGoogleDonations(out var payWithGoogleDonationsValue))
        {
            JsonSerializer.Serialize(writer, payWithGoogleDonationsValue, options);
        }
        else if (value.TryGetGooglePayDonations(out var googlePayDonationsValue))
        {
            JsonSerializer.Serialize(writer, googlePayDonationsValue, options);
        }
        else if (value.TryGetCardDonations(out var cardDonationsValue))
        {
            JsonSerializer.Serialize(writer, cardDonationsValue, options);
        }
        else if (value.TryGetIdealDonations(out var idealDonationsValue))
        {
            JsonSerializer.Serialize(writer, idealDonationsValue, options);
        }
        else if (value.TryGetStoredPaymentMethod1(out var storedPaymentMethod1Value))
        {
            JsonSerializer.Serialize(writer, storedPaymentMethod1Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(PaymentMethod1)} contains no valid value to serialize.");
        }
    }
}
