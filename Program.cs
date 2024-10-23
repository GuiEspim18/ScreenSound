Console.Clear();

Band arcticMonkeys = new();
arcticMonkeys.Name = "Arctic Monkeys";

Album am = new();
am.Name = "AM";
am.Band = "Arctic Monkeys";

arcticMonkeys.AddAlbum(am);

Music doIWannaKnow = new();
doIWannaKnow.Name = "Do I Wanna Know?";
doIWannaKnow.Artist = "Arctic Monkeys";
doIWannaKnow.Duration = 432;
doIWannaKnow.Avaliable = true;

Music arabella = new();
arabella.Name = "Arabella";
arabella.Artist = "Arctic Monkeys";
arabella.Duration = 327;
arabella.Avaliable = true;

am.AddMusic(doIWannaKnow);
am.AddMusic(arabella);

am.ShowMusics();