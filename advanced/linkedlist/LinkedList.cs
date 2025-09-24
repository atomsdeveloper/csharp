// Representa uma lista duplamente vinculada de uso geral.
// Ela dá suporte a Enumeradores e implementa a interface 'ICollection'.
// Fornece nós separados do tipo 'LinkedListNode<T>', isso é, inserções e remoções são operações O(1).
// Cada nó no objeto 'LinkedList<T>' é do tipo 'LinkedListNode<T>'. 
// Como o LinkedList<T> está duplamente vinculado, cada nó aponta para frente para o nó 'Next' e para trás para o nó 'Previous'.
// Você pode remover nós e reinseri-los, na mesma lista ou em outra lista, o que não resulta em nenhum objeto adicional alocado no heap. 
// Como a lista também mantém uma contagem interna, obter a propriedade Count é uma operação O(1).

using System.Text;
using System.Collections.Generic;

namespace LinkedList {

  class LinkedList {
    static void Main() {
      // criando um 'vetor' de 'string' já inicializado.
      string[] words = { "the", "fox", "the", "over", "dog" };

      LinkedList<string> linked = new LinkedList<string>(words);
      Display(linked, "Init list:");

      // Adiciona um elemento ao inicio da lista.
      linked.AddFirst("today");
      Display(linked, "Add 'today' to beginning list:");

      // Move o elemento na primeito posição para a última posição.
      LinkedListNode<string> firstElement = linked.First; // Armazena o valor do primeiro elemento.
      linked.RemoveFirst(); // Remove o primeiro elementos da lista.
      linked.AddLast(firstElement); // Adiciona o valor armazenado do primeiro elemento ao final da lista.

      // Removendo u último elemento.
      linked.RemoveLast();
      linked.AddLast("yesterday");

      // Adicionando o último elemtento no inicio da lista.
      LinkedListNode<string> lastElement = linked.Last;
      linked.RemoveLast();
      linked.AddFirst(lastElement);

      // Indica o index do último elemento encontrado.
      LinkedListNode<string> current = linked.FindLast("the");
      System.Console.WriteLine(current);

      // Adicionar elementos depois de outro elemento ser adicionado.
      linked.AddAfter(current, "old");
      Display(linked, "Add 'old' after 'the': ");

      // Pegar o index do primeiro elemento encontrado.s
      current = linked.Find("fox");

      // Adicionar elementos antes de outro elemento ser adicionado.
      linked.AddBefore(current, "quick");

      // Copiando uma LinkedList para um 'vetor' de strings.
      string[] vetor = new string[linked.Count];
      linked.CopyTo(vetor, 0);

      // Passando pelos items copiados do 'vetor' vindos de 'linked'.
      foreach (string item in vetor) {
        System.Console.WriteLine(item);
      }

      // Limpar toda a LinkedList
      linked.Clear();
    }

    static void Display(LinkedList<string> list, string msg) {
      System.Console.WriteLine(msg);

      foreach (string item in list) {
        System.Console.Write(item + " ");
      }

      System.Console.WriteLine("\n");
    }
  }
}