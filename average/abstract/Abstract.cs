// Abstract  ->  Os métodos não tem implementação, somente os cabeçalhos. É criado somente o protótipo que serve como base para as classes derivadas.
// Abstract ->  Classe base para outras classes como um tipo de referência, não permite que os objetos/métodos da sua classe sejam instânciados.

// Veja bem, é possível declarar uma classe abstrata com métodos abstratos ou não abstrados.
// Caso haja métodos não abstratos, ele não precisam ser implementado ao seu conteúdo.
// Agora se os métodos forem abstratos não é implementado o conteúdo somente o protótipo que é herdado da classe abstrata que deve implementar os métodos.

namespace Abstract {

  abstract class Car {
    protected int maxSpeed;
    protected int speed;

    // Constructor
    public Car(int speed, int maxSpeed) {
      this.speed = speed;
      this.maxSpeed = maxSpeed;
    }

    // Abstract
    // Atributos 'abstract' não precisa implementar o conteúdo, somente cria o protótipo.
    // Isto é, esse método é apenas um protótipo que será usando dentro da classe derivada (Ford) que herda a classe base (Car).
    abstract protected void speedUp(int speed) { } // Protótipo na classe base.

    // GET
    public int getSpeed() {
      return speed;
    }
  }

  // Herança
  class Ford : Car {
    public string model;
    public Ford(string model, int speed, int maxSpeed) : base(speed, maxSpeed) {
      this.model = model;
    }

    // Métodos 'abstract' precisam obrigatóriamente ser definidos na classe derivada.
    // Para isso usamos também a diretiva 'override' que indica que o método 'abstract' será sobreescrito pelo método abaixo.
    public override void speedUp(int value, char speedUpOrBrake) { // Implementação de Conteúdo na classe derivada.
      int result;

      switch (speedUpOrBrake) {
        case '-':
          result = value - speed;
          if (result <= 0) {
            return speed = result;
          }
          return result;
          break;
        case '+':
          result = value + speed;
          if (result >= maxSpeed) {
            return speed = result;
          }
          return result;
          break;
        default:
          return speed;
      }
    }
  }


  class Abstract {
    static void Main() {
      // Perceba que aqui é uma instância de 'Ford' e não de 'Car'. 'Car' não pode ser intânciado pois é uma classe 'abstract'.  
      Ford ford = new Ford("Mustang", 0, 320);

      // Chamando o método sobreescrito com 'override' qque teve como protótipo o método 'abstract' da classe base 'Car'.
      ford.speedUp(25, '+');
      ford.speedUp(5, '-');
    }
  }
}