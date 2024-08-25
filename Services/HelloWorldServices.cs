public class HelloWorkldService : IHelloworklService
{
    public string GetHelloWorld()
    {
        return "Hello World API";
    }
}

public interface IHelloworklService
{
    string GetHelloWorld();
}