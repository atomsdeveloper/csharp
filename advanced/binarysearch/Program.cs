// Algoritomos de busca binária são eficientes para encontrar um elemento em uma coleção ordenada. Podemos usar busca sequencial com complexidade O(n) ou busca binária com complexidade O(log n) se os elementos estiverem ordenados.

// a ideia por trás da busca binária é acessar o elemento do meio da coleção e compará-lo com o valor que estamos procurando. Se o valor for igual, encontramos o elemento. Se o valor for menor, continuamos a busca na metade esquerda da coleção; se for maior, continuamos na metade direita. Repetimos esse processo até encontrar o elemento ou determinar que ele não está presente na coleção.

// Usamos em Csharp o método Array.BinarySearch() para realizar a busca binária em um array ordenado.

using System;
using System.Collections.Generic;

namespace BinarySearchExample {

  class Program {
    static void Main() {
      // Criando um array de inteiros ordenados.
      int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

      // Valor a ser procurado.
      int target = 7;

      // Realizando a busca binária.
      int index = Array.BinarySearch(numbers, target);

      // Verificando o resultado da busca.
      if (index >= 0) {
        Console.WriteLine($"Elemento {target} encontrado no índice {index}.");
      } else {
        Console.WriteLine($"Elemento {target} não encontrado. Índice retornado: {index}.");
      }

      // Exemplo com uma lista genérica.
      List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Fig", "Grape" };
      fruits.Sort(); // A lista deve estar ordenada para a busca binária.

      // Valor a ser procurado
      string fruitToFind = "Cherry";

      // Realizando a busca binária.
      int fruitIndex = fruits.BinarySearch(fruitToFind);

      if (fruitIndex >= 0) {
        Console.WriteLine($"Fruta '{fruitToFind}' encontrada no índice {fruitIndex}.");
      } else {
        Console.WriteLine($"Fruta '{fruitToFind}' não encontrada. Índice retornado: {fruitIndex}.");
      }
    }
  }
}