using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace October7thMiddleware.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await httpContext.Response.WriteAsync("<p> This is custom middleware !!!! </p>");
                await _next(httpContext);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
