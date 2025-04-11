namespace ACME.Hello.Plataform.Generic.Domain.Interfaces.REST.Resources;

public record GreetDeveloperResponse(Guid? Id, string? FullName, string Message)
{
    public GreetDeveloperResponse(string message) : this(null, null, message) {}
};