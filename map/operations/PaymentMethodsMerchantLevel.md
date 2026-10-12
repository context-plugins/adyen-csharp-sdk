<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentMethodsMerchantLevel — operations

Accessor: `client.PaymentMethodsMerchantLevel` · Source: `src/Adyen/Api/PaymentMethodsMerchantLevel.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMerchantsMerchantIdPaymentMethodSettings

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdPaymentMethodSettings(GetMerchantsMerchantIdPaymentMethodSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `storeId` ← `StoreId`, `businessLineId` ← `BusinessLineId`, `pageSize` ← `PageSize`, `pageNumber` ← `PageNumber`
- **Returns**: `PaymentMethodResponse`
- **Error**: `ApiException<GetMerchantsMerchantIdPaymentMethodSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdPaymentMethodSettingsRequest` | `src/Adyen/Requests/PaymentMethodsMerchantLevel/GetMerchantsMerchantIdPaymentMethodSettingsRequest.cs` |
| `PaymentMethodResponse` | `src/Adyen/Models/PaymentMethodResponse.cs` |
| `GetMerchantsMerchantIdPaymentMethodSettingsError` | `src/Adyen/Errors/GetMerchantsMerchantIdPaymentMethodSettingsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `PaymentMethodId`
- **Returns**: `ManagementPaymentMethod`
- **Error**: `ApiException<GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest` | `src/Adyen/Requests/PaymentMethodsMerchantLevel/GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest.cs` |
| `ManagementPaymentMethod` | `src/Adyen/Models/ManagementPaymentMethod.cs` |
| `GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError` | `src/Adyen/Errors/GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomains

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomains(GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `PaymentMethodId`
- **Returns**: `ApplePayResponseInfo`
- **Error**: `ApiException<GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsRequest` | `src/Adyen/Requests/PaymentMethodsMerchantLevel/GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsRequest.cs` |
| `ApplePayResponseInfo` | `src/Adyen/Models/ApplePayResponseInfo.cs` |
| `GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError` | `src/Adyen/Errors/GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `PaymentMethodId`
- **Returns**: `ManagementPaymentMethod`
- **Error**: `ApiException<PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest` | `src/Adyen/Requests/PaymentMethodsMerchantLevel/PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest.cs` |
| `UpdatePaymentMethodInfo` | `src/Adyen/Models/UpdatePaymentMethodInfo.cs` |
| `ManagementPaymentMethod` | `src/Adyen/Models/ManagementPaymentMethod.cs` |
| `PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError` | `src/Adyen/Errors/PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdPaymentMethodSettings

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdPaymentMethodSettings(PostMerchantsMerchantIdPaymentMethodSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `ManagementPaymentMethod`
- **Error**: `ApiException<PostMerchantsMerchantIdPaymentMethodSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdPaymentMethodSettingsRequest` | `src/Adyen/Requests/PaymentMethodsMerchantLevel/PostMerchantsMerchantIdPaymentMethodSettingsRequest.cs` |
| `PaymentMethodSetupInfo` | `src/Adyen/Models/PaymentMethodSetupInfo.cs` |
| `ManagementPaymentMethod` | `src/Adyen/Models/ManagementPaymentMethod.cs` |
| `PostMerchantsMerchantIdPaymentMethodSettingsError` | `src/Adyen/Errors/PostMerchantsMerchantIdPaymentMethodSettingsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomains

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomains(PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `PaymentMethodId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsRequest` | `src/Adyen/Requests/PaymentMethodsMerchantLevel/PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsRequest.cs` |
| `ApplePayInfo` | `src/Adyen/Models/ApplePayInfo.cs` |
| `PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsError` | `src/Adyen/Errors/PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

