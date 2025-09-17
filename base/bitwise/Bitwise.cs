// Estes operadores server para deslocar os 'bits' para esquerda ou para direita dentro de variáveis 'int'. Os operadores são: << & >>.
// '<<' Converte os bits para esquerda e dobra seu valor.
// '>>' Converte os bits para direita e divede seu valor pela metade.

//  0  -> 00000   5  -> 00101   10 -> 01010   15 -> 01111   20 -> 10100
//  1  -> 00001   6  -> 00110   11 -> 01011   16 -> 10000
//  2  -> 00010   7  -> 00111   12 -> 01100   17 -> 10001
//  3  -> 00011   8  -> 01000   13 -> 01101   18 -> 10010
//  4  -> 00100   9  -> 01001   14 -> 01110   19 -> 10011

// Acima temos uma tabela de bits onde cada grupo de bits representa um número decimal.
// Isto é, se eu quiser fazer um 'bitwise' para a esquerda o resultado seria:

// 00001010 -> Este grupo de bits respresenta o valore 10 em decimal.
// 00001010 << -> Aqui estou fazendo um 'bitwise' para a esquerda, ou seja, será dobrado o valor dos bits.
// 00010100 -> Este é o resultado em bits da operação em 'bitwise' feita na linha acima.
// Veja os bits representados na tabela, como pode ver, usei os bits do valor decimal 10 e fiz o 'bitwise' para esquerda
// ... que dobra o valor, sendo assim ele retorna o valor dobrado em bits que representa o valor decimal 20. 

// O mesmo ocorre para o deslocamento para a direita, sendo que ele diminue pela metade.
// Usando o mesmo exemplo acima, ficaria:

// 00001010 -> Este grupo de bits respresenta o valore 10 em decimal.
// 00001010 >> -> Aqui estou fazendo um 'bitwise' para a direita, ou seja, será diminuido pela metade o valor dos bits.
// 00000101 -> Este é o resultado em bits da operação em 'bitwise' feita na linha acima.
// ... diminue pela metade o valor, sendo assim ele retorna o valor dos bits pela metade que representa o valor decimal 5. 

namespace Bitwise
{
  class Bit
  {
    static void Main()
    {
      int valueBitwiseLeft = 10;
      int valueBitwiseRight = 20;

      // O valor '1' após o uso do 'bitwise' indica a quantidade de vezes que será dobrado ou diminuido pela metade o valor armazenado em 'valueBitwiseLeft'.
      valueBitwiseLeft = valueBitwiseLeft << 1;
      valueBitwiseRight = valueBitwiseRight >> 2;

      System.Console.WriteLine("Valor de valueBitwiseLeft: {0} \n Valor de valueBitwiseRight: {1}", valueBitwiseLeft, valueBitwiseRight);
    }
  }
}