using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The type and required details of a payment method to use.
/// <para>
/// When <c>donationToken</c> is provided, the payment method is derived from the token and this field becomes optional.
/// </para>
/// <para>
/// If you are <see href="https://docs.adyen.com/development-resources/pci-dss-compliance-guide">PCI compliant</see>, and make donations using raw card details, you must explicitly provide the payment method details.
/// </para>
/// </summary>
[JsonConverter(typeof(PaymentMethod2Converter))]
public record PaymentMethod2
{
    private readonly Optional<ApplePayDonations> _applePayDonationsValue;

    private readonly Optional<CardDonations> _cardDonationsValue;

    private readonly Optional<GooglePayDonations> _googlePayDonationsValue;

    private readonly Optional<IdealDonations> _idealDonationsValue;

    private readonly Optional<PayWithGoogleDonations> _payWithGoogleDonationsValue;

    private readonly Optional<StoredPaymentMethod1> _storedPaymentMethod1Value;

    private PaymentMethod2(Optional<ApplePayDonations> applePayDonationsValue,
        Optional<CardDonations> cardDonationsValue,
        Optional<GooglePayDonations> googlePayDonationsValue,
        Optional<IdealDonations> idealDonationsValue,
        Optional<PayWithGoogleDonations> payWithGoogleDonationsValue,
        Optional<StoredPaymentMethod1> storedPaymentMethod1Value)
    {
        _applePayDonationsValue = applePayDonationsValue;
        _cardDonationsValue = cardDonationsValue;
        _googlePayDonationsValue = googlePayDonationsValue;
        _idealDonationsValue = idealDonationsValue;
        _payWithGoogleDonationsValue = payWithGoogleDonationsValue;
        _storedPaymentMethod1Value = storedPaymentMethod1Value;
    }

    public static PaymentMethod2 ApplePayDonations(ApplePayDonations value) =>
        new(Optional<ApplePayDonations>.Some(value), default, default, default, default, default);

    public static PaymentMethod2 CardDonations(CardDonations value) =>
        new(default, Optional<CardDonations>.Some(value), default, default, default, default);

    public static PaymentMethod2 GooglePayDonations(GooglePayDonations value) =>
        new(default, default, Optional<GooglePayDonations>.Some(value), default, default, default);

    public static PaymentMethod2 IdealDonations(IdealDonations value) =>
        new(default, default, default, Optional<IdealDonations>.Some(value), default, default);

    public static PaymentMethod2 PayWithGoogleDonations(PayWithGoogleDonations value) =>
        new(default, default, default, default, Optional<PayWithGoogleDonations>.Some(value), default);

    public static PaymentMethod2 StoredPaymentMethod1(StoredPaymentMethod1 value) =>
        new(default, default, default, default, default, Optional<StoredPaymentMethod1>.Some(value));

    public bool TryGetApplePayDonations(out ApplePayDonations value) =>
        _applePayDonationsValue.TryGetValue(out value);

    public bool TryGetCardDonations(out CardDonations value) => _cardDonationsValue.TryGetValue(out value);

    public bool TryGetGooglePayDonations(out GooglePayDonations value) =>
        _googlePayDonationsValue.TryGetValue(out value);

    public bool TryGetIdealDonations(out IdealDonations value) => _idealDonationsValue.TryGetValue(out value);

    public bool TryGetPayWithGoogleDonations(out PayWithGoogleDonations value) =>
        _payWithGoogleDonationsValue.TryGetValue(out value);

    public bool TryGetStoredPaymentMethod1(out StoredPaymentMethod1 value) =>
        _storedPaymentMethod1Value.TryGetValue(out value);

    public static implicit operator PaymentMethod2(ApplePayDonations value) => ApplePayDonations(value);

    public static implicit operator PaymentMethod2(CardDonations value) => CardDonations(value);

    public static implicit operator PaymentMethod2(GooglePayDonations value) => GooglePayDonations(value);

    public static implicit operator PaymentMethod2(IdealDonations value) => IdealDonations(value);

    public static implicit operator PaymentMethod2(PayWithGoogleDonations value) =>
        PayWithGoogleDonations(value);

    public static implicit operator PaymentMethod2(StoredPaymentMethod1 value) => StoredPaymentMethod1(value);
}

file sealed class PaymentMethod2Converter : JsonConverter<PaymentMethod2>
{
    public override PaymentMethod2 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ApplePayDonations>(root, options, out var applePayDonationsValue))
        {
            return PaymentMethod2.ApplePayDonations(applePayDonationsValue);
        }
        if (JsonSerializer.TryDeserialize<CardDonations>(root, options, out var cardDonationsValue))
        {
            return PaymentMethod2.CardDonations(cardDonationsValue);
        }
        if (JsonSerializer.TryDeserialize<GooglePayDonations>(root, options, out var googlePayDonationsValue))
        {
            return PaymentMethod2.GooglePayDonations(googlePayDonationsValue);
        }
        if (JsonSerializer.TryDeserialize<IdealDonations>(root, options, out var idealDonationsValue))
        {
            return PaymentMethod2.IdealDonations(idealDonationsValue);
        }
        if (JsonSerializer.TryDeserialize<PayWithGoogleDonations>(root,
            options,
            out var payWithGoogleDonationsValue))
        {
            return PaymentMethod2.PayWithGoogleDonations(payWithGoogleDonationsValue);
        }
        if (JsonSerializer.TryDeserialize<StoredPaymentMethod1>(root, options, out var storedPaymentMethod1Value))
        {
            return PaymentMethod2.StoredPaymentMethod1(storedPaymentMethod1Value);
        }
        throw new JsonException($"JSON does not match ApplePayDonations or CardDonations or GooglePayDonations or IdealDonations or PayWithGoogleDonations or StoredPaymentMethod1 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PaymentMethod2 value, JsonSerializerOptions options)
    {
        if (value.TryGetApplePayDonations(out var applePayDonationsValue))
        {
            JsonSerializer.Serialize(writer, applePayDonationsValue, options);
        }
        else if (value.TryGetCardDonations(out var cardDonationsValue))
        {
            JsonSerializer.Serialize(writer, cardDonationsValue, options);
        }
        else if (value.TryGetGooglePayDonations(out var googlePayDonationsValue))
        {
            JsonSerializer.Serialize(writer, googlePayDonationsValue, options);
        }
        else if (value.TryGetIdealDonations(out var idealDonationsValue))
        {
            JsonSerializer.Serialize(writer, idealDonationsValue, options);
        }
        else if (value.TryGetPayWithGoogleDonations(out var payWithGoogleDonationsValue))
        {
            JsonSerializer.Serialize(writer, payWithGoogleDonationsValue, options);
        }
        else if (value.TryGetStoredPaymentMethod1(out var storedPaymentMethod1Value))
        {
            JsonSerializer.Serialize(writer, storedPaymentMethod1Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(PaymentMethod2)} contains no valid value to serialize.");
        }
    }
}
