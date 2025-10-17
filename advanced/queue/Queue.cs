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
// 'Peek' espiar retorna o elementos mais antigo que está no inicio do 'Queue<T>', mas não remove do 'Queue<T>'.

// O princípio de operação de estrutura de fila é FIFO (First In, First Out) o primeiro elemento inserido é o primeiro a ser removido.

// https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.queue-1?view=net-9.0

using System.Collections.Generic;

namespace QueueExemple {

  class Program {
    static void Main() {
      Queue<string> queue = new Queue<string>();

      // Adiciona elementos ao final da fila.
      queue.Enqueue("one");
      queue.Enqueue("two");
      queue.Enqueue("three");

      // Passando pelos elementos de 'queue'.
      foreach (var value in queue) {
        Console.WriteLine(value);
      }

      Console.WriteLine("\nDequeuing '{0}'", queue.Dequeue());
      Console.WriteLine("Peek at next item to dequeue: {0}", queue.Peek());
      Console.WriteLine("Dequeuing '{0}'", queue.Dequeue());

      // Copiando a 'Queue' á partir da queue já criada.
      Queue<string> queueCopy = new Queue<string>(queue.ToArray());

      // Passando pelos elementos copiados de 'queue' para 'queueCopy'.
      foreach (var valueCopy in queueCopy) {
        Console.WriteLine("Queue of vetor copy: {0}", valueCopy);
      }

      // Verifica se um valor está presente dentro da fila.
      bool hasProps = queueCopy.Contains("one");

      if (hasProps) {
        Console.WriteLine("Encontrado");
      } else {
        Console.WriteLine("Não Encontrado");
      }

      // Pega a quantidade de elementos presentes na fila.
      int currentQueueCopy = queueCopy.Count;
      Console.WriteLine(currentQueueCopy);

      // Verifica qual a capacidade de elementos presentes na fila.
      // int capacityQueueCopy = queueCopy.Capacity;
      // Console.WriteLine(capacityQueueCopy);

      // Limpa do o 'queueCopy'
      queueCopy.Clear();
    }
  }

  // Exemplo de uso de uma queue (fila) genérica em CSharp do namespace .Collections.
  class GenericQueue {
    public static void Main() {
      // Criando uma fila genérica utilizando a classe Queue<T>
      Queue filaGenerica = new Queue();

      // Adicionando elementos na fila genérica
      filaGenerica.Enqueue("Primeiro");
      filaGenerica.Enqueue("Segundo");
      filaGenerica.Enqueue("Terceiro");

      // Exibindo o elemento no início da fila sem removê-lo
      Console.WriteLine("Elemento no início da fila genérica: " + filaGenerica.Peek());

        // Removendo elementos da fila genérica
      Console.WriteLine("Removendo: " + filaGenerica.Dequeue());
      Console.WriteLine("Removendo: " + filaGenerica.Dequeue());

        // Verificando se a fila está vazia
      Console.WriteLine("A fila está vazia? " + (filaGenerica.Count == 0));

      ExibirFila(filaGenerica);
    }

    // Método para percorrer e exibir os elementos da fila sem removê-los.
    public static void ExibirFila(IEnumerable myCollection) { // IEnumerable é uma interface que permite a iteração sobre uma coleção.
      foreach (Object obj in myCollection) { // Percorre cada objeto na coleção.
        Console.WriteLine(" {0}", obj);
      }
    }
  }
}