class Music
{    
    public string Name { get; set; } = "";
    public string Artist { get; set; } = "";
    public int Duration { get; set; }
    public bool Avaliable { get; set; }
    public string Description => $"{Name} - {Artist}"; 
  

    public void Show() 
    {
        Console.WriteLine(Description);
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