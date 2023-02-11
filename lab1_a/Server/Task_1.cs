using System;
using System.Web;
using System.Xml.Linq;

namespace Server
{
    public class Task_1 : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse httpResponse = context.Response;

            var firstParameter = context.Request.QueryString["a"];
            var secondParameter = context.Request.QueryString["b"];

            httpResponse.AddHeader("Content-Type", "text/plain");
            httpResponse.Write($"a = {(firstParameter == null ? "null" : firstParameter)}," + 
                   $" b = {(secondParameter == null? "null" : secondParameter)}");
                    
        }
    }
}
