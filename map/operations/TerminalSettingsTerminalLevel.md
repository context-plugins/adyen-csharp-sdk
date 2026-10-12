<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalSettingsTerminalLevel — operations

Accessor: `client.TerminalSettingsTerminalLevel` · Source: `src/Adyen/Api/TerminalSettingsTerminalLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTerminalsTerminalIdTerminalLogos

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetTerminalsTerminalIdTerminalLogos(GetTerminalsTerminalIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TerminalId`
- **Returns**: `Logo`
- **Error**: `ApiException<GetTerminalsTerminalIdTerminalLogosError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalsTerminalIdTerminalLogosRequest` | `src/Adyen/Requests/TerminalSettingsTerminalLevel/GetTerminalsTerminalIdTerminalLogosRequest.cs` |
| `Logo` | `src/Adyen/Models/Logo.cs` |
| `GetTerminalsTerminalIdTerminalLogosError` | `src/Adyen/Errors/GetTerminalsTerminalIdTerminalLogosError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetTerminalsTerminalIdTerminalSettings

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetTerminalsTerminalIdTerminalSettings(GetTerminalsTerminalIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TerminalId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<GetTerminalsTerminalIdTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalsTerminalIdTerminalSettingsRequest` | `src/Adyen/Requests/TerminalSettingsTerminalLevel/GetTerminalsTerminalIdTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/Adyen/Models/TerminalSettings.cs` |
| `GetTerminalsTerminalIdTerminalSettingsError` | `src/Adyen/Errors/GetTerminalsTerminalIdTerminalSettingsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchTerminalsTerminalIdTerminalLogos

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchTerminalsTerminalIdTerminalLogos(PatchTerminalsTerminalIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TerminalId`
- **Returns**: `Logo`
- **Error**: `ApiException<PatchTerminalsTerminalIdTerminalLogosError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchTerminalsTerminalIdTerminalLogosRequest` | `src/Adyen/Requests/TerminalSettingsTerminalLevel/PatchTerminalsTerminalIdTerminalLogosRequest.cs` |
| `Logo` | `src/Adyen/Models/Logo.cs` |
| `PatchTerminalsTerminalIdTerminalLogosError` | `src/Adyen/Errors/PatchTerminalsTerminalIdTerminalLogosError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchTerminalsTerminalIdTerminalSettings

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchTerminalsTerminalIdTerminalSettings(PatchTerminalsTerminalIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TerminalId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<PatchTerminalsTerminalIdTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchTerminalsTerminalIdTerminalSettingsRequest` | `src/Adyen/Requests/TerminalSettingsTerminalLevel/PatchTerminalsTerminalIdTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/Adyen/Models/TerminalSettings.cs` |
| `PatchTerminalsTerminalIdTerminalSettingsError` | `src/Adyen/Errors/PatchTerminalsTerminalIdTerminalSettingsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

