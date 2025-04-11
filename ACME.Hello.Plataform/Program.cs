using ACME.Hello.Plataform.Generic.Domain.Interfaces.REST.Assemblers;
using ACME.Hello.Plataform.Generic.Domain.Interfaces.REST.Resources;
using ACME.Hello.Plataform.Generic.Domain.Model.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.MapGet("/greetings", (string? firstName, string? lastName) =>
{
    var developer = !string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName)
        ? new Developer(firstName, lastName)
        : null;
    var response = GreetDeveloperAssembler.ToResponseFromEntity(developer);
    return Results.Ok(response);
}).WithName("GetGreetings").WithOpenApi();

app.MapPost("/greetings", (GreetDeveloperRequest request) =>
{
    var developer = DeveloperAssembler.ToEntityFromRequest(request);
    var response = GreetDeveloperAssembler.ToResponseFromEntity(developer);
    return Results.Created("/greetings", response);
}).WithName("CreateGreetings").WithOpenApi();
app.Run();
