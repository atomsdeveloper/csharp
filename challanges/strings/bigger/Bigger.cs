// How to return highest occurred character in a string.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Bigger {
  class Program {
    static void Main() {
      List<char> stringListOriginal = new List<char>();
      Dictionary<char, int> totalLettersInString = new Dictionary<char, int>();

      string stringValue = "occurrence";

      foreach (char letter in stringValue) {
        stringListOriginal.Add(letter);
      }

      for (int i = 0; i < stringListOriginal.Count; i++) {
        char letter = stringListOriginal[i];

        if (totalLettersInString.ContainsKey(letter)) {
          totalLettersInString[letter] += 1;
        } else {
          totalLettersInString[letter] = 1;
        }
      }
        
      char letterCurrent = '\0';
      int valueCurrent = 0;

      foreach (KeyValuePair<char, int> KeyValue in totalLettersInString) {
        if (valueCurrent < KeyValue.Value) {
          valueCurrent = KeyValue.Value;
          letterCurrent = KeyValue.Key;
        }
      }
      
      Console.WriteLine("Letter = {0}, Current = {1}", letterCurrent, valueCurrent);
    }
  }
}
