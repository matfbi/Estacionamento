using Estacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 5.00M;
decimal precoPorHora = 2.00M;

var estacionamento = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;

do
{
    Console.WriteLine("\nDigite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3":
            estacionamento.ListarVeiculos();
            break;
        case "4":
            Console.WriteLine("Encerrando...");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
while (opcao != "4");
