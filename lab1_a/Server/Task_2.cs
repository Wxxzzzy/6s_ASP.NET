using System;
using System.Web;

namespace Server
{
    public class Task_2 : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;
            HttpRequest request = context.Request;

            if (request.HttpMethod != "POST")
            {
                response.StatusCode = 405;
                response.AddHeader("Content-Type", "text/html");
                response.Write("<h1>Method not allowed :(</h1>");
            }
            else
            {
                var firstParameter = context.Request.Form["paramA"];
                var secondParameter = context.Request.Form["paramB"];

                response.AddHeader("Content-Type", "text/plain");
                response.Write($"a = {(string.IsNullOrEmpty(firstParameter) ? "null" : firstParameter)}," +
                       $" b = {(string.IsNullOrEmpty(secondParameter) ? "null" : secondParameter)}");
            }
        }
    }
}
