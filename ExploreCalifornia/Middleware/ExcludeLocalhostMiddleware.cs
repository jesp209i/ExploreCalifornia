using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Middleware
{
    public class ExcludeLocalhostMiddleware
    {
        private readonly RequestDelegate _next;

        public ExcludeLocalhostMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            if (context.Connection.RemoteIpAddress.ToString() == "::1")
            {
                context.Response.StatusCode = 401;
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
