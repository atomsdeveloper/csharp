// If determina os dados que serão executados, atribuidos ou armazenados caso a condição seja satisfeita.
// ele executa somente os valores que forem dados como 'verdadeiros'.
// Isto é, antes de realizar as operações dentro dese bloco de código ele verifica se sua condição é verdadeira.
// Como pode ver no exemplo abaixo, nós temos várias condições que podem ou não ser statisfeitas.
// Diferentemente de 'swith' que apenas verifica qual foi a 'opção' selecionada.
// Já o 'if' podemos dizer que pode ter 'infinitas' condições até que determinado valor se satisfeito. (caso do If aninhado.).

namespace Conditional
{
  class If
  {
    static void Main()
    {
      int nota, notaTwo;
      int result;
      string text;

      System.Console.WriteLine("Dígite uma nota: ");
      nota = int.Parse(System.Console.ReadLine());

      System.Console.WriteLine("Dígite outra nota: ");
      notaTwo = int.Parse(System.Console.ReadLine());

      result = (nota + notaTwo) / 2;

      // Expressões/Condições if que podem ser verdadeiras ou falsas. (caso falso passa para a próxima condição.).
      if (result < 50)
      {
        text = "reprovado";
      }
      else if (result < 60)
      {
        text = "de recuperação";
      }
      else
      {
        // Exemplo de if aninhado. (que nada mais é do que um if dentro de outro if.).
        if (result > 90)
        {
          text = "parabéns";
        }
        text = "aprovado";
      }

      System.Console.WriteLine("Aluno {0}.", text);
    }
  }
}