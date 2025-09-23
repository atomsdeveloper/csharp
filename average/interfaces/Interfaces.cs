// Usamos 'List<T>' quando um número de elementos é dinâmico e não tem tamanho fixo.
// Isso é útil pois já entrga métodos pronto, como, 'Add()', 'Remove()', 'Constains()' e etc.
// Este tipo de declaração é mais pesada que o 'vetor' que é de baixo nível próximo do funcionamento de memória. 

// Interfaces são modelos/contratos com métodos/propriedades/eventos que deve ser implementados obrigatóriamente ao serem base de uma classe.
// Podem retorna valores ou não, assim como também podem receber 'params', mas somente seu protótipo deve estar na 'interface'.
// A classe que deve realizar as operações e lógica do meétodo.

using System.Collections.Generic; // Importando o namespace que possue a classe 'List<T>'.

namespace Interfaces {

  public interface Directon {
    void speedUp(int speed);
    void breake(int speed);
  }

  public interface Armament {
    void Guns(string gun);
  }

  class Car : Directon {
    public string type;
    public int speed;
    public int maxSpeed;

    // Constructor
    public Car(string type, int speed, int maxSpeed) {
      this.type = type;
      this.speed = speed;
      this.maxSpeed = maxSpeed;
    }

    public void speedUp(int speed) {
      if (!(this.speed >= maxSpeed)) {
        this.speed += speed;
      }
    }

    public void breake(int speed) {
      if (!(this.speed <= 0)) {
        this.speed -= speed;
      }
    }
  }

  class Tank : Directon, Armament {
    public string type;
    public List<string> guns; // Listas podem ter seu tamanho alterado enquanto 'vetor' tem tamanho fixo.
    public int speed;
    public int maxSpeed;

    public Tank(string type, string[] guns, int speed, int maxSpeed) {
      this.type = type;
      this.guns = new List<string>(guns); // Converte o 'vetor' recebido no constructor para uma 'list'.
      this.speed = speed;
      this.maxSpeed = maxSpeed;
    }

    public void Guns(string gun) {
      this.guns.Add(gun); // Adiciona o valor a lista de strings.
    }

    public void speedUp(int speed) {
      if (!(this.speed >= maxSpeed)) {
        this.speed += speed;
      }
    }

    public void breake(int speed) {
      if (!(this.speed <= 0)) {
        this.speed -= speed;
      }
    }
  }

  class Dealer {
    static void Main() {
      // Car
      Car car = new Car("Mustang", 120, 280);

      System.Console.WriteLine("\n CAR \n");
      System.Console.WriteLine("{0} \n {1} \n {2} \n", car.type, car.speed, car.maxSpeed);

      // Tank
      string[] guns = new string[] { "Fuzil", "Canhão" }; // Criando um vetor de strings para ser passado para o constructor da classe 'Tank'.
      Tank tank = new Tank("Chinês", guns, 40, 120);

      tank.Guns("Uzi");

      System.Console.WriteLine("\n TANK \n");
      // Percorrendo todo o'vetor' para ser possível visualizar os dados presentes em 'guns'.
      foreach (var item in tank.guns) {
        System.Console.WriteLine(item);
      }
      System.Console.WriteLine("{0} \n {1} \n {2} \n", tank.type, tank.speed, tank.maxSpeed);
    }
  }


}