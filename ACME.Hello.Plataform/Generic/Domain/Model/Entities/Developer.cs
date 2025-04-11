namespace ACME.Hello.Plataform.Generic.Domain.Model.Entities;

/// <summary>
/// Represents a Developer entity in the domain model with
/// auto-generated ID
/// </summary>
public class Developer
{
    public Guid Id { get; } = Guid.NewGuid();
    public string FirstName { get; }
    public string LastName { get; }

    public Developer(string firstName, string lastName)
    {
        FirstName = string.IsNullOrWhiteSpace(firstName) ? "" : firstName.Trim();
        LastName = string.IsNullOrWhiteSpace(lastName) ? "" : lastName.Trim();
    }
    
    public string GetFullName() => $"{FirstName} {LastName}".Trim();
    
    public bool IsAnyNameEmpty() => string.IsNullOrWhiteSpace(FirstName) ||
                                    string.IsNullOrWhiteSpace(LastName);
}