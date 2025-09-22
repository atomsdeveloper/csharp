// Virtual   ->  O método pode ser redefinido em uma classe derivada.

// Métodos ou atributos virtuais nada mais é do que uma indicação de que o método ou atributo podem ser reescritos por uma classe derivada.

namespace Virtual {
  class Person {
    // Ao declarar um atributo ou método 'virtual' define-se que este método ou atributo pode ser reescrito.
    public virtual void Info() {
      System.Console.WriteLine("Info base class");
    }
  }

  // Herança / Children herda de Person. 
  class Children : Person {
    // Sobreescrevendo o método 'Info' passando a diretiva 'override' que indica que é uma reescrita do método já existem na classe base.

    public override void Info() {
      // Chama primeiro a versão da classe base, por isso a diretiva 'base'  juntamente com o método 'virtual' que neste caso é 'Info'.

      System.Console.WriteLine("Info base class rewritten");
    }
  }
  
  class Virtual {
    static void Main() {
      Children children = new Children();
      // Neste caso como é feita a sobreescrita o valor de saída de 'Info' é 'Info base class rewrittene'.
      // Método virtuais são realizados em tempo de execução, ou seja, tudo já é sobreescrito ao rodar o programa.
      // 
      children.Info();

      // É possível também passar a classe como referência para a chamada do método ou atributo desejado. 
      // Neste caso a Ref indica o objeto 'Person' como um mode de "tipagem" e "indentificação".
      // Isto é, estou usando o método 'Info' que está presente em 'Children', porém ele é do 'tipo' 'Person' tem o mesmo método.
      // Porém este método foi sobreescrito em tempo de execução por 'override' na própria 'Children'.
      Person personRef = new Children();
      personRef.Info(); // Saída será: 'Info base class rewritten' 
    }
  }
}