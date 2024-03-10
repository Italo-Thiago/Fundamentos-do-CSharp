// Forma estatica de declarar variáveis
// O proprio programador deve declarar o tipo da variável
string firstName;
firstName = "Italo";
Console.WriteLine(firstName);

firstName = "António";
Console.WriteLine(firstName);

firstName = "José";
Console.WriteLine(firstName);

// Forma dinamica de declarar variáveis
// O compilador declara o tipo da variável pelo valor atribuido a mesma
var message = "Hello world!";
Console.WriteLine(message);

// Não ocorre conversão implicita de tipos
// Portanto o exemplo abaixo da erro
//message = 10.703m;
//Console.WriteLine(message);

// Exibindo valores de variáveis
string name;
int messages;
double temperature;

name = "Bob";
messages = 3;
temperature = 34.4;

Console.WriteLine("Hello, " + name + "! You have " + messages + " messages in your inbox. The temperature is " + temperature + " celsius");

