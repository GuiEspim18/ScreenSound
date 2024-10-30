namespace ScreenSound.Models;

class Podcast
{
    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public string Host { get; }
    public string Name { get; }
    private readonly List<Episode> episodes = new();

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void Show() 
    {
        int totalEpisodes = episodes.Count();
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Total de episódios: {totalEpisodes}");
    }
}
