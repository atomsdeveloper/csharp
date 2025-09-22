// Protected ->  Podem ser acessados na própria classe e nas classes que são derivadas.
// Aqui vamos usar tudo que já aprendemos anteriormente, somente com o detalhe de que temos um atributo 'protected'.

// A ordem de execução dos 'constructors' sempre começã da Base até a Derivada.
// Ou seja, usando as heranças abaixo como exemplo, ficaria: 
// Vehicle constructor  ->  Car constructor.
//    Base Class             Derivate Class

namespace Protected {

  class Vehicle {
    public int maxSpeed;
    private int speed;
    protected bool on; // Atributo protegido onde só pode ser acessado pela própria classe ou classes que tem como herança está classe.

    // O constructor dessa classe exige um parâmetro que deve ser passado na sua instância ou herença.
    public Vehicle(int maxSpeed, int currentSpeed) {
      this.maxSpeed = maxSpeed;
      this.speed = currentSpeed;
      this.on = false;
    }

    // GET
    public int getMaxSpeed() {
      return maxSpeed;
    }

    public int getSpeed() {
      return speed;
    }

    public bool getOn() { // Possível criar métodos GET e SET para atributos 'protected'
      return on;
    }

    // SET
    public bool setOn(bool value) {
      return on = value;
    }
  }

  class Car : Vehicle {
    public string name;

    // Recebendo todos os params que foram passados no 'contructor' da instância dessa classe que é classe derivada.
    // Onde os valores que essa classe deve ler é somente o 'name'.
    // Os demais valores são passado para o 'constructor' da classe base.
    public Car(int maxSpeed, int currentSpeed, string name) : base(maxSpeed, currentSpeed) {
      this.name = name;

      // Para explicar a diferença de 'protected'.
      // Atributos protegioos podem ser acessado somente das classes derivadas de onde o atributo 'protected' foi definido.
      on = true;
    }

  }

  class Protected {
    static void Main() {
      Car car = new Car(220, 120, "Mustang");

      // Só é possivel acessar este dois atributos à partir da instância.
      // São os atributos 'public'
      int speed = car.maxSpeed;
      string name = car.name;

      // Para acessar valores 'private'.
      // Deve ser gerado métodos GET e SET para leitura e modificação desses atributos.
      car.getMaxSpeed();

      car.setOn(true); // Método que altera um atributo 'protected', que teóricamente só pode ser acessado à partir de uma classe derivada. 
    }
  }
}