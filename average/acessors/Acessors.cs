// Acessors são um tipo de atributos que se baseam no meétodos GET e SET.
// Note que este atributo no SET não possue retorno assim como os métodos.
// Então para usa-los devemos atribuir um novo valor ao atributo existente.
// Veja o atributo 'GetSet' para entender na prática.

namespace Acessors {
  public class Person {
    public string name;
    public int age;

    public bool ageLegal;

    // Constructor
    public Person(string name, int age) {
      this.name = name;
      this.age = age;
    }

    public int GetSet {
      // Read
      get {
        return age;
      }

      // Write
      set {
        if (value <= 18 || value >= 120) {
          ageLegal = false;
        }

        ageLegal = true;
      }
    }
  }

  class Acessor {
    static void Main() {
      Person person = new Person("Renan", 25);

      // Passando valor cai no SET
      person.GetSet = 25;

      //                                                                   Sem passar valor cai no GET
      System.Console.WriteLine("{0}\n {1}\n {2}\n", person.name, person.ageLegal, person.GetSet);
    }
  }
}