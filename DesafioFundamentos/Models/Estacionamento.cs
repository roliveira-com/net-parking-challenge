namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Pede para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string userInput = Console.ReadLine();

            while (userInput.Length < 7)
            {
                Console.WriteLine("Você precisa digitar uma placa uma placa válida, tente denovo.");
                userInput = Console.ReadLine();
            }

            veiculos.Add(userInput.ToUpper());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pede para o usuário digitar a placa e armazenar na variável placa
            string userInput = Console.ReadLine();

            // Adciona uma validação nos dados digitados
            while (userInput.Length < 7)
            {
                Console.WriteLine("Você precisa digitar uma placa uma placa válida, tente denovo.");
                userInput = Console.ReadLine();
            }

            string placa = userInput.ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x == placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Pede para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Exibindo os veículos estacionados
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine($" {i}. | {veiculos[i]}");
                }
                ;
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
