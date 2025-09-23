
namespace Delegate {
  // Delegate é um tipo que representa uma referência para um método.
  // Ou seja, ele serve como ponteiro para um método.
  delegate int Operation(int valueOne, int valueTwo);

  class Math {
    // Note que os métodos a serem delegados apontam para um 'ref' na memória.
    public static int Sum(int valueOne, int valueTwo) {
      return valueOne + valueTwo;
    }

    public static int Mult(int valueOne, int valueTwo) {
      return valueOne * valueTwo;
    }
  }

  class Delegate {
    static void Main() {
      int result;

      // Passando o método como 'param' para apontar qual método será usando na operação.
      Operation operation = new Operation(Math.Sum);

      result = operation(10, 10);

      System.Console.WriteLine(result);

      operation = new Operation(Math.Mult);

      result = operation(10, 5);
      System.Console.WriteLine(result);
    }
  }
}