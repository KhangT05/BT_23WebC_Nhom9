using Microsoft.AspNetCore.Http.Extensions;
public class RequestMiddleware
{
    private readonly RequestDelegate _next;

    public RequestMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        string url = httpContext.Request.Path;
        DateTime date = DateTime.Now;
        string ip = httpContext.Connection.RemoteIpAddress.ToString();
        string log = $"Url: {url}, Datetime: {date}, Ip: {ip}";
        string filepath = "./Logs/request.log";
        File.AppendAllText(filepath, log + Environment.NewLine);
        Console.WriteLine("Log hoàn tất!!!");
        await _next(httpContext);
    }
}