// Permite criar valores com tipos pré definidos que podem ser associados de acordo com seu indice.

namespace Enums
{
    class Enum
    {
        enum DayWeek
        {
            Domingo,
            Segunda,
            Terça,
            Quarta,
            Quinta,
            Sexta,
            Sábado,
        };

        static void Main()
        {
            // Neste caso a variável 'day' é do tipo 'DayWeek'.
            // Isto é, essa variável só pode conter valores que estão no enum 'DayWeek'.
            // Então essa variável do tipo 'DayWeek' recebe um valor que está presente dentro do enum 'DayWeek'.
            DayWeek day = DayWeek.Terça;
            System.Console.WriteLine(day);

            // Este representa a mesma estrutura acima, porém aqui estou passando o indice do valor que está presente dentro de 'DayWeek'.
            // Isto é, o indice '0' presente no enum 'DayWeek' é 'Domingo', ou seja, este valor 'Domingo' será armazenado na variável 'dayIndex'.
            DayWeek dayIndex = (DayWeek)0;
            System.Console.WriteLine(dayIndex);

            // Este representa o contrário dos exemplos acima.
            // Aqui eu desejo o valor do indice onde está armazenado o tipo acessado.
            // Isto é, eu desejo mostrar o número que representa o dia da semana.
            // Ex: Domingo é o primeiro dia da semana, Sexta é o sexto dia da semana.
            // Deve-se fazer typecasting para poder atribuir o valor na váriavel.
            // Aqui a variável deve receber um tipo 'int'. Porém o valor do enum é string.
            int dayInt = (int)DayWeek.Sexta;
            System.Console.WriteLine(dayInt += 1); // Somando 1 ao valor pois todos os indices em C# se iniciam do 0.
        }
    }
}
