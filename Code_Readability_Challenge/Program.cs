/*
Convert the message into a char array
Reverse the chars
count the o's
Convert it back to a string
Print it out
*/

string message = "The quick brown fox jumped over the lazy dog.";

char[] charMessage = message.ToCharArray();

Array.Reverse(charMessage);
int count = 0;

foreach (char character in charMessage)
{
  if (character == 'o')
  {
    count++;
  }
}

string newMessage = new string(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {x} times.");