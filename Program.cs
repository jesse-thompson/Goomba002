// See https://aka.ms/new-console-template for more information

Star star = new Star(8);
GoombaAdv goombaAdv = new GoombaAdv(4);
Ground ground = new Ground(120);

GoombaWalk gWalk = new GoombaWalk(star, goombaAdv, ground);

gWalk.StartAnimation();
