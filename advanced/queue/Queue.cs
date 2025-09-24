// Representa uma coleção inicial de objetos.
// Criando uma fila de cadeias de caracteres com capacidade padrão e usa o método 'Enqueue' para enfilerar 5 cadeias de caracteres. 
// Os elementos da fila são enumerados, o que não altera o estado da fila.
// O método 'Dequeue' é usado para desativar a primeira cadeia de caracteres. O método 'Peek' serve para examinar o primiero item na fila. 

// Essa classe implementa uma fila genérica como uma matriz circular. Objetos armazenados em um 'Queue<T>' são inseridos em uma extremidade e removida da outra.
// Isto é útil quando se precisa de armazenamento temporário para obter informações. Quando quer descartar um elemento depois de recuperar seu valor.
// Usada para acessar informações na mesma ordem em que são armazenadas na coleção.
// 'Stack<t>' Para acessar informações de forma inversa.

// Três operações princiáis executadas em um 'Queue<T>' e seus elementos.

// 'Enqueue' adiciona uma valor ao final do 'Queue<T>'.
// 'Dequeue' remove um elemento mais antigo do inicio do 'Queue<T>'.
// 'Peek' espiar retorna o elementos mais antifo que está no inicio do 'Queue<T>', mas não remove do 'Queue<T>'.

// https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.queue-1?view=net-9.0

using System.Collections.Generic; 

namespace QueueExemple {

  class Program {
    static void Main() {
      Queue<string> values = new Queue<string>();

      // Adiciona elementos ao final da fila.
      values.Enqueue("one");
      values.Enqueue("two");
      values.Enqueue("three");

      // Passando pelos elementos de 'values'.
      foreach (var value in values) {
        System.Console.WriteLine(value);
      }

      System.Console.WriteLine("\nDequeuing '{0}'", values.Dequeue());
      System.Console.WriteLine("Peek at next item to dequeue: {0}", values.Peek());
      System.Console.WriteLine("Dequeuing '{0}'", values.Dequeue());

      // Copiando a 'Queue' á partir da queue já criada.
      Queue<string> valuesCopy = new Queue<string>(values.ToArray());

      // Passando pelos elementos copiados de 'values' para 'valuesCopy'.
      foreach (var valueCopy in valuesCopy) {
        System.Console.WriteLine("Values of vetor copy: {0}", valueCopy);
      }

      // Verifica se um valor está presente dentro da fila.
      bool hasProps = valuesCopy.Contains("one");

      if (hasProps) {
        System.Console.WriteLine("Encontrado");
      } else {
        System.Console.WriteLine("Não Encontrado");
      }

      // Pega a quantidade de elementos presentes na fila.
      int currentValuesCopy = valuesCopy.Count;
      System.Console.WriteLine(currentValuesCopy);

      // Verifica qual a capacidade de elementos presentes na fila.
      // int capacityValuesCopy = valuesCopy.Capacity;
      // System.Console.WriteLine(capacityValuesCopy);

      // Limpa do o 'valuesCopy'
      valuesCopy.Clear();
    }
  }
}