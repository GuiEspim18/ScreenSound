// Screen sound

List<string> bands = new();

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
        case 3: Console.WriteLine("Você escolheu a opção " + option); break;
        case 4: Console.WriteLine("Você escolheu a opção " + option); break;
        case 0: Console.WriteLine("Você escolheu a opção " + option); break;
        default: Console.WriteLine("Opção inválida"); break;
    }
}

void RegisterBand() 
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que você deseja registrar: ");
    string band = Console.ReadLine()!;
    bands.Add(band);
    Console.WriteLine($"A banda {band} foi registrada com sucesso!");
    Thread.Sleep(2000);
    ShowMenuOptions();
}

void ShowBands() 
{
    Console.Clear();
    Console.WriteLine("Bandas Cadastradas\n");
    // for (int i = 0; i < bands.Count; i++) 
    // {
    //     Console.WriteLine($"{i}. {bands[i]}");
    // }
    int order = 1;
    foreach (string band in bands) 
    {
        Console.WriteLine($"{order}. {band}");
        order++;
    }
    Console.Write("\nPressione qualquer tecla para volar ao menu principal");
    Console.ReadKey();
    ShowMenuOptions();
}

ShowMenuOptions();

