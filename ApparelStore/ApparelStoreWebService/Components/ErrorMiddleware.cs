using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApparelStoreWebService.Components
{
    public class ExceptionHandlingServiceMiddleware
    {
        public RequestDelegate Next;
        public ExceptionHandlingServiceMiddleware(RequestDelegate Next)
        {
            this.Next = Next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await Next.Invoke(context);
            }
            catch (Exception e)
            {
                context.Response.ContentType = "application/json";
                
                await context.Response.WriteAsync(e.Message);
                
            }
        }
    }
}
