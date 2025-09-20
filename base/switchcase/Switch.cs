// Switch é bem parecido com 'if', onde determinados dados serão executados, atribuidos ou armazenados caso a condição seja satisfeita.
// Diferentemente do 'if' o 'switch' só deve executar valores que podem 'verdadeiros'.
// Isto é, todos os valores presentes em 'case' podem existir, não são dados de erro ou coisa do tipo.
// São opções que realmente pode ser acessadas, a questão é que o 'switch' apenas verifica qual foi a 'opção' selecionada.
// Como pode ver no exemplo abaixo, nós temos 4 opções de escolha, caso a opção não seja nenhuma das 4 o programa cai no 'default'.

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

            // Aqui ao passar 'options', é determinado que somente podemos ter 4 opções (A, M, C e O).
            // Dai en diante o 'case' se preucupa em saber qual a 'option' atual.
            switch (option)
            {
                case 'a':
                    price = 1899.0f;
                    stoped = 0;
                    time = "2hrs";

                    System.Console.WriteLine(
                        "Sua opção é {0}, o preço total é {1:N2}, o tempo de viagem é de {2} e tem {3} paradas.",
                        option,
                        price,
                        time,
                        stoped
                    );
                    break;
                case 'm':
                    price = 450.00f;
                    stoped = 2;
                    time = "18hrs";
                    System.Console.WriteLine(
                        "Sua opção é {0}, o preço total é {1,0:c}, o tempo de viagem é de {2} e tem {3} paradas.",
                        option,
                        price,
                        time,
                        stoped
                    );
                    break;

                case 'c':
                    price = 600.00f;
                    stoped = 3;
                    time = "14hrs";
                    System.Console.WriteLine(
                        "Sua opção é {0}, o preço total é {1,0:c}, o tempo de viagem é de {2} e tem {3} paradas.",
                        option,
                        price,
                        time,
                        stoped
                    );
                    break;

                case 'o':
                    price = 300.00f;
                    stoped = 5;
                    time = "22hrs";
                    System.Console.WriteLine(
                        "Sua opção é {0}, o preço total é {1,0:c}, o tempo de viagem é de {2} e tem {3} paradas.",
                        option,
                        price,
                        time,
                        stoped
                    );
                    break;

                // Como dito acima, caso nenhuma 'options' valida seja passada o código cai aqui por padrão. ('default').
                default:
                    System.Console.WriteLine("Opção inválida, tente novamente!");
                    break; // Finaliza a execução após encontrar a 'option' presentes nos 'case' ou aqui no 'default'.
            }
        }
    }
}
