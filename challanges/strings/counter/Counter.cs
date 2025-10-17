// How to count number of words in a string.

using System;

namespace Counter {
  class Program {
    static void Main() {
      string phrase = "This is test phrase";

      // Remove os espaços do ínicio e do fim da string se houver.
      string phraseWithoutSpaceStartAndEnd = phrase.Trim();

      // Seperando todas as palavras da string pelo espaço e armazenando em um array de strings.
      string[] words = phraseWithoutSpaceStartAndEnd.Split(' ');

      int numberOfWords = words.Length; // Checa a quantidade de elementos dentro do array

      Console.WriteLine(numberOfWords);
    }
  }
}