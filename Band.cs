class Band
{

    public Band(string name)
    {
        Name = name;
    }

    public string Name { get; }
    private readonly List<Album> albums = new();

    public void AddAlbum(Album album) 
    {
        albums.Add(album);
    }

    public void ShowAlbuns() 
    {
        Console.WriteLine($"Álbuns da banda {Name}");
        foreach (var album in albums)
        {
            Console.WriteLine($"{album.Name} - ${album.Duration}");
        }
    }
}
