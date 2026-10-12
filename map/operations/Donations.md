<!-- Generated file — do not edit; regenerated with the SDK. -->

# Donations — operations

Accessor: `client.Donations` · Source: `src/Adyen/Api/Donations.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostDonationCampaigns

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDonationCampaigns(PostDonationCampaignsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DonationCampaignsResponse`
- **Error**: `ApiException<PostDonationCampaignsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDonationCampaignsRequest` | `src/Adyen/Requests/Donations/PostDonationCampaignsRequest.cs` |
| `DonationCampaignsRequest` | `src/Adyen/Models/DonationCampaignsRequest.cs` |
| `DonationCampaignsResponse` | `src/Adyen/Models/DonationCampaignsResponse.cs` |
| `PostDonationCampaignsError` | `src/Adyen/Errors/PostDonationCampaignsError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostDonations

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDonations(PostDonationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DonationPaymentResponse`
- **Error**: `ApiException<PostDonationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDonationsRequest` | `src/Adyen/Requests/Donations/PostDonationsRequest.cs` |
| `DonationPaymentRequest` | `src/Adyen/Models/DonationPaymentRequest.cs` |
| `DonationPaymentResponse` | `src/Adyen/Models/DonationPaymentResponse.cs` |
| `PostDonationsError` | `src/Adyen/Errors/PostDonationsError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

