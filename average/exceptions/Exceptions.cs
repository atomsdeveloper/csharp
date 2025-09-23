// Exceções não são erros, ela ocorre em tempo de execução onde o programa roda normalmente, mas ao cair em algum bloco ou coisa do tipo ele quebra.
// Isto é, ocorreu um exceção em determinado local do código.
// Exceções são objetos da classe 'System.Exception' (ou derivadas). Quando algo anormal acontece o .net lança uma exception.
// Isso pode ser capturado e tratado com o 'try/catch'. 

namespace Exception {
 static  class Area {
    public static float Square(float support, float height) {
      if (support == 0 || height == 0) {
        throw new System.Exception("Exceprion generate - support or height cannot be zero.");
      }

      return support * height;
    }
  }

  class Exception {
    static void Main() {
      int result;
      int value = 10;
      int value2 = 5;
      float area;

      try {
        result = value / value2;
        area = Area.Square(10f, 2f);

        System.Console.WriteLine("Result: {0}", result);
        System.Console.WriteLine("Area: {0}", area);
      } catch (System.Exception e) {
        System.Console.WriteLine("Exception: {0}", e.Message);
      } finally {
        System.Console.WriteLine("Sempre é executado, com ou sem exceções.");
      }

      // Gerando uma 'exception' personalizada.
      throw new System.Exception("Exceprion generate.");
    }
  }
}