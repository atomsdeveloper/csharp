// How to print duplicate characters in a string.

using System;
using System.Collections;
using System.Collections.Generic;

namespace DuplicateChar {
  class Program {
    static void Main() {
      // Criando um lista do tipo 'char' que acita somete um bit em forma de string ('1', 'e' ...).
      List<char> listChar = new List<char>();

      string checkCharDuplicated = "occurred";
      bool hasCharDuplicated = true;

      // Passado por todas as letras da string e adicionando cada uma dessas letras em seus respectivos 'index' dentro da 'listChar'.
      foreach (char letter in checkCharDuplicated) {
        listChar.Add(letter);
      }

      for (var i = 0; i < listChar.Count; i++) {
        char letterSearch = listChar[i];
        listChar.Remove(letterSearch);

        if (listChar.Contains(letterSearch)) {
          Console.WriteLine("The string constains characters duplicates: {0}", letterSearch);
          hasCharDuplicated = false;
        };
      }
      
      if(hasCharDuplicated) {
        Console.WriteLine("The string not has constains characters duplicates");
      }
    }
  }
}