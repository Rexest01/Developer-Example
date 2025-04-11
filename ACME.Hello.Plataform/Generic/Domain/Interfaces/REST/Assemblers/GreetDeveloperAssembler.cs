using ACME.Hello.Plataform.Generic.Domain.Interfaces.REST.Resources;
using ACME.Hello.Plataform.Generic.Domain.Model.Entities;

namespace ACME.Hello.Plataform.Generic.Domain.Interfaces.REST.Assemblers;

public static class GreetDeveloperAssembler
{
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? developer)
    {
        if (developer is null || developer.IsAnyNameEmpty()) 
            return new GreetDeveloperResponse("Welcome Anonymous ASP.NET Developer");
            return new GreetDeveloperResponse(developer.Id, developer.GetFullName(),
            $"Congrats {developer.GetFullName()}! You are an ASP.NET developer");

    }
}

