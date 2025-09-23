namespace Recursive {
  public class Calculate {

    // Função recursiva, ou seja, função que chama ela mesma.
    // Usando o cálculo de fatorial para poder visualizar essa funcionaliadade.
    // Isto é, value é igual a 5, enquanto 5 não for menor que um é feita a operação:
    // 5 * 4 / No próprio cálculo é chamada a função novamente passando o 'value' atual menos 1.
    // Isso se repete até que 'value' seja menor que 1.
    public int Factory(int value) {
      int result;

      if (value < 1) {
        result = 1;
      } else {
        result = value * Factory(value - 1);
      }
      return result;
    }
  }

  class Recursive {
    static void Main() {
      Calculate calculate = new Calculate();

      // Chamando a função passando o fatorial de 5 / 5*4*3*2*1
      var result = calculate.Factory(5);

      System.Console.WriteLine(result);
    }
  }
}