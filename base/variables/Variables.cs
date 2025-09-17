// Uma váriavel é uma posição reservada na memória 'RAM' para armazenar valores e resultados.
// Em C# que é uma líguagem fortemente tipada, se deve passar o tipo que será atribuido a uma váriavel.
// Váriaveis declaradas com 'var' não recebem tipo, mas, ao atribuir um valor à declaração o tipo é automáticamente definido.

// Int -> Inteiros
// Char -> 1byte
// Float -> Ponto Flutuante
// Byte -> 8bytes
// String -> Array de Char
// Bool -> True or False

// TODO: Pesquisar demais tipos.

namespace Variables
{
  class VariablesDotnet
  {
    static void Main()
    {
      int value = 0;
      char letter = 'R';
      float price = 1.5f;
      double sale = 5.50;
      bool result = 10 < 5;

      byte bytes = 08;

      string text = "Lorem ipsum";

      var noType = "String now";

      int age, year, day;
      string name, lastName;

      System.Console.WriteLine(noType);
    }
  }
}