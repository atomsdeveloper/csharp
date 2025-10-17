// Existem duas formas de criar uma pilha em CSharp:
// 1. Utilizando a classe Stack do namespace System.Collections
// 2. Utilizando a classe Stack<T> do namespace System.Collections.Generic

// O princípio de operação de estrutura de pilha é LIFO (Last In, First Out) o último elemento inserido é o primeiro a ser removido.

// As aplicações comuns de pilhas incluem:
// 1. Desfazer/Refazer operações.
// 2. Inversão de strings.
// 3. Empilhar para frente/trás em navegadores web.
// 4. Algoritmos de backtracking.
// 5. Verificação de correspondência de parênteses.

using System;
using System.Collections;
using System.Collections.Generic;

// Exemplo de uso de uma stack (pilha) em CSharp simples do namespace System.Collections.
public class SimpleStack {
  public static void Main() {
    // Criando uma pilha utilizando a classe Stack
    Stack pilha = new Stack();

    // Adicionando elementos na pilha
    pilha.Push("Primeiro");
    pilha.Push("Segundo");
    pilha.Push("Terceiro");

    // Exibindo o elemento no topo da pilha sem removê-lo
    Console.WriteLine("Elemento no topo da pilha: " + pilha.Peek());

    // Removendo elementos da pilha
    Console.WriteLine("Removendo: " + pilha.Pop());
    Console.WriteLine("Removendo: " + pilha.Pop());

    // Exibindo o elemento no topo da pilha após remoções
    Console.WriteLine("Elemento no topo da pilha após remoções: " + pilha.Peek());

    // Verificando se a pilha está vazia
    Console.WriteLine("A pilha está vazia? " + (pilha.Count == 0));

    ExibirPilha(pilha); // Chamando o método para exibir os elementos da pilha.
  }

  // Método para percorrer e exibir os elementos da pilha sem removê-los.
  public static void ExibirPilha(IEnumerable myCollection) { // IEnumerable é uma interface que permite a iteração sobre uma coleção.
    foreach (Object obj in myCollection) { // Percorre cada objeto na coleção.
      Console.WriteLine(" {0}", obj);
    }
  }
}

// Exemplo de uso de uma stack (pilha) genérica em CSharp do namespace System.Collections.Generic.
class GenericStack {
  public static void Main() {
    // Criando uma pilha genérica utilizando a classe Stack<T>
    Stack<string> pilhaGenerica = new Stack<string>();

    // Adicionando elementos na pilha genérica
    pilhaGenerica.Push("Primeiro");
    pilhaGenerica.Push("Segundo");
    pilhaGenerica.Push("Terceiro");

    // Exibindo o elemento no topo da pilha sem removê-lo
    Console.WriteLine("Elemento no topo da pilha genérica: " + pilhaGenerica.Peek());

    // Verificando se a pilha está vazia
    Console.WriteLine("A pilha genérica está vazia? " + (pilhaGenerica.Count == 0));

    foreach (string item in pilhaGenerica) {
      Console.WriteLine("Item na pilha genérica: " + item);
    }

    Console.WriteLine("\nPopping '{0}'", pilhaGenerica.Pop());
    Console.WriteLine("Peek at next item to destack: {0}", pilhaGenerica.Peek());
    Console.WriteLine("Popping '{0}'", pilhaGenerica.Pop());
  }
}