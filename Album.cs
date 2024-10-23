class Album
{
    public Album(Band band) 
    {
        Band = band;
    }
    private readonly List<Music> musics = new();
    public string Name { get; set; } = "";
    public Band Band { get; }
    public int Duration => musics.Sum(m => m.Duration);

    public void AddMusic(Music music) => musics.Add(music);

    public void ShowMusics() 
    {
        Console.WriteLine($"Lista de músicas do álbum {Name}");
        Console.WriteLine($"Duração total: {Duration}");
        Console.WriteLine(Band);
        foreach(var music in musics) 
        {
            Console.WriteLine($"\nNome: {music.Description}");
            Console.WriteLine($"Artista: {music.Band.Name}");
            Console.WriteLine($"Duração: {music.Duration}");
        }
    }
}
