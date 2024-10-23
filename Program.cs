Console.Clear();

Band arcticMonkeys = new();
arcticMonkeys.Name = "Arctic Monkeys";

Album am = new(arcticMonkeys);
am.Name = "AM";

arcticMonkeys.AddAlbum(am);

Music doIWannaKnow = new(arcticMonkeys);
doIWannaKnow.Name = "Do I Wanna Know?";
doIWannaKnow.Duration = 432;
doIWannaKnow.Avaliable = true;

Music arabella = new(arcticMonkeys);
arabella.Name = "Arabella";
arabella.Duration = 327;
arabella.Avaliable = true;

am.AddMusic(doIWannaKnow);
am.AddMusic(arabella);

am.ShowMusics();