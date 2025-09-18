// Recebendo valores do teclado e atribuindo as variáveis.
// Para receber valores do teclado usamos o método 'Write' presente no 'Console'.
// Para armazenar valores do teclado em uma variável usamos o método 'ReadLine' presente no 'Console'.
// Neste caso, como os valores recebidos vem no formato 'string' é preciso converte-los explicitamente para 'int' -> Typecast.
// Para isso usamos o método 'Parse' presente no tipo que queremos receber.
// Isto é, como queremos somar valores, precisamos converter de 'string' para 'int', então com 'int' usamos o método 'Parse' que é um método.
namespace Keyborad
{
  class ReadKeyboard
  {
    static void Main()
    {
      int value, valueTwo, result;

      System.Console.Write("Dígite um valor: ");
      // Isto é, o valor recebido de 'Write' linha acima, será lido pela 'ReadLine' e armazenado dentro de 'value' fazendo o 'Parse' de 'string' para 'int'. 
      value = int.Parse(System.Console.ReadLine());

      System.Console.Write("Dígite outro valor: ");
      // Isto é, o valor recebido de 'Write' linha acima, será lido pela 'ReadLine' e armazenado dentro de 'value' fazendo o 'Parse' de 'string' para 'int'. 
      valueTwo = int.Parse(System.Console.ReadLine());

      result = value + valueTwo;

      System.Console.WriteLine("\n A soma dos valores dígitados é: {0}", result);

    }
  }
}