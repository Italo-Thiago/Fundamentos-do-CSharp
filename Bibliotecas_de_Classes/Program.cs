Console.WriteLine("\nA biblioteca de classes do .NET fornece uma grande variedade de funcionalidades que podem ser usadas simplesmente conferindo as classes e os métodos necessários.");

Console.WriteLine("\nAté mesmo seus tipos de dados fazem parte da biblioteca de classes do .NET. O C# simplesmente fornece um alias para esses tipos de dados");

Console.WriteLine("\nA maior referencia para a biblioteca de classe e a Documentação e Sites de Terceiros");

Console.WriteLine("\nComo chamar métodos na Biblioteca de Classes do .NET");
Console.WriteLine(@"
Comece digitando o nome da classe. Neste caso, o nome da classe é (Console)
Adicione o operador de acesso de membro, o símbolo (.)
Adicione o nome do método. Neste caso, o nome do método é (WriteLine.)
Adicione o operador de chamada do método, que é um conjunto de parênteses ().
Finalmente, especifique os argumentos que serão transmitidos ao método, se houver algum, entre os parênteses do operador de invocação de método. Aqui, você especifica o texto que deseja que o método (Console.WriteLine()) escreva no console (por exemplo, (Hello World)
");

Console.WriteLine("\n");
// Instanciação da classe Random
Random dice = new Random();
// atribui a roll o valor de dice que utiliza um método chamado Next() que randomiza um valor inteiro de 1 a 7.
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

Console.WriteLine("\n Métodos com estado vs sem estado");
Console.WriteLine(@"
Estado => Descreve a condição do ambiente de execução em um momento específico no tempo
")