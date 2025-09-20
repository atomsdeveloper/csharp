// Goto é usado em programas C# para retorna em um trecho de código caso uma condição seja satifeita, ou algo parecido.
// Isto é, dependendo das informações que o programa obteve o código é retornado para uma determinada aréa do programa.
// Isso faz com que o programa termine somente se a condição não for mais satisfeita (que é o nosso caso neste exemplo).

namespace Goto
{
    class Go
    {
        static void Main()
        {
            int option;
            char shouldContinue;

            // Isso indica para o 'go to' de onde o programa deve reiniciar.
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
                        // Vai para o inicio do programa caso a condição seja satisfeita.
                        goto start;
                    }
                    // Finaliza o programa caso a condição não for satisfeita.
                    System.Console.WriteLine("Saiu do sistema.");
                    break;
            }
        }
    }
}
