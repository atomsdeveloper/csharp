// Arquivo para listar os método mais usados de um array e para criar nossos próprios métodos de classe.

namespace Methods {
    class MethodsArray {
        // Método principal da classe 'MethodsArray'. Este método sempre será executado após instanciar está classe ou executar este arquivo.
        // Todas as classes por padrão herdam do 'System.Array' ou métodos para vetores.
        static void Main() {
            // Vetores
            int[] vetor = new int[3];
            int[] vetorCopy = new int[3];
            int[] vetorCopyTo = new int[2];

            // Matriz
            string[,] matriz = new string[1, 2] {
                { "Renan", "Ruth" },
            };

            // Inserindo valores aleatórios no 'vetor'.
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = random.Next(10);
            }

            // Ler os valores adicionados no 'vetor'.
            foreach (int item in vetor) {
                System.Console.WriteLine(item);
            }

            // Encontrar um determinado valor dentro do 'vetor'.
            // Array.BinarySearch() -> Método que encontra a posição de um valor caso este valor seja encontrado dentro do vetor. Se não for encontrado retorna -1.
            // Recebe dois params, o primeiro é o vetor que desejamos procurar, já o segundo é o valor em si que deverá ser encontrado.
            int search = 3;
            int position = Array.BinarySearch(vetor, search); // public static int BinarySearch(array, value).
            System.Console.WriteLine("O {0} está na posição {1}", search, position);

            // Copiar os valores de um vetor para outro vetor.
            // Este método usado 'Array' é herdado por todos os 'vetores' criados de 'System.Array'.
            // Onde 'Array.Copy' é um método estático desta classe.
            // 'Copy' é um dos utilitários fornecidos por 'Array'.
            Array.Copy(vetor, vetorCopy, vetor.Length); // public static void Copy(array_origem, array_destino, num_elementos).
            foreach (int item in vetorCopy) {
                System.Console.WriteLine(item);
            }

            // Copiar valores de um vetor para outro à partir de uma determina posição.
            // Este é mais um utilitário 'CopyTo' usado para copiar de um 'vetor' para o outro.
            // Onde 'vetorCopy.CopyTo' é um método da intãncia 'vetorCopy' herdado de 'System.Array'.
            vetorCopy.CopyTo(vetorCopyTo, 1); // public void CopyTo(array_destino, position_init).
            foreach (int item in vetorCopy) {
                System.Console.WriteLine(item);
            }

            // Retorna a quantidade de elementos dentro de um vetor começando da posição 0.
            // Onde 'vetor.GetLongLength' é um método de instância herdado de 'System.Array'.
            long totalElementsInVetor = vetor.GetLongLength(0); // public long GetLongLength(dimension)

            // Retorna o menor índice válido dentro de um vetor ou matriz (C# é zero-based).
            // Onde 'GetLowerBound' é um método de instância herdado de 'System.Array'.
            int smallIndexInVetor = vetor.GetLowerBound(0); // public int GetLowerBound(dimension)
            int smallIndexInMatriz = matriz.GetLowerBound(1); // public int GetLowerBound(dimension)

            // Retorna o maior índice válido dentro de um vetor ou matriz.
            // Onde 'GetUpperBound' é um método de instância herdado de 'System.Array'.
            int largeIndexInVetor = vetor.GetUpperBound(0); // public int GetUpperBound(dimension)
            int largeIndexInMatriz = matriz.GetUpperBound(1); // public int GetUpperBound(dimension)

            // Retorna o valor encontrado tanto em vetores quanto em matrizes.
            // Onde 'GetValue' é um método de instância herdado de 'System.Array'.
            // Deve ser feito um typecast para inteiros, pois o 'GetValue' retorna um 'object'.
            int valueVetor = Convert.ToInt32(vetor.GetValue(0)); // public object GetValue(long index)
            int valueMatriz = Convert.ToInt32(matriz.GetValue(0, 2)); // public object GetValue(long index, long index2)

            // Retorna o índice do primeiro valor passado como parâmetro em um vetor.
            // Onde 'Array.IndexOf' é um método estático da classe 'Array'.
            int firstValuePerIndexVetor = Array.IndexOf(vetor, 3); // public static int IndexOf(array, value)

            // Retorna o índice do último valor passado como parâmetro em um vetor.
            // Onde 'Array.LastIndexOf' é um método estático da classe 'Array'.
            int lastValuePerIndexVetor = Array.LastIndexOf(vetor, 3); // public static int LastIndexOf(array, value)

            // Inverte a ordem dos valores dentro do vetor.
            // Onde 'Array.Reverse' é um método estático da classe 'Array'.
            Array.Reverse(vetor); // public static void Reverse(array)

            // Define um valor em uma posição específica de um vetor.
            // Onde 'SetValue' é um método de instância herdado de 'System.Array'.
            vetorCopy.SetValue(100, 0); // public void SetValue(object value, long position)

            // Ordena os elementos de um vetor em ordem crescente.
            // Onde 'Array.Sort' é um método estático da classe 'Array'.
            Array.Sort(vetor); // public static void Sort(array)

            // Chamando os métodos de classe criados;
            // Cada tipo de método, como os 'void' sem 'return' e sem 'params'.
            Grettings();

            // E também com 'type' com 'return' que recebem 'params'.
            // Aqui pode ser passado como parâmetro dados recebidos do teclado.
            Calculate('+', 2, 5);

            int valueRef = 10;
            // Para declarar a forma de uso tmabém é preciso passar o parametro com 'ref' para o método usado com passagem por referência.
            Double(ref valueRef);
            System.Console.WriteLine(valueRef); // 20

            int dividend = 10;
            int divider = 3;
            int rest; // Não precisa estar inicializada préviamente.

            // Mesmo exemplo de 'ref', porém aqui é indicado onde o valor do retorno de 'rest' vindo do método será aramazenado.
            // Parecido com 'props' do reactjs que passa as propriedade do componente pai para o componente filho e o filho altera a 'prop' que é usada no pai.
            // Então é criada a váriavel 'rest', que é passada como 'param' para o método, o método retorna um valor para 'rest' que é atribuido a váriavel de volta.
            int result = Divide(dividend, divider, out int rest);
            System.Console.WriteLine(result);

            // Com este tipo de passagem de argumentos posso passar os paramentros de forma dinâmica.
            // Aceita vetores pois 'params' é do tipo 'array'.
            int resultNumber = ParamsInt(1, 2, 3);
            int resultVetor = ParamsInt(new int[3] { 10, 20, 30 });
            System.Console.WriteLine(resultNumber, resultVetor);
        }

        // Podemos criar nossos próprios métodos de classe.
        // Este métodos podem ou não retornar um valor e pordem ou não receber parâmetros.
        // Vamos passar pelos dois exemplos.

        // Método que não retorna nada 'void' e não recebe parâmetros '()'.
        static void Grettings() {
            System.Console.WriteLine("Olá");
        }

        // Método que retona um valor do tipo 'Int' e recebe parâmetros (operando, primeiro valor, segundo valor).
        // Também conhecido como método de passagem por valor.
        static int Calculate(char operand, int oneValue, int twoValue) {
            // Antes de retornar o valor é feita a verificação de que tipo de operação será realizada.
            switch (operand) {
                case '+':
                    return oneValue + twoValue;
                    break;
                case '-':
                    return oneValue - twoValue;
                    break;
                case '/':
                    return oneValue / twoValue;
                    break;
                case '+':
                    return oneValue * twoValue;
                    break;
                default:
                    System.Console.WriteLine("Opção inválida, tente novamente!");
                    return 0;
                    break; // Finaliza a execução após encontrar a 'option' presentes nos 'case' ou aqui no 'default'.
            }
        }

        // Existe também o método com passagem pro referência.
        // Parecido com o ponteiro de C++ que aponta para o referência de memória da variável.
        // Ou seja, não é usado o valor da variável para realizar a alteração e sim sua referência de memória.
        // Para declarar esta forma de uso é preciso passar a diretiva 'ref' para o paramentro recebido no método.
        // Isto é, quando se tem um método que não retornar nada, ou seja, nçao retorna o valor alterado, porém ele referência este valor na memória.
        // Ao vericar o valor alterado após a chamada do método, pode se notar que o valor foi alterado por referência.
        static void Double(ref int value) {
            value *= 2;
        }

        // Aqui iremos usar um método com mais de um 'retorno'.
        // Parecido com 'ref' na forma de usar mas tem outro tipo de funcionlidade.
        // Ou seja, não retonamos mais de um dado de fato e sim passamos para uma variável já existente um novo valor.
        // Isto é, usando a diretiva 'out' indica que terá mais de um retorno nesse método onde 'rest' que é a variável que tem 'out' será essa intermediadora.
        static int Divide(int dividend, int divider, out int rest) {
            int quotient = dividend / divider;

            rest = dividend % divider; // A váriavel de saída 'rest' deve receber um valor, que neste caso é o resto da divisão.

            return quotient; // Note aqui que é retornado apena o quociente da operação e não o 'rest'.
        }

        // Aqui vamos usar uma Sintax Sugar para chamdas de métodos com um número variável de argumentos.
        // Neste caso só pode haver um param por método e ele deve ser o último argumento passado para o método.
        // Internamente ele é um 'Array' onde só muda a forma como é chamado o método.
        static int ParamsInt(params int[] vetor) {
            int result = 0;
            bool valid = true;
            bool hasOnlyOne;

            // Ao usar este tipo de recebimento de argumentos em um método é necessário sempre tratar os dados.
            // Params pode ser 0 ou somente 1.
            valid = vetor.Length > 0;
            hasOnlyOne = vetor.Length == 1;

            if (!valid) {
                System.Console.WriteLine("None params found");
            }

            if (hasOnlyOne) {
                System.Console.WriteLine("Only one params found");
            }

            for (int i = 0; i < vetor.Length; i++) {
                result += vetor[i];
            }

            return result;
        }
    }
}