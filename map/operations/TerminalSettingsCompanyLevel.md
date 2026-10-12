<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalSettingsCompanyLevel — operations

Accessor: `client.TerminalSettingsCompanyLevel` · Source: `src/Adyen/Api/TerminalSettingsCompanyLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCompaniesCompanyIdTerminalLogos

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdTerminalLogos(GetCompaniesCompanyIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<GetCompaniesCompanyIdTerminalLogosError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdTerminalLogosRequest` | `src/Adyen/Requests/TerminalSettingsCompanyLevel/GetCompaniesCompanyIdTerminalLogosRequest.cs` |
| `Logo` | `src/Adyen/Models/Logo.cs` |
| `GetCompaniesCompanyIdTerminalLogosError` | `src/Adyen/Errors/GetCompaniesCompanyIdTerminalLogosError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdTerminalSettings

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdTerminalSettings(GetCompaniesCompanyIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<GetCompaniesCompanyIdTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdTerminalSettingsRequest` | `src/Adyen/Requests/TerminalSettingsCompanyLevel/GetCompaniesCompanyIdTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/Adyen/Models/TerminalSettings.cs` |
| `GetCompaniesCompanyIdTerminalSettingsError` | `src/Adyen/Errors/GetCompaniesCompanyIdTerminalSettingsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchCompaniesCompanyIdTerminalLogos

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchCompaniesCompanyIdTerminalLogos(PatchCompaniesCompanyIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<PatchCompaniesCompanyIdTerminalLogosError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchCompaniesCompanyIdTerminalLogosRequest` | `src/Adyen/Requests/TerminalSettingsCompanyLevel/PatchCompaniesCompanyIdTerminalLogosRequest.cs` |
| `Logo` | `src/Adyen/Models/Logo.cs` |
| `PatchCompaniesCompanyIdTerminalLogosError` | `src/Adyen/Errors/PatchCompaniesCompanyIdTerminalLogosError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchCompaniesCompanyIdTerminalSettings

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchCompaniesCompanyIdTerminalSettings(PatchCompaniesCompanyIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<PatchCompaniesCompanyIdTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchCompaniesCompanyIdTerminalSettingsRequest` | `src/Adyen/Requests/TerminalSettingsCompanyLevel/PatchCompaniesCompanyIdTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/Adyen/Models/TerminalSettings.cs` |
| `PatchCompaniesCompanyIdTerminalSettingsError` | `src/Adyen/Errors/PatchCompaniesCompanyIdTerminalSettingsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

