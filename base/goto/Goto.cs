namespace Goto
{
  class Go
  {
    static void Main()
    {
      int option;
      char shouldContinue;

      start:
      System.Console.Clear();

      System.Console.WriteLine("Dígite um valor: ");
      option = int.Parse(System.Console.ReadLine());

      switch (option)
      {
        case 1:
          System.Console.WriteLine("Parabéns, este é o número da sorte.");
          break;
        default:
          System.Console.WriteLine("Aaaa, tente novamente! [S]sim [N]não");
          shouldContinue = char.Parse(System.Console.ReadLine());

          if (shouldContinue == 's')
          {
            goto start;
          }
          break;
      }


    }
  }
}