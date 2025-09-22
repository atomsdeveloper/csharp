// Um 'Indexer' é membro que permite os atributos de uma classe serrem indexados como 'arrays'.
// Sendo possível usar os objetos da classe como se fosse um 'aaray'.

namespace Indexed {
  public class Indexer {
    public int[] maxSpeed = new int[1] { 380 };

    // Indexer + GET & SET
    public int this[int i] {
      get {
        return maxSpeed[i];
      }

      set {
        if (maxSpeed[i] <= 180 || maxSpeed[i] >= 381) {
          maxSpeed[i] = maxSpeed[i];
          return;
        }
         maxSpeed[i] = value;
        return;
      }
    }

  }

  public class Skeleto : Indexer {
    public void Skeleton() {}
  }

  class Person {
    static void Main() {
      Skeleto skeleto = new Skeleto();

      int speed = skeleto[0];
      System.Console.WriteLine(speed);

      skeleto[0] = 180;
      int[] res = skeleto.maxSpeed;
      System.Console.WriteLine(res[0]);
    }
  }
}