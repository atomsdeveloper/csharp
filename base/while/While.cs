// Este loop é usado quando não sabemos a quantidade de vezes que vamos executar um determinado bloco de código.
// Amplamente usado para leituras de arrays ou até mesmo para inicializa-las com valores.
// Difente de for 'while' só recebe como param a condição do loop e não a inicializaçõa da variável e nem a incrementação.
// A Declaração de váriavel deve ser feita fora do escobo 'while' e a incrementação deve ser feita dentro do escobo 'while'.

namespace While
{
  class While
  {
    static void Main()
    {
      int value;
      int[] array = new int[10];

      // O 'Length' sempre retorna o tamanho total do 'array' que neste caso é 10, porém os número de 'index' vão somente até o 9.
      // Pois como já sabemos um array sempre tem 'index' inciando da posição 0.    
      value = array.Length - 1;

      // Este loop se lê 'enquanto', então enquanto o 'value' for maior que 0...
      // O bloco de código do 'while' será executado.
      while (value > 0)
      {
        array[value] = value;
        System.Console.WriteLine("Array: {0}", array[value]);
        // Para decrementar mais um ao 'value' deve-se ser inserido dentro do bloco de código. 
        value--;
      }

      System.Console.WriteLine("End.");
    }
  }
}