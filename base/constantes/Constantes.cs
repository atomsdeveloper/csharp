// Diretiva 'static' se refere a métodos ou atributos que pertencem ao tipo não à instância.
// Diretiva 'const' que não pode ser alterada e seu valor precisa ser conhecido em tempo de execusão.
// Isto é, o programa precisa saber do valor da variável antes mesmo de ser executado o programa.

// Valores do tipo 'runtime' que são executados em tempo de execução usam a diretive 'readony'.
// Estes valores de 'runtime' precisam ser sempre 'static'. ou seja, pertence ao tipo e não à intância.
// Uma 'const' não pode ser marcada como 'static'.

// TODO: Entender melhor a 'static' e 'const'.

namespace Constants
{
    class Constants
    {
        // Esta váriavel só tem seu valor atribuido após o inicio do programa. 'runtime'. Ou seja, seu valor só é conhecido em tempo de execução.
        static readonly int year = System.DateTime.Now.Year;

        // Aqui a 'const' sempre precisa ser declarada e inicializada. Não pode depender de 'runtime'.
        // Está variável é conhecida e pode ser acessada em toda a classe.
        const string text = "text"; // OK

        static void Main()
        {
            const string name = "Renan";

            System.Console.Write("\n {0} \n {1} \n {2} \n", name, year, text);
        }
    }
}
