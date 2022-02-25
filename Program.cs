// See https://aka.ms/new-console-template for more information
Star star = new Star(15);
star.DrawSprite();

Ground ground = new Ground(120);
ground.DrawSprite();

Goomba goomba = new Goomba(4);
for( int i = 0; i < 10; i++){
    goomba.DrawSprite();
    goomba.UpdatePos();
}
