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

      if (result < 50)
      {
        text = "reprovado";
      }
      else if (result < 60) {
        text = "de recuperação";
      }
      else
      {
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