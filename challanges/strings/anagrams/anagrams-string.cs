// How to check if two strings are anagrams of each other.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Anagrams {
  class Program {
    static void Main() {
      string firstString = "listen";
      string secondString = "silent";

      // Criando arrays de caracteres a partir das strings.
      char[] firstArray = firstString.ToCharArray();
      char[] secondArray = secondString.ToCharArray();

      // Ordenando os arrays de caracteres.
      Array.Sort(firstArray);
      Array.Sort(secondArray);

      // Convertendo os arrays ordenados de volta para strings.
      string sortedFirstString = new string(firstArray);
      string sortedSecondString = new string(secondArray);

      // Comparando as strings ordenadas para verificar se são anagramas.
      bool areAnagrams = sortedFirstString.Equals(sortedSecondString, StringComparison.OrdinalIgnoreCase);

      if (areAnagrams) {
        Console.WriteLine("The strings are anagrams.");
      } else {
        Console.WriteLine("The strings are not anagrams.");
      }
    }
  }
}