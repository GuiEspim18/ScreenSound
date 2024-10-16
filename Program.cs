// Screen sound

// List<string> bands = new();

Dictionary<string, List<int>> bands = new();

void ShowLogo() 
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
}

void ShowMenuOptions() 
{
    Console.Clear();
    ShowLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite uma opção: ");
    int option = int.Parse(Console.ReadLine()!);
    
    switch (option) 
    {
        case 1: RegisterBand(); break;
        case 2: ShowBands(); break;
        case 3: RateBand(); break;
        case 4: ShowAvarage(); break;
        case 0: Console.WriteLine("Até logo!"); break;
        default: Console.WriteLine("Opção inválida"); break;
    }
}

void RegisterBand() 
{
    Console.Clear();
    ShowTitle("Registro de bandas");
    Console.Write("Digite o nome da banda que você deseja registrar: ");
    string band = Console.ReadLine()!;
    bands.Add(band, new List<int>());
    Console.WriteLine($"A banda {band} foi registrada com sucesso!");
    Thread.Sleep(2000);
    ShowMenuOptions();
}

void ShowBands() 
{
    Console.Clear();
    ShowTitle("Bandas Cadastradas");
    int order = 1;
    foreach (string band in bands.Keys) 
    {
        Console.WriteLine($"{order}. {band}");
        order++;
    }
    Console.Write("\nPressione qualquer tecla para volar ao menu principal");
    Console.ReadKey();
    ShowMenuOptions();
}

void ShowTitle(string title) 
{
    int size = title.Length;
    string divider = string.Empty.PadLeft(size, '=');
    Console.WriteLine(divider);
    Console.WriteLine(title);
    Console.WriteLine($"{divider}\n");
    
}

void RateBand()
{
    Console.Clear();
    ShowTitle("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string band = Console.ReadLine()!;
    if (bands.ContainsKey(band)) 
    {
        Console.Write($"Qual nota você deseja atribuir à banda {band}? ");
        int rate = int.Parse(Console.ReadLine()!);
        bands[band].Add(rate);
        Console.Write($"Nota atribuida à banda {band}!");
        Thread.Sleep(2000);
    } else 
    {
        Console.Write($"A banda {band} não existe!");
        Console.Write("\nDigite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
    }
    ShowMenuOptions();
}

void ShowAvarage()
{
    Console.Clear();
    ShowTitle("Média da banda");
    Console.Write("Digite o nome da banda na qual você deseja saber a média: ");
    string band = Console.ReadLine()!;
    if (bands.ContainsKey(band)) 
    {
        double avarage = bands[band].Average();
        Console.Write($"A média da banda {band} é {avarage}");
        Console.Write("\nDigite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
    } else 
    {
        Console.Write($"A banda {band} não existe!");
        Console.Write("\nDigite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
    }
    ShowMenuOptions();
}

ShowMenuOptions();

