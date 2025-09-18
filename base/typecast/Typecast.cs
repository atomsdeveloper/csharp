// Typecast se refere a conversão de tipos explicitas, ou seja, devemos converter os valor desejado manualmente.
// Por padrão o C# faz conversões implícitas, ou seja, conversões seguras que não precisam de interferência externa para funcionar.

namespace Typecast
{
  class Type
  {
    static void Main()
    {

      // Conversão Implicita.
      // Como pode ver os tipos são diferentes, onde um tipo 'int' recebe o valor 'float'.
      // Mas é feita a conversão automáticamente. Isso ocorre porque o C# pode indentificar o tipo de forma autonoma.
      // Para entender vamos usar a matemática, o número 10 pode ser convertido de forma autonoma pois um 'Int' 10 é o memsmo que um 'Float' 10.0f.
      int value = 10;
      float otherValue = value;
      
      ystem.Console.WriteLine(otherValue);


      // Conversão Explícita.
      // Como pode ver os tipos também são diferentes, onde um tipo 'float' recebe o valor 'int'.
      // Mas aqui não é feita a conversão automáticamente. Isso ocorre porque o C# nçao pode indentificar o tipo de forma autonoma.
      // Para entender vamos usar a matemática, o número 10.5f não pode ser convertido de forma autonoma pois um 'Float' 10.5f  não é o memsmo que um 'Int' 10.0.
      // Neste caso precisamos fazer a conversão. Ou seja, antes de atribuir o valor 'float' para um valor 'int' é necessário passar o valor 'float' para 'int'.
      float price = 10.5f;
      int otherPrice = (int)price; // Typecast.

      System.Console.WriteLine(otherPrice);
    }
  }
}