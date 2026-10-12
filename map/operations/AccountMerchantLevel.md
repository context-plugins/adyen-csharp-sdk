<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountMerchantLevel — operations

Accessor: `client.AccountMerchantLevel` · Source: `src/Adyen/Api/AccountMerchantLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMerchants

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchants(GetMerchantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListMerchantResponse`
- **Error**: `ApiException<GetMerchantsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsRequest` | `src/Adyen/Requests/AccountMerchantLevel/GetMerchantsRequest.cs` |
| `ListMerchantResponse` | `src/Adyen/Models/ListMerchantResponse.cs` |
| `GetMerchantsError` | `src/Adyen/Errors/GetMerchantsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantId(GetMerchantsMerchantIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `Merchant`
- **Error**: `ApiException<GetMerchantsMerchantIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdRequest` | `src/Adyen/Requests/AccountMerchantLevel/GetMerchantsMerchantIdRequest.cs` |
| `Merchant` | `src/Adyen/Models/Merchant.cs` |
| `GetMerchantsMerchantIdError` | `src/Adyen/Errors/GetMerchantsMerchantIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchants

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchants(PostMerchantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CreateMerchantResponse`
- **Error**: `ApiException<PostMerchantsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsRequest` | `src/Adyen/Requests/AccountMerchantLevel/PostMerchantsRequest.cs` |
| `CreateMerchantRequest` | `src/Adyen/Models/CreateMerchantRequest.cs` |
| `CreateMerchantResponse` | `src/Adyen/Models/CreateMerchantResponse.cs` |
| `PostMerchantsError` | `src/Adyen/Errors/PostMerchantsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdActivate

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdActivate(PostMerchantsMerchantIdActivateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `RequestActivationResponse`
- **Error**: `ApiException<PostMerchantsMerchantIdActivateError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdActivateRequest` | `src/Adyen/Requests/AccountMerchantLevel/PostMerchantsMerchantIdActivateRequest.cs` |
| `RequestActivationResponse` | `src/Adyen/Models/RequestActivationResponse.cs` |
| `PostMerchantsMerchantIdActivateError` | `src/Adyen/Errors/PostMerchantsMerchantIdActivateError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

