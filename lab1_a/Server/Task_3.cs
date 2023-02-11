using System;
using System.Web;

namespace Server
{
    public class Task_3 : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;

            if(request.HttpMethod != "PUT")
            {
                response.StatusCode = 405;
                response.AddHeader("Content-Type", "text/html");
                response.Write("<h1>Method not allowed :(</h1>");
            }
            else
            {
                var firstParameter = context.Request.Form["ParamA"];
                var secondParameter = context.Request.Form["ParamB"];

                response.AddHeader("Content-Type", "text/plain");
                response.Write($"a = {(string.IsNullOrEmpty(firstParameter) ? "null" : firstParameter)}," +
                       $" b = {(string.IsNullOrEmpty(secondParameter) ? "null" : secondParameter)}");
            }
        }
    }
}
