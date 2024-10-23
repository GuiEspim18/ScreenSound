class Episode
{
    public Episode(string order, string summary, string title)
    {
        Order = order;
        Summary = summary;
        Title = title;
    }
    
    public int Duration { get; set; }
    public string Order { get; }
    public string Summary { get; }
    public string Title { get; }
    public readonly List<string> inviteds = new();

    public void AddInvited(string name) 
    {
        inviteds.Add(name);
    }
}
