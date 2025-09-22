// Sealed  ->  Classes que não pode ser herdadas.
// Sealed  ->  Os métodos não pode ser redefinidos.

namespace Sealed {

  // Esta diretiva 'sealed' indica que está classe não pode ser herdada.
  sealed class NotHeritage {
    public string name;

    // Constructor.
    public NotHeritage(string name) {
      this.name = name;
    }

    // GET
    public string getName() {
      return name;
    }

    // SET
    public string setName(string name) {
      return this.name = name;
    }
  }

  // Testando a herança de uma classe 'sealed'.
  class Person : NotHeritage {

    // Constructor
    // Tentando acessar um atributo herdado de uma classe que não permite herança.
    public Person() {
      // name -> Atributo não pode ser acessado.
    }
  }
  
  class Sealed {
    static void Main() {
      // Note que é possível criar uma instãncia de um classe 'sealed' porém não é possível herda-lá.
      NotHeritage notHeritage = new NotHeritage();

      // Note também que é pssível acessar os método e atributos da classe 'sealed'. 
      notHeritage.getName();
      notHeritage.name;
    }
  }
}