// List -> Representa um lista fortemente tipada de objetos que podem ser acessados pelo 'index'.
// Ela fornece meétodos para pesquisar, classificar e manipular listas.
// Neste caso é craida uma variável 'list' que tem seu tipo como uma lista de string com 'List<string>'.
// 'List<T>' é uma classe do 'System' que pode ser instânciada, onde eu crio uma nova lista à partir dessa classe.
// Cada nó conhece apenas o próximo (Next). Navegação é apenas para frente. Para remover o último item, precisa percorrer a lista inteira (O(n)).

// Constructor
// Pode não receber argumentos como na forma que estamos usando. new List<string>()
// Tem argumentos do tipo 'List' que serão copiados pra coleção e tem capacidade para armazenar o número de elementos fornecidos na coleção. new List<string>(list)
// Determina o a capacidade incical da lista especificada no argumento. new List<string>(Int32).

using System.Collections.Generic;

namespace List {

  class List {
    static void Main() {
      List<string> list = new List<string>();

      // Adicionando valores a lista.
      list.Add("Renan");

      // Propriedades
      int total = list.Capacity; // Obtém ou define o número de elementos que a estrutura de dados pode conter/sem redimensionar. define list.Capacity = Int32
      int listLenght = list.Count; // Obtém o número de elementos contidos no 'list'.
      int itemList = list.Item[0]; // Obtém ou define o elemento no índice especificado. define -> list.Item[0] = "John"

      // Métodos
      list.Add("Geyse"); // Adiciona
      list.Add("Renan"); // Adiciona elemento na lista.
      list.Contains("Renan"); // Verifica se existe o elemento na lista.

      List<string> otherListCopyFrom = CopyTo(list); // Copia todos os elementos.

      otherListCopyFrom.Find("Renan"); // Pesquisa o elemento e retorna o primeiro encontrado.
      otherListCopyFrom.GetType(); // Retorna o Type da instância.
      otherListCopyFrom.IndexOf("Geyse"); // Retorna o Index do elemento encontrado.
      otherListCopyFrom.Insert(3, "Joyce"); // Insere um elemento na lista passando a posição de Index.
      otherListCopyFrom.Remove(); // Remove o primeiro elemento da lista.
      otherListCopyFrom.Sort(); // Classifica os elementos usando comparador padrão.
      otherListCopyFrom.Reverse(); // Inverte a ordem dos elementos em toda a lista.


      // Percorrendo cada intem da lista.
      foreach (string item in list) {
        System.Console.WriteLine(item);
      }


      // Métodos (coloquei por no fim do programa para não apgar os dados inseridos).
      list.Clear(); // Apaga tudo.
    }
  }
}