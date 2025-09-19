// Matriz é muito parecida com 'array', onde temos determinados valores inseridos em determinados indices.
// Porém em 'matriz' os valores armazenados nos indices devem conter sua linha e coluna.
// Isto é, toda matriz deve ser preenchida indicando seu indice de linha e seu indice de coluna.
// Diferentemente do 'array' que possue somente indice de linha.
// Ou seja, ao delclarar uma 'matriz' deve-se indicar quantas linha e colunas a 'matriz' terá.

namespace Matriz
{
    class Matriz
    {
        static void Main()
        {
            // Está declaração indica que será uma 'matriz' por conta da ',' dentro de '[]' juntamente de seu tipo.
            // Sendo assim deve-se passar a quantidade de linhas e colunas para a matriz.
            // Neste caso a quantidade de linhas é '2' e a quantidade de colunas é '3'.
            int[,] matriz = new int[2, 3];
            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;

            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            matriz[1, 2] = 6;

            System.Console.WriteLine(matriz[0, 1]); // 2

            // Mesma coisa do ex acima, aqui porém é feita a atribuição de valores de linhas e colunas na inicialização da 'matriz'.
            // Como pode ver para iniciar uma 'matriz' juntamente de sua declaração deve-se abrir chaves '{}'.
            // Dentro dessa chaves nós temos as linha e colunas que deverão ser preenchidas com valores.
            // Neste caso dentro da primeira camada de chaves '{}' no indice de linha 0 deve-se atribuir os valores das colunas também usando chaves '{}'.
            // O primeiro conjunto de chaves '{}' indica que será atribuido valores, à partir disso toda chave '{}' se refere ao indice de linha.
            // E todo valor passado dentro dessa segunda chave que representa a linha, será armazenado nas colunas da 'matriz'.

            //                                      0L          1L     
            int[,] matrizInit = new int[2, 2] { { 10, 20 }, { 30, 40 } };
            //                                    0C  1C      0C  1C

            System.Console.WriteLine(matrizInit[1, 1]); // 40
            //                                  1L 1C                                       W
        }
    }
};
