using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GatewayService
{
    public class Handler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return base.SendAsync(request, cancellationToken);
        }
    }
}
