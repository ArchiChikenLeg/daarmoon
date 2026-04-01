using Daarmoon.Services;
using Daarmoon.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var cards = new List<Card>
{
    new Card { Id = 1, Name = "Chiyoko", Attack = 1, Dodge = 0, Defence = 3 },
    new Card { Id = 2, Name = "Arata", Attack = 2, Dodge = 2, Defence = 4 }
};

app.MapGet("/cards", () => cards);

app.MapGet("/test-fight", () =>
{
    var card1 = cards[0];
    var card2 = cards[1];

    var service = new GameService();

    service.Attack(card1, card2);

    return card2;
});


app.MapGet("/hello", () => "Hello from your card game server!");

app.Run();

