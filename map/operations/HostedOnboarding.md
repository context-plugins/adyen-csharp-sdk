<!-- Generated file — do not edit; regenerated with the SDK. -->

# HostedOnboarding — operations

Accessor: `client.HostedOnboarding` · Source: `src/Adyen/Api/HostedOnboarding.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetThemes

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetThemes(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `OnboardingThemes`
- **Error**: `ApiException<GetThemesError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnboardingThemes` | `src/Adyen/Models/OnboardingThemes.cs` |
| `GetThemesError` | `src/Adyen/Errors/GetThemesError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### GetThemesId

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetThemesId(GetThemesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `OnboardingTheme`
- **Error**: `ApiException<GetThemesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetThemesIdRequest` | `src/Adyen/Requests/HostedOnboarding/GetThemesIdRequest.cs` |
| `OnboardingTheme` | `src/Adyen/Models/OnboardingTheme.cs` |
| `GetThemesIdError` | `src/Adyen/Errors/GetThemesIdError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostLegalEntitiesIdOnboardingLinks

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostLegalEntitiesIdOnboardingLinks(PostLegalEntitiesIdOnboardingLinksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `OnboardingLink`
- **Error**: `ApiException<PostLegalEntitiesIdOnboardingLinksError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostLegalEntitiesIdOnboardingLinksRequest` | `src/Adyen/Requests/HostedOnboarding/PostLegalEntitiesIdOnboardingLinksRequest.cs` |
| `OnboardingLinkInfo` | `src/Adyen/Models/OnboardingLinkInfo.cs` |
| `OnboardingLink` | `src/Adyen/Models/OnboardingLink.cs` |
| `PostLegalEntitiesIdOnboardingLinksError` | `src/Adyen/Errors/PostLegalEntitiesIdOnboardingLinksError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

