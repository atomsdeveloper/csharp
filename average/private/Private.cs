// Private   ->  só podem ser acessados pela própria classe.

namespace Private {
    class Player {
        // Craindo atributos privados para serem lidos somente de seus métodos.
        // Estes atributos só podem ser acessados de sua própria classe. Neste caso é 'Player'.
        private string name = "Renan";
        private int energy = 80;

        // Para acessar atributos privados em uma instância dessa clesse deve-se criar métodos.
        // Onde a instância da classe deve chamar o método que retorna os valores desejados.
        public string getName() {
            return name;
        }

        public string getEnergy() {
            return energy;
        }

        // Para alterar atibutos privados em uma instância dessa classe também deverão ser criados métodos.
        // Onde as instância da classe deve chamar o método que retorna os valores alterados.
        public string setEnergy(int value, char operate) {
            int response;

            // Lógica simples somente para modificar os valores de 'energy'.
            // Com tratamento de dados para não aceitar valores menores que 0 e nem maiores que 100.
            switch (operate) {
                case '-':
                    response = value - energy;
                    if (response <= 0) {
                        return energy = 0;
                    }
                    return response;
                    break;
                case '+':
                    response = value + energy;
                    if (response >= 100) {
                        return energy = 100;
                    }
                    return response;
                    break;
                default:
                    System.Console.WriteLine("Error class player in method setEnergy.");
                    return energy;
                    break;
            }
        }
    }

    class Private {
        public void Main() {
            Player player = new Player();
            string name = player.name; // Não será possível visualizar o valor de 'name' pois o atributo é delarado como 'private'.

            // Forma correta de acessar e alterar atributos privados de uma instância.
            player.getName();
            player.getEnergy();
            player.setEnergy(20, '-'); // Decrementando 20 a 'energy' do 'player'.
            player.setEnergy(10, '+'); // Acresentando 10 a 'energy' do 'player'.
            player.setEnergy(40, '+'); // Acresentando 10 a 'energy' do 'player'.


            System.Console.WriteLine("player {0}", player); // undefined
            System.Console.WriteLine("player {0}", player.getEnergy()); // retorna o valor da 'enegy'.
        }
    }
}
