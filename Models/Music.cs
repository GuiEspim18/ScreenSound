namespace ScreenSound.Models;

class Music
{    

    public Music(Band band) 
    {
        Band = band;
    }

    public string Name { get; set; } = "";
    public Band Band { get; }
    public int Duration { get; set; }
    public bool Avaliable { get; set; }
    public string Description => $"{Name} - {Band.Name}"; 
  

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