using ACME.Hello.Plataform.Generic.Domain.Interfaces.REST.Resources;
using ACME.Hello.Plataform.Generic.Domain.Model.Entities;

namespace ACME.Hello.Plataform.Generic.Domain.Interfaces.REST.Assemblers;

public static class DeveloperAssembler
{
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest request)
    {
        if (request is null ||
            string.IsNullOrWhiteSpace(request.Firstname) ||
            string.IsNullOrWhiteSpace(request.Lastname))
            return null;
        
        return new Developer(request.Firstname, request.Lastname);
    }
}