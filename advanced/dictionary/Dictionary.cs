// Dictionary representa uma coleção de chaves e valores.
// public class Dictionary<TKey,TValue> : 
// Onde 'TKey' representa o tipo da chave e 'TValue' representa o tipo do valor. 
using System.Collections.Generic;

namespace Dictionary {
  class Dictionary {
    static void Main() {
      Dictionary<int, string> dictionary = new Dictionary<int, string>();

      // Forma de adicionar elementos na dicionário.
      dictionary.Add(0, "Renan");
      dictionary.Add(1, "Ruth");
      dictionary.Add(2, "Joyce");

      System.Console.WriteLine("O elemento na posição 0 é: {0}", dictionary[0]);

      try {
        dictionary.Add(3, "Jeyse");
      } catch (System.Exception e) {
        System.Console.WriteLine("Exception: {0}", e.Message);
      }

      // Forma de percorrer os valores com as chaves do dicionário.
      foreach (KeyValorPair<int, string> KeyValue in dictionary) {
        System.Console.WriteLine("Key = {0}, Value = {1}", KeyValue.Key, KeyValue.Value);
      }

      // Forma de percorrer somente os valores do dicionário.
      // Primeiro é preciso criar um 'Dictionary' com seus respectivos tipos.
      // E desse dicionário criado será retornado somente a 'ValueCollection' que retorna todos os valores da coleção.
      // Esse valores são armazenados em 'valuesCollection' variável, e para receber os valores é informado de onde elese serão recebidos, com 'dictionary.Values'.
      Dictionary<int, string>.ValueCollection valuesCollection = dictionary.Values;

      // Para percorrer somente os valores agora usa-se o 'valuesCollection'.
      foreach (string value in valuesCollection) {
        System.Console.WriteLine("Value = {0}", value);
      }

      // O mesmo ocorre para percorrer somente as chaves do objeto.
      // Trocando o método para 'KeyCollection'.
      // e também alterar para key em 'dictionary.Keys'.
      Dictionary<int, string>.KeyCollection keysCollection = dictionary.Keys;

      // Para percorrer somente os valores agora usa-se o 'valuesCollection'.
      foreach (string key in keysCollection) {
        System.Console.WriteLine("Key = {0}", key);
      }

      // Remover um valor da coleção passando a chave.
      dictionary.Remove(3);

      // Checar se o dicionario tem uma chave respectiva.
      int hasKeyInDictionary = dictionary.ContainsKey(2);
      if (!hasKeyInDictionary) {
        System.Console.WriteLine("Not exists key");
      }

      // Checar se o dicionario tem um valor respectivo.
      string hasValueInDictionary = dictionary.ContainsValue("Renan");
      if (!hasValueInDictionary) {
        System.Console.WriteLine("Not exists value");
      }

      // Limpar a todo o dicionário.
      dictionary.Clear();
    }
  }
}