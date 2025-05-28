using Microsoft.AspNetCore.Http.Extensions;
using MVC.Data;
using MVC.Models;

namespace MVC.MidlleWare
{
    public class RequestLogMiddleware
    {
        private readonly RequestDelegate _next;
        public RequestLogMiddleware(RequestDelegate next) {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, ApplicationDbContext dbContext)
        {
            var ip = httpContext.Connection.RemoteIpAddress?.ToString();
            var url = httpContext.Request.GetDisplayUrl();

            var newLog = new RequestLog() { From = ip ?? "", RequestUrl = url, RequestDate = DateTime.Now };
            dbContext.Add(newLog);
            dbContext.SaveChanges();
            await _next(httpContext);
        }
        public void Invoke(HttpContext context, ApplicationDbContext dbContext)
        {
            InvokeAsync(context, dbContext).Wait();
        }
    }
}
