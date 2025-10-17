// How to check if string is palindrome.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Palindrome {
  class Program {
    static void Main() {
      string firstString = "amora";
      string secondString = "aroma";

      // Transformando a string que será checada em um array de caracteres.
      char[] arrayChar = secondString.ToCharArray();

      // Revertendo o array de caracteres.
      Array.Reverse(arrayChar);

      // Após a conversão, devolvo o array de caracteres para string novamente.
      string setStringConvert = new string(arrayChar);

      // Verifica se as duas palavras são exatamente iguais.
      if (setStringConvert == firstString) {
        Console.WriteLine("Is palindrome");
      } else {
        Console.WriteLine("Not is palindrome");
      }
    }
  }
}