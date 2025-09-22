
namespace Interfaces {

  public interface Directon {
    void speedUp();
    void breake();
  }

  public interface Armament {
    void Guns();
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
    public string[] guns;
    public int speed;
    public int maxSpeed;

    public Tank(string type, string[] guns, int speed, int maxSpeed) {
      this.type = type;
      this.guns = guns;
      this.speed = speed;
      this.maxSpeed = maxSpeed;
    }

    public void Guns() {
      this.guns;
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
      Car car = new Car("Mustang", 120, 280);
      System.Console.WriteLine("\n{0} \n {1} \n", car.type, car.speed);

      // Tank tank = new Tank("Chinês", ["Ak47", "Míssel", "Canhão"], 40, 120);
      // System.Console.WriteLine("\n{0} \n {1} \n", tank.guns, car.type);
    }
  }


}