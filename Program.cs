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

void ExibirTitulos(string titulo)
{
    int qntdLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(qntdLetras, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n");
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
    Console.Write("\nPor favor, d1igite uma das opções para continuar: ");
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
            avaliarBanda();
            break;
        case 4:
            mediaDasBanda();
            break;
        case 0:
            exibirLogoSaida();
            break;
        default:
            Console.WriteLine("Por favor, digite algumas das opções acima");
            break;
    }
}

// Dicionario de armazenamento do nome das bandas
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
// Bandas adicionada ao dicionario para exemplo
bandasRegistradas.Add("LinkinPark", new List<int> {10,5,6,3,4});
bandasRegistradas.Add("Slipknot", new List<int> {10,9,6,7,5});

// Função responsavel por registar o nome das bandas e adicionar na lista de armazenamento
void RegistroBanda()
{
    Console.Clear();
    ExibirTitulos("REGISTRO DE BANDAS");
    Console.Write("Insira o nome da banda a ser registrada: ");
    string nomeBanda = Console.ReadLine()!;
    //listaDasBandas.Add(nomeBanda); // Curiosidade se a função for declarada como 'static', você não cnsegue acessar a lista de for da função. Funções locais static não podem capturar variáveis do escopo externo (como listaDasBandas) nem usar this.
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(1500);
    menuOpcoes();
}

// Função responsavel por imprimir no console todos os nomes de bandas armazenadas na lista
void listarBandas()
{
    Console.Clear();
    ExibirTitulos("LISTA DE BANDAS REGISTRADAS");
    foreach (var banda in bandasRegistradas.Keys)
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

// Função responsavel pela avaliação das bandas
void avaliarBanda()
{
    Console.Clear();
    ExibirTitulos("AVALIAR BANDA");
    Console.Write("Digite a banda que você quer avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual a nota que a {nomeBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"\n A nota {nota} foi registrada com sucesse a banda {nomeBanda}!");
        Thread.Sleep(4000);
        Console.Clear();
        menuOpcoes();
    } else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada!");
        Console.Write("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        menuOpcoes();
    }
}

// Função responsavel pela exibição da média de avaliação de cada banda
void mediaDasBanda()
{
    Console.Clear();
    ExibirTitulos("MÉDIA DE AVALIAÇÃO DAS BANDAS");
    Console.Write("Por favor, digite o nome da banda que você deseja ver a média: ");
    string banda = Console.ReadLine()!;
    double mediaBanda = bandasRegistradas[banda].Average();
    Console.WriteLine($"A média atual da banda {banda} é: {mediaBanda}");
}

menuOpcoes();