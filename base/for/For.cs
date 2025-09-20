// For é bastante conhecido por consta dos 'loops', que é onde ocorre a repetição de determinado bloco de código.
// Amplamente usado para leituras de arrays ou matrizes ou até mesmo para inicializa-las com valores.
// Também é usado na maioria das vezes quando sabemos a quantidade de vezes que o bloco de código deve ser repetido.

namespace For
{
    class LoopFor
    {
        static void Main()
        {
            // Neste caso a váriavel 'value' só pode ser lida fora do escobo de 'for'. Onde 'value' é declarada fora do 'for' e usada dentro do 'for' para atribuição.
            // Onde 'value' se inicia com '0', depois é feita a verificação se 'value' é menor que o 10, caso seja 'true' a variável 'value' recebe + 1.
            int value;
            for (value = 0; value < 10; value++)
            {
                // Isto é, o valor atual de 'value' é exibido até que o 'value' seja igual á 10.
                System.Console.WriteLine("Value: {0}", value);
            }

            System.Console.WriteLine("-------------------------------------");

            // Podemos iterar sobre um 'array' ou 'matriz'.
            // Neste exemplo usamos o 'array' com 10 'indices' para valores inteiros.
            int[] array = new int[10];

            // Neste caso a váriavel 'i' só pode ser lida dentro do escobo de 'for'.
            // Onde 'i' se inicia com '0', depois é feita a verificação se 'i' é menor que o comprimento do 'array', caso seja 'true' a variável 'i' recebe + 1.
            for (int i = 0; i < array.Length; i++)
            {
                // Isto é, o valor atual de 'i' é atribuido ao indice atual do array 'array[i]'.
                array[i] = i; // EX: array[0] = 0, array[1] = 1 ...

                System.Console.WriteLine("Array: {0}", array[i]);
            }
        }
    }
}
