// Static diretiva que se refere a métodos ou atributos que pertencem ao tipo não à instância.
// Const diretiva que que não pode ser alterada e seu valor precisa ser conhecido em tempo de execusão.
// Isto é, o programa precisa saber do valor da variável antes mesmo de ser executado o programa.
// Valores do tipo 'runtime' que são executados em tempo de execução usam a diretive 'readony'.
// Estes valores de 'runtime' precisam ser sempre 'static'. ou seja, pertence ao tipo e não à intância.
// Uma Constante a nível de classe não pode ser marcada como 'static'.
namespace Constants
{
  class Constants
  {
    static readonly int year = System.DateTime.Now.Year;
    const string text = "text"; // OK

    static void Main()
    {
      const string name = "Renan";

      System.Console.Write("\n {0} \n {1} \n {2} \n", name, year, text);
    }
  }
}