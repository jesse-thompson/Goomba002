// See https://aka.ms/new-console-template for more information

Star star = new Star(4);
GoombaAdv goombaAdv = new GoombaAdv(4);
// Goomba goomba = new Goomba(4);
Ground ground = new Ground(120);

GoombaWalk gWalk = new GoombaWalk(star, goombaAdv, ground);
// GoombaWalk gWalk = new GoombaWalk(star, goomba, ground);

gWalk.StartAnimation();
