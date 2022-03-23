// See https://aka.ms/new-console-template for more information

Star star = new Star(4);
Goomba goomba = new Goomba(4);      // value for speed
ParaGoomba pGoomba = new ParaGoomba(4);
Ground ground = new Ground(120);    // value for size of ground
GoombaWalk gWalk = new GoombaWalk(star, pGoomba, ground);    // inputs star, goomba, and ground object for animation
Console.Clear();
// for(int i = 0; i < 2; i++){
//     gWalk.StartAnimation();
// }
gWalk.StartAnimation();
// GoombaWalk gWalkAni = new GoombaWalk(star, pGoomba, ground);
// pGoomba.DrawSprite();
