// Toda a classe possue um Constructor, onde se este 'constructor' não for passado explícitamente ele é craido automáticamente.
// Para definir um 'constructor' basta criar um método na classe com o mesmo nome da classe. E não podem ser 'static'.
// Este método é executado automáticamente ao instânciar uma classe.

// Podemos definir sobrecarga de construtores, onde os constutores tem o mesmo nome porém recebem argumentos difrentes.

// Em C#, o destructor ou finalizador é um método especial usado para liberar recursos de uma classe antes de o objeto ser destruído pelo Garbage Collector (GC).
// Não pode ter parâmetros nem modificadores de acesso e o compilador decide quando chamá-lo.

namespace Constructor
{
    // Modificadores Abstract, classe que serve como base para outra classe, não permite que seus métodos ou objetos sejam intânciados.
    public class Players
    {
        // Epecifícadores Public, podem ser acessados em nenhum tipo de restrição.
        public string name = "John";
        public bool life = false;
        public int energy = 0;

        // Definindo um 'constuctor' para a classe 'Players'.
        public Players(string name, int energy, bool life)
        {
            this.name = name;
            this.energy = energy;
            this.life = life;
        }

        // Este é um exemplo de sobrecarga de 'construtor'.
        // Onde ele tem o mesmo comportamento do 'construtor' acima, porém só recebe um argumento chamado de 'name'.
        public Players(string name)
        {
            this.name = name;
        }

        // Definindo um 'destrutor' para a classe 'Players'.
        // Antecedido por um '~' e deve ter o mesmo no me da classe.
        ~Players()
        {
            System.Console.WriteLine("Destructor call.");
        }

        // Método para mostrar os valores recebido do contrutores.
        public void Info()
        {
            System.Console.WriteLine("Player: {0} / Life: {1} / Energy: {2}.", name, life, energy);
        }
    }

    // Modificadores Public, sem restrições de acesso ao seus métodos e atributos.
    public class Classes
    {
        // Especifícadores Static, os método podem ser chamados mesmo que não haja a instância de um objeto.
        static void Main()
        {
            // Criando um novo objeto à partir da classse 'Players'. Passando juntamente ao seu constructor os dados necessários.
            // O operador 'new' indica que será craiado um novo endereço de memória para 'player' com todos os atributos da classe.
            // Os params passados para a instância da classe serão armazeandos nas suas respectivas variáveis graças ao 'constuctor'.
            Players player = new Players("Kakashi", 70, true);

            // Chamando o 'constructor' que recebe apenas um param.
            Players players = new Players("Jiraya");

            player.Info();
            players.Info();
        }
    }
}
