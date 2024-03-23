// Concatenão != Adição
// Quando adicionamos o sinal (+) a duas variaveis com valor númerico o C# faz uma adição e não concatenação
// Concatenação => Hello World!
string word = "Hello ";
string wordTwo = "World!";
Console.WriteLine(word + wordTwo);

// Adição => 35
int number = 20;
int numberTwo = 15;
Console.WriteLine(number + numberTwo);

// Mudança implicita de int para string
string firstName = "Bob";
Console.WriteLine(firstName + " sold " + number + 7 + " widgets.");

// Bob sold 207 widgets

// Adicionando parênteses para ordem de precedência
Console.WriteLine(firstName + " sold " + (number + 7) + " widgets.");

// Bob sold 27 widgets

/* Operadores Aritméticos   Operadores de Atribuição   Operadores Lógicos   Operadores de Comparação
 * +---------------+---+    +----+                    +-----+----+          +----------------+----+
 * | Adição        | + |    | += |                    | AND | && |          | Igual          | == |
 * | Subtração     | - |    | -= |                    | OR  | || |          | Diferente      | != |
 * | Multiplicação | * |    | *= |                    | NOT | !  |          | Maior que      | >  |
 * | Divisão       | / |    | /= |                    +-----+----+          | Menor que      | <  |
 * | Módulo        | % |    +----+                                          | Maior ou igual | >= |
 * +---------------+---+                                                    | Menor ou igual | <= |
 *                                                                          +----------------+----+
 */

// Adição
int sum = 7 + 5;

// Subtração
int difference = 7 - 5;

// Multiplicação
int product = 7 * 5;

// Divisão
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// Incremento e Decremento => value++
// Atribuição Composta => value += 1, Incrementa logo em seguida atribui o resultado à variável original
int value = 1;

value = value + 1;
Console.WriteLine("\nFirst increment: value + 1" + value);

value += 1;
Console.WriteLine("Second increment: value += 1" + value);

value++;
Console.WriteLine("Third increment: value++" + value);

value = value - 1;
Console.WriteLine("First decrement: value - 1" + value);

value -= 1;
Console.WriteLine("Second decrement: value -= 1" + value);

value--;
Console.WriteLine("Third decrement: value--" + value);

// Operador de incremento antes e depois do valor
value = 0;
value = 1;
value++;
Console.WriteLine("\nFirst: " + value);
Console.WriteLine("Recupera o Valor depois incrementa => value++");
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Incrementa e depois recupera o valor => ++value");
Console.WriteLine("Fourth: " + (++value));
