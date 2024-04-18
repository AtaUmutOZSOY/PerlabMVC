using Core.Exceptions;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace Core.Extensions
{
    public class ExceptionMiddleware
    {
        private RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(httpContext, e);
            }
        }

        private Task HandleExceptionAsync(HttpContext httpContext, Exception e)
        {
            httpContext.Response.ContentType = "application/json"; 

            if (e is AuthorizationException authEx)
            {
                httpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                return httpContext.Response.WriteAsync(new ErrorDetails
                {
                    StatusCode = httpContext.Response.StatusCode,
                    Message = authEx.Message // Özel hata mesajını ayarlayın
                }.ToString());
            }
            else if (e is ValidationException valEx)
            {
                httpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return httpContext.Response.WriteAsync(new ErrorDetails
                {
                    StatusCode = httpContext.Response.StatusCode,
                    Message = valEx.Message // Özel hata mesajını ayarlayın
                }.ToString());
            }
            else
            {
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return httpContext.Response.WriteAsync(new ErrorDetails
                {
                    StatusCode = httpContext.Response.StatusCode,
                    Message = "Internal Server Error" // Genel hata mesajı
                }.ToString());
            }
        }

    }
}
