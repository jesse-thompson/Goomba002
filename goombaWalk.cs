class GoombaWalk{
    private Star star;
    private Goomba goomba;
    private Ground ground;

    // creates a GoombaWalk object
    public GoombaWalk(Star star, Goomba goomba, Ground ground){
        this.star = star;
        this.goomba = goomba;
        this.ground = ground;
    }

    public void DrawFrame(){
        star.DrawSprite();
        goomba.DrawSprite();
        ground.DrawSprite();
    }


    public void StartAnimation(){
        for( int i = 0; i < 10; i++){    // i < (total times posX change)
            DrawFrame();
            goomba.UpdatePos();
        }

        // posX will show as 8, but will update to value of 12, so next run will show at 12
        // this leads to a change direction starting at 12 isntead of 8
        // to prevent this isue, 

        // change direction of goomba; true = walk to right, false = left
        goomba.changeDir(); // changes between true and false
        goomba.UpdatePos(); // updates posX to prevent drawing in wrong pos on first DrawSprite()
        for( int i = 0; i < 10; i++){    // i < (total times posX change)
            DrawFrame();
            goomba.UpdatePos();
        }
    }
}