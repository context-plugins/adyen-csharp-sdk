<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalSettingsStoreLevel — operations

Accessor: `client.TerminalSettingsStoreLevel` · Source: `src/Adyen/Api/TerminalSettingsStoreLevel.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMerchantsMerchantIdStoresReferenceTerminalLogos

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdStoresReferenceTerminalLogos(GetMerchantsMerchantIdStoresReferenceTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Reference`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<GetMerchantsMerchantIdStoresReferenceTerminalLogosError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdStoresReferenceTerminalLogosRequest` | `src/Adyen/Requests/TerminalSettingsStoreLevel/GetMerchantsMerchantIdStoresReferenceTerminalLogosRequest.cs` |
| `Logo` | `src/Adyen/Models/Logo.cs` |
| `GetMerchantsMerchantIdStoresReferenceTerminalLogosError` | `src/Adyen/Errors/GetMerchantsMerchantIdStoresReferenceTerminalLogosError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdStoresReferenceTerminalSettings

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdStoresReferenceTerminalSettings(GetMerchantsMerchantIdStoresReferenceTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Reference`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<GetMerchantsMerchantIdStoresReferenceTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdStoresReferenceTerminalSettingsRequest` | `src/Adyen/Requests/TerminalSettingsStoreLevel/GetMerchantsMerchantIdStoresReferenceTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/Adyen/Models/TerminalSettings.cs` |
| `GetMerchantsMerchantIdStoresReferenceTerminalSettingsError` | `src/Adyen/Errors/GetMerchantsMerchantIdStoresReferenceTerminalSettingsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetStoresStoreIdTerminalLogos

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetStoresStoreIdTerminalLogos(GetStoresStoreIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StoreId`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<GetStoresStoreIdTerminalLogosError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetStoresStoreIdTerminalLogosRequest` | `src/Adyen/Requests/TerminalSettingsStoreLevel/GetStoresStoreIdTerminalLogosRequest.cs` |
| `Logo` | `src/Adyen/Models/Logo.cs` |
| `GetStoresStoreIdTerminalLogosError` | `src/Adyen/Errors/GetStoresStoreIdTerminalLogosError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetStoresStoreIdTerminalSettings

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetStoresStoreIdTerminalSettings(GetStoresStoreIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StoreId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<GetStoresStoreIdTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetStoresStoreIdTerminalSettingsRequest` | `src/Adyen/Requests/TerminalSettingsStoreLevel/GetStoresStoreIdTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/Adyen/Models/TerminalSettings.cs` |
| `GetStoresStoreIdTerminalSettingsError` | `src/Adyen/Errors/GetStoresStoreIdTerminalSettingsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchMerchantsMerchantIdStoresReferenceTerminalLogos

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchMerchantsMerchantIdStoresReferenceTerminalLogos(PatchMerchantsMerchantIdStoresReferenceTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Reference`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<PatchMerchantsMerchantIdStoresReferenceTerminalLogosError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMerchantsMerchantIdStoresReferenceTerminalLogosRequest` | `src/Adyen/Requests/TerminalSettingsStoreLevel/PatchMerchantsMerchantIdStoresReferenceTerminalLogosRequest.cs` |
| `Logo` | `src/Adyen/Models/Logo.cs` |
| `PatchMerchantsMerchantIdStoresReferenceTerminalLogosError` | `src/Adyen/Errors/PatchMerchantsMerchantIdStoresReferenceTerminalLogosError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchMerchantsMerchantIdStoresReferenceTerminalSettings

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchMerchantsMerchantIdStoresReferenceTerminalSettings(PatchMerchantsMerchantIdStoresReferenceTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Reference`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMerchantsMerchantIdStoresReferenceTerminalSettingsRequest` | `src/Adyen/Requests/TerminalSettingsStoreLevel/PatchMerchantsMerchantIdStoresReferenceTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/Adyen/Models/TerminalSettings.cs` |
| `PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError` | `src/Adyen/Errors/PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchStoresStoreIdTerminalLogos

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchStoresStoreIdTerminalLogos(PatchStoresStoreIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StoreId`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<PatchStoresStoreIdTerminalLogosError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchStoresStoreIdTerminalLogosRequest` | `src/Adyen/Requests/TerminalSettingsStoreLevel/PatchStoresStoreIdTerminalLogosRequest.cs` |
| `Logo` | `src/Adyen/Models/Logo.cs` |
| `PatchStoresStoreIdTerminalLogosError` | `src/Adyen/Errors/PatchStoresStoreIdTerminalLogosError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchStoresStoreIdTerminalSettings

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchStoresStoreIdTerminalSettings(PatchStoresStoreIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StoreId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<PatchStoresStoreIdTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchStoresStoreIdTerminalSettingsRequest` | `src/Adyen/Requests/TerminalSettingsStoreLevel/PatchStoresStoreIdTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/Adyen/Models/TerminalSettings.cs` |
| `PatchStoresStoreIdTerminalSettingsError` | `src/Adyen/Errors/PatchStoresStoreIdTerminalSettingsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

