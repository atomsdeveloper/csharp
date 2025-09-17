// Typecast se refere a conversão de tipos explicitas, ou seja, devemos converter os valor desejado manualmente.
// Por padrão o C# faz conversões implícitas, ou seja, conversões seguras que não precisam de interferência externa para funcionar.


namespace Typecast
{
  class Type
  {
    static void Main()
    {

      // Conversão Implicita.
      // Como pode ver os tipos são diferentes, onde um tipo 'float' recebe o valor 'int'.
      // Mas é feita a conversão automáticamente.
      int value = 10;
      float otherValue = value;
      
      ystem.Console.WriteLine(otherValue);


      // Conversão Explícita.
      float price = 10.5f;
      int otherPrice = (int)price; // Typecast.

      System.Console.WriteLine(otherPrice);
    }
  }
}