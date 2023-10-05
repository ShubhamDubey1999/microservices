using Microsoft.AspNetCore.Authentication;
using System.Net.Http.Headers;
namespace Krishna.Services.ShoppingCart.Service.Utility
{
    public class BackendApiAuthenticationHttpClientHandler:DelegatingHandler
    {
        // Delegating handler are kind of similar to the Dotnet core middleware , but the main difference is that delegating handlers are on client side.
        // So let's say if you are making an HTTP request using HTTP client, we can leverage the delegating handler to pass our bearer token to the other request.
        private readonly IHttpContextAccessor _accessor;
        public BackendApiAuthenticationHttpClientHandler(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = await _accessor.HttpContext.GetTokenAsync("access_token");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer",token);
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
