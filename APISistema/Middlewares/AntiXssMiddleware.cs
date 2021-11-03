using Ganss.XSS;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class AntiXssMiddleware
{
    private readonly RequestDelegate _next;

    public AntiXssMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        httpContext.Request.EnableBuffering();

        using (var streamReader = new StreamReader
              (httpContext.Request.Body, Encoding.UTF8, leaveOpen: true))
        {
            var raw = await streamReader.ReadToEndAsync();
            var sanitiser = new HtmlSanitizer();
            var sanitised = sanitiser.Sanitize(raw);

            if (raw != sanitised)
            {
                throw new BadHttpRequestException("XSS injection detected from middleware.");
            }
        }

        httpContext.Request.Body.Seek(0, SeekOrigin.Begin);
        await _next.Invoke(httpContext);
    }
}