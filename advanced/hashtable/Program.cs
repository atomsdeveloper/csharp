// Hashtable é uma estrutura de dados que pode ser usada de duas maneiras:

// 1. Como uma coleção não genérica (System.Collections.Hashtable).
// 2. Como uma coleção genérica (System.Collections.Generic.Dictionary<TKey, TValue>).

// Recomenda-se usar a versão genérica (Dictionary<TKey, TValue>) devido a vantagens como segurança de tipo, melhor desempenho e suporte a tipos de chave personalizados.

// O principio de funcionamento de uma hashtable é baseado em uma função hash que mapeia chaves a índices em um array, permitindo acesso rápido aos valores associados às chaves. Gereralmente usando polinômios para distribuir uniformemente as chaves. A busnca em Hashtable é O(1) em média, mas pode ser O(n) no pior caso devido a colisões.

// Aplicações comuns de hashtables incluem:

// 1. Para pesquisa rápida de dados.
// 2. Indexando o banco de dados.
// 3. Esconderijos de dados.
// 4. Representação única de dados.

// Exemplo de uso do Dictionary<TKey, TValue> génerico:
using System;
using System.Collections.Generic;

namespace HashtableExample {

  class Program {
    static void Main() {
      // Criando um dicionário genérico (Hashtable) com chaves do tipo string e valores do tipo string.
      Dictionary<string, string> openWith = new Dictionary<string, string> {
        // Adicionando elementos ao dicionário.
        { "txt", "notepad.exe" },
        { "bmp", "mspaint.exe" },
        { "dib", "mspaint.exe" }
      };

      // Usando execessões com o bloco try-catch para tratar erros ao adicionar chaves duplicadas.
      try {
        openWith.Add("txt", "winword.exe");
      } catch (ArgumentException) {
        Console.WriteLine("An element with Key = 'txt' already exists.");
      }

      // Acessando um valor usando sua chave.
      Console.WriteLine("The value for 'txt' is: " + openWith["txt"]);

      // Verificando se uma chave existe no dicionário.
      if (openWith.ContainsKey("dib")) {
        Console.WriteLine("Key 'dib' exists in the hashtable.");
      }
      // Ou
      try {
        Console.WriteLine("The value for 'dib' is: " + openWith["dib"]);
      } catch (KeyNotFoundException) {
        Console.WriteLine("Key 'dib' does not exist in the hashtable.");
      }

      // Pegar um determinado valor usando sua chave.
      string value = "";
      if (openWith.TryGetValue("dib", out value)) { // ''out'' é usado para retornar o valor associado à chave se ela for encontrada.
        Console.WriteLine("Value found: " + value);
      } else {
        Console.WriteLine("Key not found.");
      }

      // Removendo um elemento pelo sua chave.
      openWith.Remove("txt");

      // Iterando sobre os elementos do dicionário.
      foreach (KeyValuePair<string, string> kvp in openWith) {
        Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
      }

      // Obtendo o número de elementos no dicionário.
      Console.WriteLine("Total elements in hashtable: " + openWith.Count);

      // Obtendo somento os valores do dicionário.
      Dictionary<string, string>.ValueCollection values = openWith.Values;

      // Percorrendo os valores capturados.
      foreach (string s in values) {
        Console.WriteLine("Value: {0}", s);
      }

      // O mesmo ocorrerá para as chaves.
      Dictionary<string, string>.KeyCollection keys = openWith.Keys;  

      // Percorrendo as chaves capturadas.
      foreach (string s in keys) {
        Console.WriteLine("Key: {0}", s);
      }
    }
  }
}