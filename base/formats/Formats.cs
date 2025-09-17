namespace Format
{
class Format
{
  static void Main(string[] args)
  {
    int value = 0;
    int valueTwo = 2;
    int valueThree = 3;

    double valueBuy = 1200;
    double fees = 0.55;
    double valueSale = (valueBuy * fees) + valueBuy;
    string product = "PC Gamer";


    System.Console.Write(
        "\n O value = {0} / valueTwo = {1} / valueThree = {2} \n",
        value, valueTwo, valueThree
    );

    System.Console.Write(
        "\n O Produto {0} custou {1,0:c} e será vendido por {2,0:c} \n Taxa de venda de {3,0:p}",
        product, valueBuy, valueSale, fees
    );
  }
}
}