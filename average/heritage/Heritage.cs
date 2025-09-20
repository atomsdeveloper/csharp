// Em herança tudo ocorre nos construtores, ou seja, sempre que determinado atributo herdado precisar receber um valor, estes dados sempre serão passado pelo 'constructor'.
// Até chagar na sua classe de destino, classe está que declarou e inicializou/ou não um determinado atribuito.
// Vehicle -> Car -> CarCombat / Estas são as classes que são heradas na sequência inserida.
// Cada classe tem seu próprio atributo e também cada uma deve passar valores para sua classe de herança.

namespace Heritage {
  class Vehicle {
    // Atributos privados só podem ser acessado pela própria classe ou por meio de métodos 'public'.
    private int wheels;
    private string engine;
    private bool cnh;

    // Construtor da classe.
    public Vehicle(int wheels, string engine, bool cnh) {
      this.wheels = wheels;
      this.engine = engine;
      this.cnh = cnh;
    }

    // Métodos GET para pegar os valores da classe.
    public int getWheels() {
      return wheels;
    }

    public string getEngine() {
      return engine;
    }

    public bool getCnh() {
      return cnh;
    }

    // Métodos SET para alterar os valores da classe.
    public int setWheels(int wheels) {
      if (wheels <= 0 | wheels > 8) {
        return this.wheels = 4;
      }
      return this.wheels = wheels;
    }
  }

  // Herança deve possuir uma classe base e uma classe derivada.
  // A classe base neste caso é 'Vehicle' e a classe derivada 'Car'.
  class Car : Vehicle {
    public string type;
    public string color;

    // Para receber valores da instância da classe 'Car' e passar para o 'constructor' da classe base.
    // Deve ser recebido todos os valores dentro do 'constructor' de 'Car' e no método construtor (abaixo) usa-se a diretiva 'base'.
    // Essa diretiva 'base' indica quais são os método recebidos no constructor de 'Car' que deverão ser passados para o 'constructor' da classe base 'Vehicle'.
    public Car(int wheels, string engine, bool cnh, string type, string color) : base(wheels, engine, cnh) {
      this.type = type;
      this.color = color;
    }
  }

  // Herança deve possuir uma classe base e uma classe derivada.
  // A classe base neste caso é 'Car' e a classe derivada 'CarCombat'.
  class CarCombat : Car {
    public int ammunition;

    // Deve ser recebido todos os valores dentro do 'constructor' de 'CarCombat' e no método construtor (abaixo) usa-se a diretiva 'base'.
    // Essa diretiva 'base' indica quais são os método recebidos no constructor de 'Car' que deverão ser passados para o 'constructor' da classe base 'CarCombat'.
    public CarCombat(int wheels, string engine, bool cnh, string type, string color, int ammunition) : base(wheels, engine, cnh, type, color) {
      setWheels(8);
      this.ammunition = ammunition;
    }
  }

  // Isto é. Heritage cria um objeto da intância de Car que por sua vez herda de Vehicle.
  // Vehicle -> Car -> CarCombat é instânciado em Heritage.
  // Vehicle -> Car -> é instânciado em Heritage.

  class Heritage {
    static void Main() {
      // Instância da classe 'Car' realizada dentro da classe 'Heritage'.
      Car car = new Car(4, "V8", true, "Sedan", "Preto");

      // Dados da classe 'Vehicle'.
      int wheels = car.getWheels();
      string engine = car.getEngine();
      bool cnh = car.getCnh();
      string cnhString = cnh ? "Approved" : "Suspended";

      // Dados da classe 'Car'.
      string type = car.type;
      string color = car.color;

      System.Console.WriteLine("Total de rodas {0} com motor {1} e cnh {2}, a cor é {3} no modelo {4}. ", wheels, engine, cnhString, color, type);

      // Instância da classe 'CarCombat' realizada dentro da classe 'Heritage'.
      CarCombat carCombat = new CarCombat(4, "V8", true, "Tanque de Guerra", "Camufaldo", 100);

      // Dados da classe 'Vehicle'.
      int wheelsCombar = carCombat.getWheels();
      string engineCombat = carCombat.getEngine();
      bool cnhCombat = carCombat.getCnh();
      string cnhStringCombat = cnhCombat ? "Approved" : "Suspended";

      // Dados da classe 'Car'.
      string typeCombat = carCombat.type;
      string colorCombat = carCombat.color;

      // Dados da classe 'CarCombat'.
      int ammunition = carCombat.ammunition;

      System.Console.WriteLine("Total de rodas {0} com motor {1} e cnh {2}, a cor é {3} no modelo {4} com total de {5} munições. ", wheelsCombar, engineCombat, cnhStringCombat, colorCombat, typeCombat, ammunition);
    }
  }
}