<!-- Generated file — do not edit; regenerated with the SDK. -->

# PayoutSettingsMerchantLevel — operations

Accessor: `client.PayoutSettingsMerchantLevel` · Source: `src/Adyen/Api/PayoutSettingsMerchantLevel.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsId(DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `PayoutSettingsId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest` | `src/Adyen/Requests/PayoutSettingsMerchantLevel/DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest.cs` |
| `DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError` | `src/Adyen/Errors/DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdPayoutSettings

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdPayoutSettings(GetMerchantsMerchantIdPayoutSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `PayoutSettingsResponse`
- **Error**: `ApiException<GetMerchantsMerchantIdPayoutSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdPayoutSettingsRequest` | `src/Adyen/Requests/PayoutSettingsMerchantLevel/GetMerchantsMerchantIdPayoutSettingsRequest.cs` |
| `PayoutSettingsResponse` | `src/Adyen/Models/PayoutSettingsResponse.cs` |
| `GetMerchantsMerchantIdPayoutSettingsError` | `src/Adyen/Errors/GetMerchantsMerchantIdPayoutSettingsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdPayoutSettingsPayoutSettingsId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdPayoutSettingsPayoutSettingsId(GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `PayoutSettingsId`
- **Returns**: `PayoutSettings`
- **Error**: `ApiException<GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest` | `src/Adyen/Requests/PayoutSettingsMerchantLevel/GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest.cs` |
| `PayoutSettings` | `src/Adyen/Models/PayoutSettings.cs` |
| `GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError` | `src/Adyen/Errors/GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsId(PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `PayoutSettingsId`
- **Returns**: `PayoutSettings`
- **Error**: `ApiException<PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest` | `src/Adyen/Requests/PayoutSettingsMerchantLevel/PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest.cs` |
| `UpdatePayoutSettingsRequest` | `src/Adyen/Models/UpdatePayoutSettingsRequest.cs` |
| `PayoutSettings` | `src/Adyen/Models/PayoutSettings.cs` |
| `PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError` | `src/Adyen/Errors/PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdPayoutSettings

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdPayoutSettings(PostMerchantsMerchantIdPayoutSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `PayoutSettings`
- **Error**: `ApiException<PostMerchantsMerchantIdPayoutSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdPayoutSettingsRequest` | `src/Adyen/Requests/PayoutSettingsMerchantLevel/PostMerchantsMerchantIdPayoutSettingsRequest.cs` |
| `PayoutSettingsRequest` | `src/Adyen/Models/PayoutSettingsRequest.cs` |
| `PayoutSettings` | `src/Adyen/Models/PayoutSettings.cs` |
| `PostMerchantsMerchantIdPayoutSettingsError` | `src/Adyen/Errors/PostMerchantsMerchantIdPayoutSettingsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

