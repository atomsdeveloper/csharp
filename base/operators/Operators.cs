class Operators
{
  static void Main()
  {
    System.Console.WriteLine("Operators...");

    // Aritiméticos
    int sum = 10 + 10; // 20
    int sub = 10 - 10; // 0
    int div = 10 / 10; // 1
    int mult = 10 * 10; // 100
    float res = 10 % 10; // 0

    // Atribuição
    string saveValue = "O valor de '=' atribui este texto ao valor 'sum' ";

    // Relacionais
    bool bigger = 10 > 2; // true
    bool smaller = 5 < 7; // true
    bool smallEqual = 4 <= 4.5; // false
    bool bigEqual = 2 >= 2; // true
    bool diff = 2 != 3; // true
    bool extEqual = 'R' == 'r'; // false

    // Lógicos
    bool twoIsTrue = bigger && smaller; // true -> AND
    bool onlyOneTrue = smallEqual || bigEqual; // true -> OR

    // Incremento
    int value = 10;
    value++;
    value += 1;
    //                   } Estes podem ser usados com outros operadores aritiméticos.       
    // Decremento
    int valueTwo = 20;
    value++;
    value += 1;
  }
}