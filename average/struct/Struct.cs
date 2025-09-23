// Struct é uma estrutura 'type value' diferentemente de 'class' que é 'type ref'.
// Usando para objetos pequenos, imutáveis ou quen não precisam de herança.
// Fica na 'stack' pilha de execução ao invés do 'heap' memória dinâmica. Isso traz mais performance.

namespace Struct {
  struct Carro {
    public string brand;
    public string model;
    public string color;

    public Carro(string brand, string model, string color) {
      this.brand = brand;
      this.model = model;
      this.color = color;
    }
  }


  class Struct {
    static void Main() {
      Carro carro;

      // Passando os valores sem constructor, manualmente sem uso do new que cria uma nova 'Ref' na memória.
      // Type Value
      carro.brand = "Chevrolet";
      carro.model = "Blazer";
      carro.color = "Black";
      System.Console.WriteLine(carro.brand); // Chevrolet

      // Aqui o objeto 'car' referência a classe 'Carro', isto é uma instância.
      // Type Ref
      Carro car = new Carro("Fiat", "Uno", "Red");
      System.Console.WriteLine(car.brand); // Fiat


      // Vetor com Struct
      Carro[] carros = new Carro[3]; // Criado um 'vetor' 'carros' que é do tipo 'array' de 'Carros' e obrigatóriamente precesa ter 3 valores.
      // Pode ser inicializado os atributos com contructor.
      carros[0] = new Carro("BYD", "Song Plus", "White");
      carros[1] = new Carro("Hyunday", "I30", "Black");

      // Ou pode inicializar os atributos manualmente.
      carros[2].brand = "Honda";
      carros[2].model = "City";
      carros[2].color = "Gray";

      // Diferença de 'Struct' e 'Class'.
      // Struct tem 'Type Value', ou seja, os dados são copiados e não alterados na ref.
      // Se fosse uma 'class' o carro 0 iria receber em 'model' o valor 'Dolphin' e não somente a cópia.
      Carro carr = carros[0]; // Copia tudo do carro 0 para carr.
      carr.model = "Dolphin"; // Isso altera o valor da cópia e não da ref.

      System.Console.WriteLine(carros[0].brand); // Byd

    }
  }
}