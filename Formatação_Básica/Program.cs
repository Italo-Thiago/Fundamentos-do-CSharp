// Caracteres de escape
// E uma barra invertida "\" seguida pelo caractere que será escapado
// Nova linha "\n"
Console.WriteLine("Hello\nWorld!");

// Novo Guia/Tab "\t"
Console.WriteLine("Hello\tWorld!");

// Usando aspas duplas (\")
Console.WriteLine("Hello \"World\"!");

// Uso de barra invertida (\\)
Console.WriteLine("c:\\source\\repos");

Console.WriteLine();
Console.WriteLine("Generating invoices for customer \"Contoso Corp\"...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Cadeia de caractere textual
// Mantém todo o espaço em branco e os caracteres sem a necessidade de espcar da barra invertida
Console.WriteLine(@"      c:\source\repos
    (this is where your code goes)");

// Caracteres de escape Unicode
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// Concatenação
string firstName = "Italo";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

// Interpolação de strings
// Se usa o prefixo "$" seguido da expressão de interpolação indicada pelo símbolo de chaves ({})
string messageTwo = $"{greeting} {firstName}!";
Console.WriteLine(messageTwo);

int age = 64;
string messageAge = $"{firstName}: {age}";
Console.WriteLine(messageAge);

// Combinando literais textuais e interpolação de strings
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

// Desafio
projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("\nView English output:");
Console.WriteLine($@"  c:\Exercise\{projectName}\data.txt");
Console.WriteLine($"\n{russianMessage}:");
Console.WriteLine($@"  c:\Exercise\{projectName}\ru-RU\data.txt");
