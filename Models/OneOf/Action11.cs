using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models.OneOf;

/// <summary>
/// Action to be taken for completing the payment.
/// </summary>
[JsonConverter(typeof(Action11Converter))]
public record Action11
{
    private readonly Optional<CheckoutBankTransferAction> _checkoutBankTransferActionValue;

    private readonly Optional<CheckoutQrCodeAction> _checkoutQrCodeActionValue;

    private readonly Optional<CheckoutNativeRedirectAction> _checkoutNativeRedirectActionValue;

    private readonly Optional<CheckoutRedirectAction> _checkoutRedirectActionValue;

    private readonly Optional<CheckoutSdkAction> _checkoutSdkActionValue;

    private readonly Optional<CheckoutThreeDs2Action> _checkoutThreeDs2ActionValue;

    private readonly Optional<CheckoutDelegatedAuthenticationAction> _checkoutDelegatedAuthenticationActionValue;

    private readonly Optional<CheckoutAwaitAction> _checkoutAwaitActionValue;

    private readonly Optional<CheckoutVoucherAction> _checkoutVoucherActionValue;

    private Action11(Optional<CheckoutBankTransferAction> checkoutBankTransferActionValue,
        Optional<CheckoutQrCodeAction> checkoutQrCodeActionValue,
        Optional<CheckoutNativeRedirectAction> checkoutNativeRedirectActionValue,
        Optional<CheckoutRedirectAction> checkoutRedirectActionValue,
        Optional<CheckoutSdkAction> checkoutSdkActionValue,
        Optional<CheckoutThreeDs2Action> checkoutThreeDs2ActionValue,
        Optional<CheckoutDelegatedAuthenticationAction> checkoutDelegatedAuthenticationActionValue,
        Optional<CheckoutAwaitAction> checkoutAwaitActionValue,
        Optional<CheckoutVoucherAction> checkoutVoucherActionValue)
    {
        _checkoutBankTransferActionValue = checkoutBankTransferActionValue;
        _checkoutQrCodeActionValue = checkoutQrCodeActionValue;
        _checkoutNativeRedirectActionValue = checkoutNativeRedirectActionValue;
        _checkoutRedirectActionValue = checkoutRedirectActionValue;
        _checkoutSdkActionValue = checkoutSdkActionValue;
        _checkoutThreeDs2ActionValue = checkoutThreeDs2ActionValue;
        _checkoutDelegatedAuthenticationActionValue = checkoutDelegatedAuthenticationActionValue;
        _checkoutAwaitActionValue = checkoutAwaitActionValue;
        _checkoutVoucherActionValue = checkoutVoucherActionValue;
    }

    public static Action11 CheckoutBankTransferAction(CheckoutBankTransferAction value) =>
        new(Optional<CheckoutBankTransferAction>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static Action11 CheckoutQrCodeAction(CheckoutQrCodeAction value) =>
        new(default,
            Optional<CheckoutQrCodeAction>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static Action11 CheckoutNativeRedirectAction(CheckoutNativeRedirectAction value) =>
        new(default,
            default,
            Optional<CheckoutNativeRedirectAction>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    public static Action11 CheckoutRedirectAction(CheckoutRedirectAction value) =>
        new(default,
            default,
            default,
            Optional<CheckoutRedirectAction>.Some(value),
            default,
            default,
            default,
            default,
            default);

    public static Action11 CheckoutSdkAction(CheckoutSdkAction value) =>
        new(default,
            default,
            default,
            default,
            Optional<CheckoutSdkAction>.Some(value),
            default,
            default,
            default,
            default);

    public static Action11 CheckoutThreeDs2Action(CheckoutThreeDs2Action value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<CheckoutThreeDs2Action>.Some(value),
            default,
            default,
            default);

    public static Action11 CheckoutDelegatedAuthenticationAction(CheckoutDelegatedAuthenticationAction value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<CheckoutDelegatedAuthenticationAction>.Some(value),
            default,
            default);

    public static Action11 CheckoutAwaitAction(CheckoutAwaitAction value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<CheckoutAwaitAction>.Some(value),
            default);

    public static Action11 CheckoutVoucherAction(CheckoutVoucherAction value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<CheckoutVoucherAction>.Some(value));

    public bool TryGetCheckoutBankTransferAction(out CheckoutBankTransferAction value) =>
        _checkoutBankTransferActionValue.TryGetValue(out value);

    public bool TryGetCheckoutQrCodeAction(out CheckoutQrCodeAction value) =>
        _checkoutQrCodeActionValue.TryGetValue(out value);

    public bool TryGetCheckoutNativeRedirectAction(out CheckoutNativeRedirectAction value) =>
        _checkoutNativeRedirectActionValue.TryGetValue(out value);

    public bool TryGetCheckoutRedirectAction(out CheckoutRedirectAction value) =>
        _checkoutRedirectActionValue.TryGetValue(out value);

    public bool TryGetCheckoutSdkAction(out CheckoutSdkAction value) =>
        _checkoutSdkActionValue.TryGetValue(out value);

    public bool TryGetCheckoutThreeDs2Action(out CheckoutThreeDs2Action value) =>
        _checkoutThreeDs2ActionValue.TryGetValue(out value);

    public bool TryGetCheckoutDelegatedAuthenticationAction(out CheckoutDelegatedAuthenticationAction value) =>
        _checkoutDelegatedAuthenticationActionValue.TryGetValue(out value);

    public bool TryGetCheckoutAwaitAction(out CheckoutAwaitAction value) =>
        _checkoutAwaitActionValue.TryGetValue(out value);

    public bool TryGetCheckoutVoucherAction(out CheckoutVoucherAction value) =>
        _checkoutVoucherActionValue.TryGetValue(out value);

    public static implicit operator Action11(CheckoutBankTransferAction value) =>
        CheckoutBankTransferAction(value);

    public static implicit operator Action11(CheckoutQrCodeAction value) => CheckoutQrCodeAction(value);

    public static implicit operator Action11(CheckoutNativeRedirectAction value) =>
        CheckoutNativeRedirectAction(value);

    public static implicit operator Action11(CheckoutRedirectAction value) => CheckoutRedirectAction(value);

    public static implicit operator Action11(CheckoutSdkAction value) => CheckoutSdkAction(value);

    public static implicit operator Action11(CheckoutThreeDs2Action value) => CheckoutThreeDs2Action(value);

    public static implicit operator Action11(CheckoutDelegatedAuthenticationAction value) =>
        CheckoutDelegatedAuthenticationAction(value);

    public static implicit operator Action11(CheckoutAwaitAction value) => CheckoutAwaitAction(value);

    public static implicit operator Action11(CheckoutVoucherAction value) => CheckoutVoucherAction(value);
}

file sealed class Action11Converter : JsonConverter<Action11>
{
    public override Action11 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
            "bankTransfer" => Action11.CheckoutBankTransferAction(root.Deserialize<CheckoutBankTransferAction>(options)!),
            "qrCode" => Action11.CheckoutQrCodeAction(root.Deserialize<CheckoutQrCodeAction>(options)!),
            "nativeRedirect" => Action11.CheckoutNativeRedirectAction(root.Deserialize<CheckoutNativeRedirectAction>(options)!),
            "redirect" => Action11.CheckoutRedirectAction(root.Deserialize<CheckoutRedirectAction>(options)!),
            "sdk" or "wechatpaySDK" => Action11.CheckoutSdkAction(root.Deserialize<CheckoutSdkAction>(options)!),
            "threeDS2" => Action11.CheckoutThreeDs2Action(root.Deserialize<CheckoutThreeDs2Action>(options)!),
            "delegatedAuthentication" => Action11.CheckoutDelegatedAuthenticationAction(root.Deserialize<CheckoutDelegatedAuthenticationAction>(options)!),
            "await" => Action11.CheckoutAwaitAction(root.Deserialize<CheckoutAwaitAction>(options)!),
            "voucher" => Action11.CheckoutVoucherAction(root.Deserialize<CheckoutVoucherAction>(options)!),
            _ => throw new JsonException($"JSON does not match CheckoutBankTransferAction or CheckoutQrCodeAction or CheckoutNativeRedirectAction or CheckoutRedirectAction or CheckoutSdkAction or CheckoutThreeDs2Action or CheckoutDelegatedAuthenticationAction or CheckoutAwaitAction or CheckoutVoucherAction schemas: {root.ToString()}")
        };
    }

    public override void Write(Utf8JsonWriter writer, Action11 value, JsonSerializerOptions options)
    {
        if (value.TryGetCheckoutBankTransferAction(out var checkoutBankTransferActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutBankTransferActionValue, options);
        }
        else if (value.TryGetCheckoutQrCodeAction(out var checkoutQrCodeActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutQrCodeActionValue, options);
        }
        else if (value.TryGetCheckoutNativeRedirectAction(out var checkoutNativeRedirectActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutNativeRedirectActionValue, options);
        }
        else if (value.TryGetCheckoutRedirectAction(out var checkoutRedirectActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutRedirectActionValue, options);
        }
        else if (value.TryGetCheckoutSdkAction(out var checkoutSdkActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutSdkActionValue, options);
        }
        else if (value.TryGetCheckoutThreeDs2Action(out var checkoutThreeDs2ActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutThreeDs2ActionValue, options);
        }
        else if (value.TryGetCheckoutDelegatedAuthenticationAction(out var checkoutDelegatedAuthenticationActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutDelegatedAuthenticationActionValue, options);
        }
        else if (value.TryGetCheckoutAwaitAction(out var checkoutAwaitActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutAwaitActionValue, options);
        }
        else if (value.TryGetCheckoutVoucherAction(out var checkoutVoucherActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutVoucherActionValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Action11)} contains no valid value to serialize.");
        }
    }
}
