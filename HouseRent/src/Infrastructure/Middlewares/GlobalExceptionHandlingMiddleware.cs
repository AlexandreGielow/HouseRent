﻿using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace HouseRent.src.Infrastructure.Middlewares
{
    public class GlobalExceptionHandlingMiddleware : IMiddleware
    {

        private readonly ILogger<GlobalExceptionHandlingMiddleware> _logger;

        public GlobalExceptionHandlingMiddleware (ILogger<GlobalExceptionHandlingMiddleware> logger)
        {

            _logger = logger;
        }   

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                ProblemDetails problem = new()
                {
                    Status = (int)HttpStatusCode.InternalServerError,
                    Type = "Server Error",
                    Title = e.Message,
                    Detail = "An Internal Server error has occurred"
                };

                string json = JsonSerializer.Serialize(problem);

                await context.Response.WriteAsync(json);

                context.Response.ContentType = "application/json";
            }
        }
    }
}
