// Este é um loop extremamente usado para ler dados de um 'array' ou outros.
// Isto é, não pode ser usado para atribuição de valores, ele é somente leitura.
// Muito parecido com o 'for', porém é mais simples de se trabalhar.
namespace Foreach
{
  class Foreach
  {
    static void Main()
    {
      int[] array = new int[3] { 10, 20, 30 };

      // Dentro de 'foreach' a leitura é simples, se lê 'para cada'. E 'in' se lê 'em'.
      // Ou seja, para cada 'item' do tipo 'int' em 'array'. Ele executa o código dentro do seu escobo.
      foreach (int item in array)
      {
        System.Console.WriteLine(item);
      }
    }
  }
}