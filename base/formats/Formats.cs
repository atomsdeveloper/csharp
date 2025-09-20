namespace Format
{
    class Format
    {
        static void Main(string[] args)
        {
            int value = 0;
            int valueTwo = 2;
            int valueThree = 3;

            double valueBuy = 1200.0;
            double fees = 0.55;
            double valueSale = (valueBuy * fees) + valueBuy;
            string product = "PC Gamer";

            // Apenas formatação de dados nas 'strings'
            // Usando indices para serem acessados os valores das variáveis.
            // {0} = value, {1} = valueTwo, {2} = valueThree.
            // '\n' para quebra de linha.
            System.Console.Write(
                "\n O value = {0} / valueTwo = {1} / valueThree = {2} \n",
                value,
                valueTwo,
                valueThree
            );

            // Formatação de valores em Reais e adcinado formatação para Porcentagem.
            // {1,0:c} = 1 -> Indice / ,0 -> Valor de casas decimais após a vírgula / :c -> Formação em Reais
            // {3,0:p} = :p -> Formação em Porcentagem.
            System.Console.Write(
                "\n O Produto {0} custou {1,0:c} e será vendido por {2,0:c} \n Taxa de venda de {3,0:p}",
                product,
                valueBuy,
                valueSale,
                fees
            );
        }
    }
}
