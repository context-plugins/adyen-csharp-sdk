<!-- Generated file — do not edit; regenerated with the SDK. -->

# Utility — operations

Accessor: `client.Utility` · Source: `src/Adyen/Api/Utility.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostApplePaySessions

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostApplePaySessions(PostApplePaySessionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ApplePaySessionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostApplePaySessionsRequest` | `src/Adyen/Requests/Utility/PostApplePaySessionsRequest.cs` |
| `ApplePaySessionRequest` | `src/Adyen/Models/ApplePaySessionRequest.cs` |
| `ApplePaySessionResponse` | `src/Adyen/Models/ApplePaySessionResponse.cs` |

### PostOriginKeys

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostOriginKeys(PostOriginKeysRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UtilityResponse`
- **Error**: `ApiException<PostOriginKeysError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostOriginKeysRequest` | `src/Adyen/Requests/Utility/PostOriginKeysRequest.cs` |
| `UtilityRequest` | `src/Adyen/Models/UtilityRequest.cs` |
| `UtilityResponse` | `src/Adyen/Models/UtilityResponse.cs` |
| `PostOriginKeysError` | `src/Adyen/Errors/PostOriginKeysError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostPaypalUpdateOrder

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPaypalUpdateOrder(PostPaypalUpdateOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaypalUpdateOrderResponse`
- **Error**: `ApiException<PostPaypalUpdateOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaypalUpdateOrderRequest` | `src/Adyen/Requests/Utility/PostPaypalUpdateOrderRequest.cs` |
| `PaypalUpdateOrderRequest` | `src/Adyen/Models/PaypalUpdateOrderRequest.cs` |
| `PaypalUpdateOrderResponse` | `src/Adyen/Models/PaypalUpdateOrderResponse.cs` |
| `PostPaypalUpdateOrderError` | `src/Adyen/Errors/PostPaypalUpdateOrderError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostValidateShopperId

- **Signature**: `PostValidateShopperId(PostValidateShopperIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ValidateShopperIdResponse`
- **Error**: `ApiException<PostValidateShopperIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetCheckoutErrorResponseEntity(out CheckoutErrorResponseEntity)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostValidateShopperIdRequest` | `src/Adyen/Requests/Utility/PostValidateShopperIdRequest.cs` |
| `ValidateShopperIdRequest` | `src/Adyen/Models/ValidateShopperIdRequest.cs` |
| `ValidateShopperIdResponse` | `src/Adyen/Models/ValidateShopperIdResponse.cs` |
| `PostValidateShopperIdError` | `src/Adyen/Errors/PostValidateShopperIdError.cs` |
| `CheckoutErrorResponseEntity` | `src/Adyen/Models/CheckoutErrorResponseEntity.cs` |

