// Modificadores de Classes definem a visibilidade da classe.

// Public   ->  Sem restrições de acesso, pode ser acessada de qualquer outra classe ou objeto.
// Abstract ->  Classe base para outras classes, não permite que os objetos/métodos da sua classe sejam instânciados.
// Sealed   ->  Classes que não pode ser herdadas.
// Static   ->  Classe que não permite a instância de seus objetos e seus membros devem ser 'static'.

// Especifícadores de Acesso é onde um atributo/método da classe pode ser acessado.

// Public    ->  Não tem restrições de acesso.
// Private   ->  só podem ser acessados pela própria classe.
// Protected ->  Podem ser acessados na própria classe e nas classes que são derivadas.
// Abstract  ->  Os métodos não tem implementação somente os cabeçalhos.
// Sealed    ->  Os métodos não pode ser redefinidos.
// Virtual   ->  O método pode ser redefinido em uma classe derivada.
// Static    ->  O método pode ser chamado mesmo sem a instância de um objeto.

namespace Objects
{
    // Modificadores Abstract, classe que serve como base para outra classe, não permite que seus métodos ou objetos sejam intânciados.
    public class Players
    {
        // Epecifícadores Public, podem ser acessados em nenhum tipo de restrição.
        public string name = "Naruto";
        public bool life = true;
    }

    // Modificadores Public, sem restrições de acesso ao seus métodos e atributos.
    public class Classes
    {
        // Especifícadores Static, os método podem ser chamados mesmo que não haja a instância de um objeto.
        static void Main()
        {
            // Criando um novo objeto à partir da classse 'Palyers'. Juntamente com todos os atributos criados.
            // O operador 'new' indica que será craiado um novo endereço de memória para 'player' com todos os atributos da classe.
            Players player = new Players();

            // Podemos alterar o valor do atributo à partir do novo objeto craido.
            // Aqui só é alterado o valor da variável 'player.name' que recebe os atributos da classe 'Players'
            string name = player.name = "Sassuke";
            System.Console.WriteLine("Player: {0}", name);
            System.Console.WriteLine("Life: {0}", player.life);

            // Veja que o atributo da classe original não é alterado.
            Players playerPro = new Players();
            System.Console.WriteLine("Player: {0}", playerPro.name);
            System.Console.WriteLine("Life: {0}", playerPro.life);
        }
    }
}
