namespace Args {
  class Args {
    // Recebendo 'args' ao iniciar o programa passando 'params'.
    static void Main(string[] args) {
      if (args.Length <= 0) {
        System.Console.WriteLine("Args empty");
      }

      int currentArgs = args.Length;
      int result = 0;

      foreach (var item in args) {
        System.Console.WriteLine(item);
        result += System.Int32.Parse(item);
      }

      System.Console.WriteLine("Total args receives: {0}", currentArgs);
      System.Console.WriteLine("Sum args receives: {0}", result);

    }
  }
}