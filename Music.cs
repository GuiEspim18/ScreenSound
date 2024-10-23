class Music
{    
    public string name = "";
    public string artist = "";
    public int duration;
    public bool Avaliable { get; set; }

    public void Show() 
    {
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine($"Artista: {artist}");
        Console.WriteLine($"Duração: {duration}");
        if (Avaliable) 
        {
            Console.WriteLine("Disponível no plano!");
        } else 
        {
            Console.WriteLine("Indisponível no plano!");
        }
    }
}