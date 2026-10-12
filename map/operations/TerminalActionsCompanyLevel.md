<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalActionsCompanyLevel — operations

Accessor: `client.TerminalActionsCompanyLevel` · Source: `src/Adyen/Api/TerminalActionsCompanyLevel.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCompaniesCompanyIdTerminalActions

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdTerminalActions(GetCompaniesCompanyIdTerminalActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `status` ← `Status`, `type` ← `Type`
- **Returns**: `ListExternalTerminalActionsResponse`
- **Error**: `ApiException<GetCompaniesCompanyIdTerminalActionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdTerminalActionsRequest` | `src/Adyen/Requests/TerminalActionsCompanyLevel/GetCompaniesCompanyIdTerminalActionsRequest.cs` |
| `ListExternalTerminalActionsResponse` | `src/Adyen/Models/ListExternalTerminalActionsResponse.cs` |
| `GetCompaniesCompanyIdTerminalActionsError` | `src/Adyen/Errors/GetCompaniesCompanyIdTerminalActionsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdTerminalActionsActionId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdTerminalActionsActionId(GetCompaniesCompanyIdTerminalActionsActionIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ActionId`
- **Returns**: `ExternalTerminalAction`
- **Error**: `ApiException<GetCompaniesCompanyIdTerminalActionsActionIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdTerminalActionsActionIdRequest` | `src/Adyen/Requests/TerminalActionsCompanyLevel/GetCompaniesCompanyIdTerminalActionsActionIdRequest.cs` |
| `ExternalTerminalAction` | `src/Adyen/Models/ExternalTerminalAction.cs` |
| `GetCompaniesCompanyIdTerminalActionsActionIdError` | `src/Adyen/Errors/GetCompaniesCompanyIdTerminalActionsActionIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

