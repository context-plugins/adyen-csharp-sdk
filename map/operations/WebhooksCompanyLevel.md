<!-- Generated file — do not edit; regenerated with the SDK. -->

# WebhooksCompanyLevel — operations

Accessor: `client.WebhooksCompanyLevel` · Source: `src/Adyen/Api/WebhooksCompanyLevel.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteCompaniesCompanyIdWebhooksWebhookId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteCompaniesCompanyIdWebhooksWebhookId(DeleteCompaniesCompanyIdWebhooksWebhookIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `WebhookId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteCompaniesCompanyIdWebhooksWebhookIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCompaniesCompanyIdWebhooksWebhookIdRequest` | `src/Adyen/Requests/WebhooksCompanyLevel/DeleteCompaniesCompanyIdWebhooksWebhookIdRequest.cs` |
| `DeleteCompaniesCompanyIdWebhooksWebhookIdError` | `src/Adyen/Errors/DeleteCompaniesCompanyIdWebhooksWebhookIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdWebhooks

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdWebhooks(GetCompaniesCompanyIdWebhooksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListWebhooksResponse`
- **Error**: `ApiException<GetCompaniesCompanyIdWebhooksError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdWebhooksRequest` | `src/Adyen/Requests/WebhooksCompanyLevel/GetCompaniesCompanyIdWebhooksRequest.cs` |
| `ListWebhooksResponse` | `src/Adyen/Models/ListWebhooksResponse.cs` |
| `GetCompaniesCompanyIdWebhooksError` | `src/Adyen/Errors/GetCompaniesCompanyIdWebhooksError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdWebhooksWebhookId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdWebhooksWebhookId(GetCompaniesCompanyIdWebhooksWebhookIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `WebhookId`
- **Returns**: `Webhook`
- **Error**: `ApiException<GetCompaniesCompanyIdWebhooksWebhookIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdWebhooksWebhookIdRequest` | `src/Adyen/Requests/WebhooksCompanyLevel/GetCompaniesCompanyIdWebhooksWebhookIdRequest.cs` |
| `Webhook` | `src/Adyen/Models/Webhook.cs` |
| `GetCompaniesCompanyIdWebhooksWebhookIdError` | `src/Adyen/Errors/GetCompaniesCompanyIdWebhooksWebhookIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchCompaniesCompanyIdWebhooksWebhookId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchCompaniesCompanyIdWebhooksWebhookId(PatchCompaniesCompanyIdWebhooksWebhookIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `WebhookId`
- **Returns**: `Webhook`
- **Error**: `ApiException<PatchCompaniesCompanyIdWebhooksWebhookIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchCompaniesCompanyIdWebhooksWebhookIdRequest` | `src/Adyen/Requests/WebhooksCompanyLevel/PatchCompaniesCompanyIdWebhooksWebhookIdRequest.cs` |
| `UpdateCompanyWebhookRequest` | `src/Adyen/Models/UpdateCompanyWebhookRequest.cs` |
| `Webhook` | `src/Adyen/Models/Webhook.cs` |
| `PatchCompaniesCompanyIdWebhooksWebhookIdError` | `src/Adyen/Errors/PatchCompaniesCompanyIdWebhooksWebhookIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostCompaniesCompanyIdWebhooks

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdWebhooks(PostCompaniesCompanyIdWebhooksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `Webhook`
- **Error**: `ApiException<PostCompaniesCompanyIdWebhooksError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdWebhooksRequest` | `src/Adyen/Requests/WebhooksCompanyLevel/PostCompaniesCompanyIdWebhooksRequest.cs` |
| `CreateCompanyWebhookRequest` | `src/Adyen/Models/CreateCompanyWebhookRequest.cs` |
| `Webhook` | `src/Adyen/Models/Webhook.cs` |
| `PostCompaniesCompanyIdWebhooksError` | `src/Adyen/Errors/PostCompaniesCompanyIdWebhooksError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmac

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmac(PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `WebhookId`
- **Returns**: `GenerateHmacKeyResponse`
- **Error**: `ApiException<PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacRequest` | `src/Adyen/Requests/WebhooksCompanyLevel/PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacRequest.cs` |
| `GenerateHmacKeyResponse` | `src/Adyen/Models/GenerateHmacKeyResponse.cs` |
| `PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacError` | `src/Adyen/Errors/PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostCompaniesCompanyIdWebhooksWebhookIdTest

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdWebhooksWebhookIdTest(PostCompaniesCompanyIdWebhooksWebhookIdTestRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `WebhookId`
- **Returns**: `TestWebhookResponse`
- **Error**: `ApiException<PostCompaniesCompanyIdWebhooksWebhookIdTestError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdWebhooksWebhookIdTestRequest` | `src/Adyen/Requests/WebhooksCompanyLevel/PostCompaniesCompanyIdWebhooksWebhookIdTestRequest.cs` |
| `TestCompanyWebhookRequest` | `src/Adyen/Models/TestCompanyWebhookRequest.cs` |
| `TestWebhookResponse` | `src/Adyen/Models/TestWebhookResponse.cs` |
| `PostCompaniesCompanyIdWebhooksWebhookIdTestError` | `src/Adyen/Errors/PostCompaniesCompanyIdWebhooksWebhookIdTestError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

