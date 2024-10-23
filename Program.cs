Console.Clear();

Band arcticMonkeys = new("Arctic Monkeys");

Album am = new(arcticMonkeys)
{
    Name = "AM"
};

arcticMonkeys.AddAlbum(am);

Music doIWannaKnow = new(arcticMonkeys)
{
    Name = "Do I Wanna Know?",
    Duration = 432,
    Avaliable = true
};

Music arabella = new(arcticMonkeys)
{
    Name = "Arabella",
    Duration = 327,
    Avaliable = true
};

am.AddMusic(doIWannaKnow);
am.AddMusic(arabella);

am.ShowMusics();