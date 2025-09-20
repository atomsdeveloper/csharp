namespace Array
{
    class Array
    {
        static void Main()
        {
            string[] fruits = { "Maça", "Banana" }; // Array com indice e valor.
            foreach (var item in fruits)
            {
                System.Console.WriteLine(item);
            }

            int[] array = new int[3]; // Array criado sem valores, somente com indices.

            // É necessário atribuir os valores as posições.
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;

            foreach (var item in array)
            {
                System.Console.WriteLine(item);
            }
        }
    }
};
