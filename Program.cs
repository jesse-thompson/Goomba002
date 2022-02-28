// See https://aka.ms/new-console-template for more information
Star star = new Star(15);
Goomba goomba = new Goomba(7);      // value for speed
Ground ground = new Ground(120);    // value for size of ground
GoombaWalk gWalk = new GoombaWalk(star, goomba, ground);    // inputs star, goomba, and ground object for animation
Console.Clear();
for(int i = 0; i < 2; i++){
    gWalk.StartAnimation();
}
gWalk.StartAnimation();
