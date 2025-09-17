// Recebendo valores do teclado e atribuindo as variáveis.
// Para receber valores do teclado usamos o método 'Write' presente no 'console'.
// Para armazenar valores do teclado em uma variável usamos o método 'ReadLine' presente no 'Console'.
// Neste caso, como os valores recebido vem no formato 'string' é preciso converte-los explicitamente para 'int'.
// Para isso usamos o método 'Parse' presente no tipo que queremos receber.
// Isto é, como queremos somar valores, precisamos converter de 'strin' para 'int', então dentro de 'int' usamos o método 'Parse'.
namespace Keyborad
{
  class ReadKeyboard
  {
    static void Main()
    {
      int value, valueTwo, result;

      System.Console.Write("Dígite um valor: ");
      value = int.Parse(System.Console.ReadLine());
      System.Console.Write("Dígite outro valor: ");
      valueTwo = int.Parse(System.Console.ReadLine());

      result = value + valueTwo;

      System.Console.WriteLine("\n A soma dos valores dígitados é: {0}", result);

    }
  }
}