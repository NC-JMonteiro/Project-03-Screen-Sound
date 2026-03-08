static void TelaPrincipal()
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

menuOpcoes();
}

static void menuOpcoes()
{
    Console.WriteLine("Menu de opções:\n");
    Console.WriteLine(@"Digite 1 para resgistrar uma banda
Digite 2 para mostrar todas as bandas
Digite 3 para avaliar uma banda
Digite 4 para exibir a média de uma banda
Digite 0 para sair");

listOpcoes();
}

static void listOpcoes()
{
    Console.Write("\nPor favor, digite uma das opções para continuar: ");
    int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());
    
    switch (opcaoEscolhida)
    {
        case 1: RegistroBanda();
            break;
        case 2: Console.WriteLine($"Você digitou {opcaoEscolhida}");
            break;
        case 3: Console.WriteLine($"Você digitou {opcaoEscolhida}");
            break;
        case 4: Console.WriteLine($"Você digitou {opcaoEscolhida}");
            break;
        case 0: Console.WriteLine("Obrigado por usar nossos aplicativos!");
            break;
        default: Console.WriteLine("Por favor, digite algumas das opções acima");
            break;
    }
}

static void RegistroBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Insira o nome da banda a ser registrada: ");
    string banda = Console.ReadLine()!;
    Console.WriteLine($"A banda {banda} foi registrada com sucesso!");
    Thread.Sleep(1500);
    TelaPrincipal();
}
TelaPrincipal();