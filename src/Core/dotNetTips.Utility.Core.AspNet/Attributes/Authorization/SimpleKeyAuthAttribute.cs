using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace dotNetTips.Utility.Core.AspNet.Attributes.Authorization
{
    /// <summary>
    /// Auth class that uses a simple key. This class cannot be inherited.
    /// Implements the <see cref="System.Attribute" />
    /// Implements the <see cref="Microsoft.AspNetCore.Mvc.Filters.IAsyncActionFilter" />
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Filters.IAsyncActionFilter" />
    /// <remarks>Original code from this video: https://www.youtube.com/watch?v=Zo3T_See7iI </remarks>
    [AttributeUsage(validOn: AttributeTargets.Class | AttributeTargets.Method)]
    public sealed class SimpleKeyAuthAttribute : Attribute, IAsyncActionFilter
    {
        private const string ApiKeyHeaderName = "ApiKey";

        /// <summary>
        /// On action execution as an asynchronous operation.
        /// </summary>
        /// <param name="context">The <see cref="T:Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext" />.</param>
        /// <param name="next">The <see cref="T:Microsoft.AspNetCore.Mvc.Filters.ActionExecutionDelegate" />. Invoked to execute the next action filter or the action itself.</param>
        /// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that on completion indicates the filter has executed.</returns>
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            // Make sure there is the auth header
            if (context.HttpContext.Request.Headers.TryGetValue(ApiKeyHeaderName, out var apiKey) == false)
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            // Get key from config file
            var keyFromConfig = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>().GetValue<string>(key: ApiKeyHeaderName);

            // Validate key
            if (keyFromConfig.Equals(apiKey, StringComparison.Ordinal) == false)
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            _ = await next();
        }
    }
}