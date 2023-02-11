using System;
using System.Web;

namespace Server
{
    public class Task_4 : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;

            if (request.HttpMethod != "POST")
            {
                response.StatusCode = 405;
                response.AddHeader("Content-Type", "text/html");
                response.Write("<h1>Method not allowed :(</h1>");
            }
            else
            {
                try
                {
                    var x = int.Parse(request.Form["x"]);
                    var y = int.Parse(request.Form["y"]);

                    response.AddHeader("Content-Type", "text/plain");
                    response.Write(x + y);
                }
                catch
                {
                    response.AddHeader("Content-Type", "text/plain");
                    response.Write("Enter correct numbers!");
                }
            }
        }
    }
}
