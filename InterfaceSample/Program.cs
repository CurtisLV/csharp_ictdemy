using InterfaceSample;

IBird bird = new Bird();

Pterodactyl pterodactyl = new Pterodactyl();


IBird bird2 = new Pterodactyl();
bird2.Breathe();

((Pterodactyl)bird2).Crawl();

IBird bird3 = new Pterodactyl();
bird.Breathe();
ILizard lizard = new Pterodactyl();
lizard.Breathe();
