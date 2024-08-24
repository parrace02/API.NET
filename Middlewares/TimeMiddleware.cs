//El middleware TimeMiddleware es una forma sencilla de agregar lógica de respuesta condicional basada en parámetros de consulta en solicitudes HTTP. Responde con la hora actual si se incluye el parámetro "Time" en la consulta, permitiendo así una funcionalidad útil para depuración o para mostrar información al usuario.
using System.Data;

public class TimeMiddleware
{
    readonly RequestDelegate next;
    public TimeMiddleware(RequestDelegate nextRequest)
    {
        next=nextRequest;
    }
    public async Task Invoke(Microsoft.AspNetCore.Http.HttpContext context)
    {
        await next(context);
        if(context.Request.Query.Any(p=> p.Key == "Time"))
        {
            await context.Response.WriteAsJsonAsync(DateTime.Now.ToShortTimeString());
        }
    }
}
public static class TimeMiddlewareExtension
{
    public static IApplicationBuilder UseTimeMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<TimeMiddleware>();
    }
}
