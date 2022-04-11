using Baking.Common.Constants;
using Banking.Application.DTO.response;
using Banking.Common.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Banking.Api.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

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
            catch (BankingBaseException ex)
            when (ex is DataNotFoundException ||
             ex is ValidationException)
            {
                await HandleExceptionAsync(httpContext, ex.ErrorCode, ex.Message, HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, AppErrorCodeConstants.UnknownErrorCode, ex.Message, HttpStatusCode.InternalServerError);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, int errorCode, string errorMessage, HttpStatusCode httpStatusCode)
        {
            context.Response.Clear();
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)httpStatusCode;
            await context.Response.WriteAsync(
                JsonSerializer.Serialize(
                new ErrorDetails
                {
                    StatusCode = errorCode,
                    Message = errorMessage
                }));
        }
    }
}
