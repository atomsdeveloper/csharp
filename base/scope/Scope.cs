// O escobo define onde a variável pode ser visível.

class Scope
{
  static int valTwo = 10; // Variável global que pode ser acessada de qualquer método ou atributo.
  static void Main()
  {
    // Esse seria um contexto normal.
    int val = 20;
    // ...aqui poderia vir algum tipo de manipulção antes de logar/retornar os dados.
    System.Console.WriteLine(val);

    // Aqui pode ser acessada a variável 'valTwo' pois ela pertence ao escobo de toda a classe 'Scope'.
    System.Console.WriteLine(valTwo);
  }


  // Gera erro de contexto, váriavel 'val' só pode ser acessada dentro do escobo do método 'Main'.
  // System.Console.WriteLine(val);
}