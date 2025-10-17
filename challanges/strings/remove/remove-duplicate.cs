// How to remove duplicate caracters in a string.

using System;
using System.Collections;
using System.Collections.Generic;

namespace RemoveDuplicate {
  class Program {
    static void Main() {
      List<char> listCharOriginal = new List<char>();
      List<char> listCharConverted = new List<char>();

      string stringValue = "occurred";

      // Passando por cada caracter da string e adicionando em uma lista de caracteres.
      foreach (char letter in stringValue) {
        listCharOriginal.Add(letter);
      }

      // Após adicioanar todas as letras da string em uma lista é percorrido cada letra.
      for (int i = 0; i < listCharOriginal.Count; i++) {
        char letter = listCharOriginal[i];

        // Verifica se a outra lista que vai receber somente as letras sem duplica-las está vazia, se estiver adiciona a letra sem checar se existe pois é a primeira letra.
        if (listCharConverted.Count == 0) {
          listCharConverted.Add(letter);
        }

        // Caso já tenha uma ou mais letras adicionadas na lista de caracters sem duplicidade é percorrido a mesma.
        for (int y = 0; y < listCharConverted.Count; y++) {
          // Passando por todas as letras dentro do array sem duplicidade para verifica se contem a letra atual da lista original. Caso não estiver adiciona.
          if (!listCharConverted.Contains(letter)) {
            listCharConverted.Add(letter);
          }
        }

      }
      // Após todas as verificações é convertido a lista de caracteres para string novamente.
      string stringValueConverted = new string(listCharConverted.ToArray());

      Console.WriteLine(stringValueConverted);
    }
  }
}