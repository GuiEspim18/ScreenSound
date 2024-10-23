class Music
{    
    public string name = "";
    public string artist = "";
    public int duration;
    public bool avaliable { get; set; }

    public void Show() 
    {
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine($"Artista: {artist}");
        Console.WriteLine($"Duração: {duration}");
        if (avaliable) 
        {
            Console.WriteLine("Disponível no plano!");
        } else 
        {
            Console.WriteLine("Indisponível no plano!");
        }
    }
}