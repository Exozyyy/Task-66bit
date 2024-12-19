using CoreL;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var player = new FPlayer
{
    Name = "John",
    Surname = "Doe",
    Sex = "Male",
    DateOfBirthday = "1990-01-01", 
    Country = "USA"
};

Console.WriteLine(player.ToString());

app.MapGet("/", () => player.ToString());
app.Run();
