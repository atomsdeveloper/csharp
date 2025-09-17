namespace Switch
{
  class SwitchCase
  {
    static void Main()
    {
      string time;
      char option;
      int stoped;
      float price;

      System.Console.WriteLine("BAHIA - Salvador");
      System.Console.WriteLine("Como deseja viajar? [A]avião [M]moto [C]carro [O]õnibus");
      option = char.Parse(System.Console.ReadLine());

      switch (option)
      {
        case 'a':
          price = 1899.0f;
          stoped = 0;
          time = "2hrs";

          System.Console.WriteLine("Sua opção é {0}, o preço total é {1:N2}, o tempo de viagem é de {2} e tem {3} paradas.", option, price, time, stoped);
          break;
        case 'm':
          price = 450.00f;
          stoped = 2;
          time = "18hrs";
          System.Console.WriteLine("Sua opção é {0}, o preço total é {1,0:c}, o tempo de viagem é de {2} e tem {3} paradas.", option, price, time, stoped);
          break;

        case 'c':
          price = 600.00f;
          stoped = 3;
          time = "14hrs";
          System.Console.WriteLine("Sua opção é {0}, o preço total é {1,0:c}, o tempo de viagem é de {2} e tem {3} paradas.", option, price, time, stoped);
          break;

        case 'o':
          price = 300.00f;
          stoped = 5;
          time = "22hrs";
          System.Console.WriteLine("Sua opção é {0}, o preço total é {1,0:c}, o tempo de viagem é de {2} e tem {3} paradas.", option, price, time, stoped);
          break;

        default:
          System.Console.WriteLine("Opção inválida, tente novamente!");
          break;
      }
    }
  }
}