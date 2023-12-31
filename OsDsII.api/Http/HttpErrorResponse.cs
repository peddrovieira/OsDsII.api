﻿namespace OsDsII.api.Http
{
    public record HttpErrorResponse
    {
        public string ErrorCode { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public DateTimeOffset Timestemp {get; set;}

        public HttpErrorResponse(string errorCode, string message, int statusCode, DateTimeOffset timestamp ) 
        {
            ErrorCode = errorCode;
            Message = message;
            StatusCode = statusCode;
            Timestemp = timestamp;
        }
        
    }
}
