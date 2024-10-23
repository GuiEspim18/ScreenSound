class Music
{    
    public string Name { get; set; } = "";
    public string Artist { get; set; } = "";
    public int Duration { get; set; }
    public bool Avaliable { get; set; }
    public string CompleteName { get; set; } = "";

    public void Show() 
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Artista: {Artist}");
        Console.WriteLine($"Duração: {Duration}");
        if (Avaliable) 
        {
            Console.WriteLine("Disponível no plano!");
        } else 
        {
            Console.WriteLine("Indisponível no plano!");
        }
    }
}