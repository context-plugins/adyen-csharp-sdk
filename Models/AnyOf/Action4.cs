using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// Action to be taken for completing the payment.
/// </summary>
[JsonConverter(typeof(Action4Converter))]
public record Action4
{
    private readonly Optional<CheckoutAwaitAction> _checkoutAwaitActionValue;

    private readonly Optional<CheckoutBankTransferAction> _checkoutBankTransferActionValue;

    private readonly Optional<CheckoutDelegatedAuthenticationAction> _checkoutDelegatedAuthenticationActionValue;

    private readonly Optional<CheckoutNativeRedirectAction> _checkoutNativeRedirectActionValue;

    private readonly Optional<CheckoutQrCodeAction> _checkoutQrCodeActionValue;

    private readonly Optional<CheckoutRedirectAction> _checkoutRedirectActionValue;

    private readonly Optional<CheckoutSdkaction> _checkoutSdkactionValue;

    private readonly Optional<CheckoutThreeDs2Action> _checkoutThreeDs2ActionValue;

    private readonly Optional<CheckoutVoucherAction> _checkoutVoucherActionValue;

    private Action4(Optional<CheckoutAwaitAction> checkoutAwaitActionValue,
        Optional<CheckoutBankTransferAction> checkoutBankTransferActionValue,
        Optional<CheckoutDelegatedAuthenticationAction> checkoutDelegatedAuthenticationActionValue,
        Optional<CheckoutNativeRedirectAction> checkoutNativeRedirectActionValue,
        Optional<CheckoutQrCodeAction> checkoutQrCodeActionValue,
        Optional<CheckoutRedirectAction> checkoutRedirectActionValue,
        Optional<CheckoutSdkaction> checkoutSdkactionValue,
        Optional<CheckoutThreeDs2Action> checkoutThreeDs2ActionValue,
        Optional<CheckoutVoucherAction> checkoutVoucherActionValue)
    {
        _checkoutAwaitActionValue = checkoutAwaitActionValue;
        _checkoutBankTransferActionValue = checkoutBankTransferActionValue;
        _checkoutDelegatedAuthenticationActionValue = checkoutDelegatedAuthenticationActionValue;
        _checkoutNativeRedirectActionValue = checkoutNativeRedirectActionValue;
        _checkoutQrCodeActionValue = checkoutQrCodeActionValue;
        _checkoutRedirectActionValue = checkoutRedirectActionValue;
        _checkoutSdkactionValue = checkoutSdkactionValue;
        _checkoutThreeDs2ActionValue = checkoutThreeDs2ActionValue;
        _checkoutVoucherActionValue = checkoutVoucherActionValue;
    }

    public static Action4 CheckoutAwaitAction(CheckoutAwaitAction value) =>
        new(Optional<CheckoutAwaitAction>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static Action4 CheckoutBankTransferAction(CheckoutBankTransferAction value) =>
        new(default,
            Optional<CheckoutBankTransferAction>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static Action4 CheckoutDelegatedAuthenticationAction(CheckoutDelegatedAuthenticationAction value) =>
        new(default,
            default,
            Optional<CheckoutDelegatedAuthenticationAction>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    public static Action4 CheckoutNativeRedirectAction(CheckoutNativeRedirectAction value) =>
        new(default,
            default,
            default,
            Optional<CheckoutNativeRedirectAction>.Some(value),
            default,
            default,
            default,
            default,
            default);

    public static Action4 CheckoutQrCodeAction(CheckoutQrCodeAction value) =>
        new(default,
            default,
            default,
            default,
            Optional<CheckoutQrCodeAction>.Some(value),
            default,
            default,
            default,
            default);

    public static Action4 CheckoutRedirectAction(CheckoutRedirectAction value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<CheckoutRedirectAction>.Some(value),
            default,
            default,
            default);

    public static Action4 CheckoutSdkaction(CheckoutSdkaction value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<CheckoutSdkaction>.Some(value),
            default,
            default);

    public static Action4 CheckoutThreeDs2Action(CheckoutThreeDs2Action value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<CheckoutThreeDs2Action>.Some(value),
            default);

    public static Action4 CheckoutVoucherAction(CheckoutVoucherAction value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<CheckoutVoucherAction>.Some(value));

    public bool TryGetCheckoutAwaitAction(out CheckoutAwaitAction value) =>
        _checkoutAwaitActionValue.TryGetValue(out value);

    public bool TryGetCheckoutBankTransferAction(out CheckoutBankTransferAction value) =>
        _checkoutBankTransferActionValue.TryGetValue(out value);

    public bool TryGetCheckoutDelegatedAuthenticationAction(out CheckoutDelegatedAuthenticationAction value) =>
        _checkoutDelegatedAuthenticationActionValue.TryGetValue(out value);

    public bool TryGetCheckoutNativeRedirectAction(out CheckoutNativeRedirectAction value) =>
        _checkoutNativeRedirectActionValue.TryGetValue(out value);

    public bool TryGetCheckoutQrCodeAction(out CheckoutQrCodeAction value) =>
        _checkoutQrCodeActionValue.TryGetValue(out value);

    public bool TryGetCheckoutRedirectAction(out CheckoutRedirectAction value) =>
        _checkoutRedirectActionValue.TryGetValue(out value);

    public bool TryGetCheckoutSdkaction(out CheckoutSdkaction value) =>
        _checkoutSdkactionValue.TryGetValue(out value);

    public bool TryGetCheckoutThreeDs2Action(out CheckoutThreeDs2Action value) =>
        _checkoutThreeDs2ActionValue.TryGetValue(out value);

    public bool TryGetCheckoutVoucherAction(out CheckoutVoucherAction value) =>
        _checkoutVoucherActionValue.TryGetValue(out value);

    public static implicit operator Action4(CheckoutAwaitAction value) => CheckoutAwaitAction(value);

    public static implicit operator Action4(CheckoutBankTransferAction value) =>
        CheckoutBankTransferAction(value);

    public static implicit operator Action4(CheckoutDelegatedAuthenticationAction value) =>
        CheckoutDelegatedAuthenticationAction(value);

    public static implicit operator Action4(CheckoutNativeRedirectAction value) =>
        CheckoutNativeRedirectAction(value);

    public static implicit operator Action4(CheckoutQrCodeAction value) => CheckoutQrCodeAction(value);

    public static implicit operator Action4(CheckoutRedirectAction value) => CheckoutRedirectAction(value);

    public static implicit operator Action4(CheckoutSdkaction value) => CheckoutSdkaction(value);

    public static implicit operator Action4(CheckoutThreeDs2Action value) => CheckoutThreeDs2Action(value);

    public static implicit operator Action4(CheckoutVoucherAction value) => CheckoutVoucherAction(value);
}

file sealed class Action4Converter : JsonConverter<Action4>
{
    public override Action4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<CheckoutAwaitAction>(root, options, out var checkoutAwaitActionValue))
        {
            return Action4.CheckoutAwaitAction(checkoutAwaitActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutBankTransferAction>(root,
            options,
            out var checkoutBankTransferActionValue))
        {
            return Action4.CheckoutBankTransferAction(checkoutBankTransferActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutDelegatedAuthenticationAction>(root,
            options,
            out var checkoutDelegatedAuthenticationActionValue))
        {
            return Action4.CheckoutDelegatedAuthenticationAction(checkoutDelegatedAuthenticationActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutNativeRedirectAction>(root,
            options,
            out var checkoutNativeRedirectActionValue))
        {
            return Action4.CheckoutNativeRedirectAction(checkoutNativeRedirectActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutQrCodeAction>(root, options, out var checkoutQrCodeActionValue))
        {
            return Action4.CheckoutQrCodeAction(checkoutQrCodeActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutRedirectAction>(root,
            options,
            out var checkoutRedirectActionValue))
        {
            return Action4.CheckoutRedirectAction(checkoutRedirectActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutSdkaction>(root, options, out var checkoutSdkactionValue))
        {
            return Action4.CheckoutSdkaction(checkoutSdkactionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutThreeDs2Action>(root,
            options,
            out var checkoutThreeDs2ActionValue))
        {
            return Action4.CheckoutThreeDs2Action(checkoutThreeDs2ActionValue);
        }
        if (JsonSerializer.TryDeserialize<CheckoutVoucherAction>(root, options, out var checkoutVoucherActionValue))
        {
            return Action4.CheckoutVoucherAction(checkoutVoucherActionValue);
        }
        throw new JsonException($"JSON does not match CheckoutAwaitAction or CheckoutBankTransferAction or CheckoutDelegatedAuthenticationAction or CheckoutNativeRedirectAction or CheckoutQrCodeAction or CheckoutRedirectAction or CheckoutSdkaction or CheckoutThreeDs2Action or CheckoutVoucherAction schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Action4 value, JsonSerializerOptions options)
    {
        if (value.TryGetCheckoutAwaitAction(out var checkoutAwaitActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutAwaitActionValue, options);
        }
        else if (value.TryGetCheckoutBankTransferAction(out var checkoutBankTransferActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutBankTransferActionValue, options);
        }
        else if (value.TryGetCheckoutDelegatedAuthenticationAction(out var checkoutDelegatedAuthenticationActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutDelegatedAuthenticationActionValue, options);
        }
        else if (value.TryGetCheckoutNativeRedirectAction(out var checkoutNativeRedirectActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutNativeRedirectActionValue, options);
        }
        else if (value.TryGetCheckoutQrCodeAction(out var checkoutQrCodeActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutQrCodeActionValue, options);
        }
        else if (value.TryGetCheckoutRedirectAction(out var checkoutRedirectActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutRedirectActionValue, options);
        }
        else if (value.TryGetCheckoutSdkaction(out var checkoutSdkactionValue))
        {
            JsonSerializer.Serialize(writer, checkoutSdkactionValue, options);
        }
        else if (value.TryGetCheckoutThreeDs2Action(out var checkoutThreeDs2ActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutThreeDs2ActionValue, options);
        }
        else if (value.TryGetCheckoutVoucherAction(out var checkoutVoucherActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutVoucherActionValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Action4)} contains no valid value to serialize.");
        }
    }
}
