<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalSettingsMerchantLevel — operations

Accessor: `client.TerminalSettingsMerchantLevel` · Source: `src/Adyen/Api/TerminalSettingsMerchantLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMerchantsMerchantIdTerminalLogos

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdTerminalLogos(GetMerchantsMerchantIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<GetMerchantsMerchantIdTerminalLogosError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdTerminalLogosRequest` | `src/Adyen/Requests/TerminalSettingsMerchantLevel/GetMerchantsMerchantIdTerminalLogosRequest.cs` |
| `Logo` | `src/Adyen/Models/Logo.cs` |
| `GetMerchantsMerchantIdTerminalLogosError` | `src/Adyen/Errors/GetMerchantsMerchantIdTerminalLogosError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdTerminalSettings

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdTerminalSettings(GetMerchantsMerchantIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<GetMerchantsMerchantIdTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdTerminalSettingsRequest` | `src/Adyen/Requests/TerminalSettingsMerchantLevel/GetMerchantsMerchantIdTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/Adyen/Models/TerminalSettings.cs` |
| `GetMerchantsMerchantIdTerminalSettingsError` | `src/Adyen/Errors/GetMerchantsMerchantIdTerminalSettingsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchMerchantsMerchantIdTerminalLogos

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchMerchantsMerchantIdTerminalLogos(PatchMerchantsMerchantIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<PatchMerchantsMerchantIdTerminalLogosError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMerchantsMerchantIdTerminalLogosRequest` | `src/Adyen/Requests/TerminalSettingsMerchantLevel/PatchMerchantsMerchantIdTerminalLogosRequest.cs` |
| `Logo` | `src/Adyen/Models/Logo.cs` |
| `PatchMerchantsMerchantIdTerminalLogosError` | `src/Adyen/Errors/PatchMerchantsMerchantIdTerminalLogosError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchMerchantsMerchantIdTerminalSettings

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchMerchantsMerchantIdTerminalSettings(PatchMerchantsMerchantIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<PatchMerchantsMerchantIdTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMerchantsMerchantIdTerminalSettingsRequest` | `src/Adyen/Requests/TerminalSettingsMerchantLevel/PatchMerchantsMerchantIdTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/Adyen/Models/TerminalSettings.cs` |
| `PatchMerchantsMerchantIdTerminalSettingsError` | `src/Adyen/Errors/PatchMerchantsMerchantIdTerminalSettingsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

