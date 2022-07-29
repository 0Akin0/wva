// See https://aka.ms/new-console-template for more information
using wva;
using wvaConsoleInterface;

Console.WriteLine("Enter Weather data:");
Console.Write("Temperatue in Celsius: ");
var temperature = Console.ReadLine();
Console.Write("Wind speed in km/h: ");
var wind = Console.ReadLine();
Console.Write("Weather status 1=Sunny, 2=Rainy: ");
var statusCode = Console.ReadLine();

WeatherStatus status;

if (int.Parse(statusCode) == 1)
    status = WeatherStatus.Sun;
else
    status = WeatherStatus.Rain;

WeatherData data = new WeatherData(double.Parse(temperature), int.Parse(wind), status);
ClothingSuggestion suggester = new ClothingSuggestion(data);
Presenter presenter = new Presenter();
string suggestedClothing = presenter.SuggestionsToString(suggester.SuggestClothing());
Console.WriteLine("I suggest you wear this kind of clothing: " + suggestedClothing);