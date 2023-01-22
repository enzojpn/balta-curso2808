var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () => "Hello teste!");

app.MapGet("/nome/{user}", (String user) => $"Hello {user}!");

app.MapPost("/", (User user)=>{
    return Results.Ok(user.nome + " Tevez");
});

app.Run();

public class User{
    public int id { get; set; }

    public String nome { get; set; }
}