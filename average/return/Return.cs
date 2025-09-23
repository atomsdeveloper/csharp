// Método para retornar um objeto.
// Herança modela uma relação 'é-um'. Associação modela uma relação 'tem-um' ou 'gera-um'.

namespace Return {
  // Classe normal, oned já usamos estes atributos e métodos em arquivos anteriores.
  // Onde a classe possue atributos e um constructor.
  public class Egg {
    public int currentEggs;
    public string nameChicken;

    public Egg(string name, int eggs) {
      this.currentEggs = eggs;
      this.nameChicken = name;

      System.Console.WriteLine("Eggs {0} to chiken {1}", this.currentEggs, this.nameChicken);
    }

  }

  class Chiken {
    // Classe normal, oned já usamos estes atributos e métodos em arquivos anteriores.
    // Onde a classe possue atributos e um constructor.
    private string nameChiken;
    private int currentEggs;

    public Chiken(string namechicken) {
      this.nameChiken = namechicken;
      this.currentEggs = 0;
    }

    // Aqui é feito o retorno do objeto.
    // Para assinar que este é um método vai um objeto é necessário indicar o tipo de retorno que neste caso é do tipo 'Egg'.
    // Sendo assim é possível retornar do método uma nova instância/objeto de 'Egg'.
    // Isso é uma relação de composição/associação. Apenas produz um 'Egg'. 
    public Egg LayEggs() {
      this.currentEggs++;
      return new Egg(nameChiken, currentEggs); // Retornando um novo objeto á partir da classe 'Eggs' passados os respectivos valores de seu constructor.
    }

  }

  class Return {
    static void Main() {
      Chiken chikenOne = new Chiken("Angola");
      Chiken chikenTwo = new Chiken("Caipira");

      chikenOne.LayEggs();

      chikenTwo.LayEggs();
      chikenTwo.LayEggs();
    }
  }
}