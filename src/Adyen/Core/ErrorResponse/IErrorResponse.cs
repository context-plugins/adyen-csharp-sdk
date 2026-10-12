using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.Models;

namespace Adyen.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}