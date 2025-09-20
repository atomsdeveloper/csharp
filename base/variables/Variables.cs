// Uma váriavel é uma posição reservada na memória 'RAM' para armazenar valores e resultados.
// Isto é, variáveis são como *'Caixa' vazias, dentro dessas caixas podemos armazenar/inserir *'Valor'. Fora da caixa temos a 'etiqueta' para inferir o *'Tipo' do valor dentro da caixa.
// Isso acontente pois ao declarar uma variavél é criado uma espécie de ponterio, que por sua vez aponta (rs) para uma valor reservado na memória 'RAM' onde será armazenado.

// Ex:

// *Tipo: Int = Interiro
// *Caixa: Bank
// *Valor: 100 = Número do tipo inteiro.

// Pode se notar que se usa o sinal '=' entre a *'Caixa' (bank) e o *'Valor' (100). Este sinal é para atribuições.
// Ou seja, sempre que desejamos atribuir um valor a uma variável usamos esse sinal '=' que é lido como 'recebe'. (o sinal de igual é usado: '==' é lido como 'igual à').

// Sendo assim:
// *int *bank = *100;   -> Tipo inteiro chamado bank rebece o valor 100.

// Em C# que é uma líguagem fortemente tipada, onde se deve passar o tipo que será atribuido a uma váriavel.
// Váriaveis declaradas com 'var' não recebem tipo, mas, ao atribuir um valor à declaração o tipo é automáticamente definido.

// Int -> Inteiros
// Char -> 1byte
// Float -> Ponto Flutuante
// Byte -> 8bytes
// String -> Array de Char
// Bool -> True or False
// Double ->

// TODO: Pesquisar demais tipos.

namespace Variables
{
    class VariablesDotnet
    {
        static void Main()
        {
            int value = 0;
            char letter = 'R'; // 1 Bit
            float price = 1.5f;
            double sale = 5.50;
            bool result = 10 < 5; // True of False

            byte bytes = 08; // 8 Bytes

            long a;

            string text = "Lorem ipsum";

            // Variável sem tipo.
            // Declaração com 'var'.
            var noType;
            // Rebece um tipo automáticamente após receber um valor.
            noType = "Now your type is string.";
            noType = 1; // Agora seu tipo é um número (pode ser alterado o valor pois é uma declaração com 'var'.).

            // Diferentemente de um 'const' que seu valor nunca pode mudar.
            // Deve ser sempre inicializada. (runtime).
            // E sempre conter seu tipo definido.
            const string car = "Mustang";

            // car = "Ford"; Error -> The value of const cannot be change.

            // Delaração de multiplas variáveis.
            int age,
                year,
                day;
            string name,
                lastName;

            System.Console.WriteLine(noType);
        }
    }
}
