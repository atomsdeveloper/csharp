// Static   ->  Classe que não permite a instância de seus objetos e seus membros devem ser 'static'.

// Modificadores de Classes definem a visibilidade da classe.
// Este tipo de classe não permite o uso de construtores uma vez que não permite a instância de objetos.
// Isto é, classes 'static' usam uma posição fixa na memória, então não é possível acessar a directiva 'new' que cria um novo endereço de memória.
// Podemos acessar os métodos/membros de uma classe 'static' sem ter que instânciar um objeto. Uso: "ClassName.Method".
// Uma classe 'static' deve conter todos os membros como 'static'. (uma classe que não é 'static' pode ter membros que são 'static').

namespace Static {
  
   public class Enemy {
    // Definido o atributo como 'static'.
    // Isto é, caso seja necessário alterar o valor de 'active' de todos os objetos instânciados á partir dessa classe.
    static bool active = false;
    public string name = "Madara";

    public Enemy(string name)
    {
      this.name = name;
    }

    public void Info()
    {
      System.Console.WriteLine("Enemy: {0} / Active: {1}.", name, active);
    }
  }

  // Modificadores Static, classe que não permite a instância de seus objetos e seus membros devem ser 'static'.
  static class Players {
    static string name = "Renan";
    static bool life = false;

    // Não pode ter 'constructor' então usamos métodos.
    static void Init(string nameParam, bool lifeParam) {
      this.name = nameParam;
      this.life = lifeParam;
    }

    static void Info() {
      System.Console.WriteLine("Player: {0} / Life: {1}.", name, life);
    }

    static void Main() {
      Players.Info(); // Acessando método de uma classe estática.
      Players.Init("Jiraya", false);
      // Note que isso altera os valores da classe 'Players', pois estamos acessando diretamente o objeto.
      // Diferentemente de instâncias de classes que altera os valores somente na instância.
      Players.Info();

      // Instâncias da classe 'Enemy'.
      Enemy enemy = new Enemy("Obito");
      enemy.Info();

      Enemy enemys = new Enemy("Aldeia da Chuva");
      enemys.Info();

      // Como 'active' é 'static' eu posso acessá-lo à partir da classe e não da instância.
      // Isso faz com que o valor de 'active' seja alterando em todos os objetos que intânciam a classe "Enemy'.
      // Mesmo seguimento da classe 'static' 'Players' onde tudo é estático, sendo assim ão tem instância, somente atributos/métodos de classe.
      Enemy.active = true;

      Enemy.Info();
    }
  }
}
