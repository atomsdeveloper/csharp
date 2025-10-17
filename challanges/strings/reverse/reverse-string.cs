// How to reverse string in Csharp.

using System;
using System.Collections;
using System.Collections.Generic;

namespace ReverseString {
  
  class Program {
    static void Main() {
      string stringRevert = "Amor";

      var array = stringRevert.ToCharArray(); // Convertendo a string em um array de caracteres.
      Array.Reverse(array); // Revertendo a ordem do arra de caracteres.
     
      Console.WriteLine(new string(array)); // Mostrando o resultado, antes convertendo o array de caracteres para string novamente.
    }
  }
}


