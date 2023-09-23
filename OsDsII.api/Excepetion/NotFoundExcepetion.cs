using System.Net;

namespace OsDsII.api.Excepetion
{
    public class NotFoundExcepetion : BaseException
    {
        public NotFoundExcepetion(string resource) :
            base(
                "ERROR:001",
                $"{resource} not found",
                HttpStatusCode.NotFound,
                StatusCodes.Status404NotFound,
                DateTimeOffset.UtcNow,
                null
                )
        { }

        public NotFoundExcepetion(string message , Exception ex) :
           base(
               "ERROR:001",
               message,
               HttpStatusCode.NotFound,
               StatusCodes.Status404NotFound,
               DateTimeOffset.UtcNow,
               ex
               )
        { }


    }
}
