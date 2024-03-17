// Minha implementação
int fahrenheit = 94;

double celsius = ((fahrenheit - 32) * 0.555555556);

Console.WriteLine($"The temperature is {celsius}");

// Solução do Site
decimal celsiusSite = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine($"The temperature is {celsiusSite} Celsius.");