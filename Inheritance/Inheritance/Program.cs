using Inheritance;

Seeded_Plants  seeded_Plants = new Seeded_Plants();
seeded_Plants.Nutrition();
seeded_Plants.Excretion();
seeded_Plants.Respiration();
seeded_Plants.photosynthesis();
seeded_Plants.Seeding();

Console.WriteLine(" *-*-*-*-*-*-*-*-*-*-*");

Ducks ducks = new Ducks();  
ducks.Nutrition();  
ducks.Excretion();
ducks.Respiration();
ducks.swarm_with_animal();
ducks.Swim();   