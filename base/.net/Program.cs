// Está diretiva 'namespace' serve para agrupar classe, structures, interfaces, enums e outros tipos.
// Evita o conflito de nomes e torna o código legível e modular.
namespace Dotnet
{
  class Program
  {
    // Nesta etapa o método principal recebe 'args' que é a porta de entrada para informações externas.
    // Permite que seja configurável e dinâmico sem mudar o código.
    static void Main(string[] args)
    {
      // Como 'args' é um 'array' de 'strings' que pode ser passado na inicialização desta app.
      // Então é verificado se ele está vazio.
      if (args.Length < 0) return;

      System.Console.WriteLine("Hello");

      // Caso houver 'args' passado é feito uma passagem por cada elemente e retornado um por um.
      foreach (var key in args)
      {
        System.Console.WriteLine(key);
      }
    }
  }
}