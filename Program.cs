// Função responsão pela exibição das informações Boas Vindas do aplicativo
void exibirLogoEntrada()
{
    Console.Clear();
    Console.WriteLine(@"
      ╭━━━╮╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭━━━╮╱╱╱╱╱╱╱╱╱╱╭╮
      ┃╭━╮┃╱╱╱╱╱╱╱╱╱╱╱╱╱╱┃╭━╮┃╱╱╱╱╱╱╱╱╱╱┃┃
      ┃╰━━┳━━┳━┳━━┳━━┳━╮╱┃╰━━┳━━┳╮╭┳━╮╭━╯┃
      ╰━━╮┃╭━┫╭┫┃━┫┃━┫╭╮╮╰━━╮┃╭╮┃┃┃┃╭╮┫╭╮┃
      ┃╰━╯┃╰━┫┃┃┃━┫┃━┫┃┃┃┃╰━╯┃╰╯┃╰╯┃┃┃┃╰╯┃
      ╰━━━┻━━┻╯╰━━┻━━┻╯╰╯╰━━━┻━━┻━━┻╯╰┻━━╯
GitHub: https://github.com/NC-JMonteiro/about_me
Version: 1.0");

    Console.WriteLine("\nBoas vindas ao Screen Sound!\n");
}

// Funcão responsavel pela exibição de infomações de saída do aplicativo
void exibirLogoSaida()
{
    Console.Clear();
    Console.WriteLine(@"
      ╭━━━╮╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭━━━╮╱╱╱╱╱╱╱╱╱╱╭╮
      ┃╭━╮┃╱╱╱╱╱╱╱╱╱╱╱╱╱╱┃╭━╮┃╱╱╱╱╱╱╱╱╱╱┃┃
      ┃╰━━┳━━┳━┳━━┳━━┳━╮╱┃╰━━┳━━┳╮╭┳━╮╭━╯┃
      ╰━━╮┃╭━┫╭┫┃━┫┃━┫╭╮╮╰━━╮┃╭╮┃┃┃┃╭╮┫╭╮┃
      ┃╰━╯┃╰━┫┃┃┃━┫┃━┫┃┃┃┃╰━╯┃╰╯┃╰╯┃┃┃┃╰╯┃
      ╰━━━┻━━┻╯╰━━┻━━┻╯╰╯╰━━━┻━━┻━━┻╯╰┻━━╯
GitHub: https://github.com/NC-JMonteiro/about_me
Version: 1.0");

    Console.WriteLine("\nObrigado por usar nossos aplicativos!");
}

// Função responsavel por exibição da lista de opções e chamar a função 'listOpcoes'
void menuOpcoes()
{
    exibirLogoEntrada();
    Console.WriteLine("Menu de opções:\n");
    Console.WriteLine(@"Digite 1 para resgistrar uma banda
Digite 2 para mostrar todas as bandas
Digite 3 para avaliar uma banda
Digite 4 para exibir a média de uma banda
Digite 0 para sair");

    listOpcoes();
}

// Função responsavel pela lógica das opções usando o swich
void listOpcoes()
{
    Console.Write("\nPor favor, digite uma das opções para continuar: ");
    int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

    switch (opcaoEscolhida)
    {
        case 1:
            RegistroBanda();
            break;
        case 2:
            listarBandas();
            break;
        case 3:
            Console.WriteLine($"Você digitou {opcaoEscolhida}");
            break;
        case 4:
            Console.WriteLine($"Você digitou {opcaoEscolhida}");
            break;
        case 0:
            exibirLogoSaida();
            break;
        default:
            Console.WriteLine("Por favor, digite algumas das opções acima");
            break;
    }
}

// Lista de armazenamento do nome das bandas
List<string> listaDasBandas = new List<string>();

// Função responsavel por registar o nome das bandas e adicionar na lista de armazenamento
void RegistroBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Insira o nome da banda a ser registrada: ");
    string nomeBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeBanda); // Curiosidade se a função for declarada como 'static', você não cnsegue acessar a lista de for da função. Funções locais static não podem capturar variáveis do escopo externo (como listaDasBandas) nem usar this.
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(1500);
    menuOpcoes();
}

// Função responsavel por imprimir no console todos os nomes de bandas armazenadas na lista
void listarBandas()
{
    Console.Clear();
    Console.WriteLine("Lista de bandas registradas:\n");
    foreach (var banda in listaDasBandas)
    {
        Console.WriteLine(banda);
    }
    Console.Write("\nDigite 0 para voltar ao menu principal ou 1 para resgistar uma nova banda: ");
    int decisaoListaDasBandas = int.Parse(Console.ReadLine()!);
    switch (decisaoListaDasBandas)
    {
        case 1:
            RegistroBanda();
            break;
        case 0:
            menuOpcoes();
            break;
        default:
            Console.WriteLine("Por favor, digite uma opção válida: ");
            break;
    }
}


menuOpcoes();