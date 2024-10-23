class Music
{    
    public string name = "";
    public string artist = "";
    public int duration;
    private bool avaliable;

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

    public bool IsAvaliable() 
    {
        return avaliable;
    }

    public void SetAvaliable(bool value)
    {
        avaliable = value;
    }
}