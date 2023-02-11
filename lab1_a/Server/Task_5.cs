using System;
using System.Web;

namespace Server
{
    public class Task_5 : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            var request = context.Request;
            var response = context.Response;

            response.AddHeader("Content-Type", "text/html");

            switch (request.HttpMethod)
            {
                case "GET":
                    response.WriteFile("Task5.html");
                    break;
                case "POST":
                    try
                    {
                        var firstParameter = int.Parse(request.Form["ParamA"]);
                        var secondParameter = int.Parse(request.Form["ParamB"]);

                        response.Write(firstParameter * secondParameter);
                    }
                    catch
                    {
                        response.Write("<h2>One of the parameters or both are not correct! :(</h2>");
                    }
                    break;
                default:
                    response.Write("<h2>Method not allowed :(</h2>");
                    break;
            }
        }
    }
}
