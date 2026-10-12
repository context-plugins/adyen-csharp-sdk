<!-- Generated file — do not edit; regenerated with the SDK. -->

# PciComplianceQuestionnairePage — operations

Accessor: `client.PciComplianceQuestionnairePage` · Source: `src/Adyen/Api/PciComplianceQuestionnairePage.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostGetPciQuestionnaireUrl

- **Server group**: `Default19`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostGetPciQuestionnaireUrl(PostGetPciQuestionnaireUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetPciUrlResponse`
- **Error**: `ApiException<PostGetPciQuestionnaireUrlError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGetPciQuestionnaireUrlRequest` | `src/Adyen/Requests/PciComplianceQuestionnairePage/PostGetPciQuestionnaireUrlRequest.cs` |
| `GetPciUrlRequest` | `src/Adyen/Models/GetPciUrlRequest.cs` |
| `GetPciUrlResponse` | `src/Adyen/Models/GetPciUrlResponse.cs` |
| `PostGetPciQuestionnaireUrlError` | `src/Adyen/Errors/PostGetPciQuestionnaireUrlError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

