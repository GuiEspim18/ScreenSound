class Episode
{
    public Episode(int order, string title, int duration)
    {
        Order = order;
        Title = title;
        Duration = duration;
    }

    public int Duration { get; }
    public int Order { get; }
    public string Summary => $"${Order} - ${Title} (${Duration} min)\n Convidados: ${string.Join(",", inviteds)}";
    public string Title { get; }
    public readonly List<string> inviteds = new();

    public void AddInvited(string name) 
    {
        inviteds.Add(name);
    }
}
