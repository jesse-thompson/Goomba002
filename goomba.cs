// a class to create and animate the goomba based on calls in Program.cs
class Goomba{
    private int posX;
    private int speed;
    protected string[] goombaSprite;
    private bool direction;

    // constructs Goomba object with speed value as input parameter
    public Goomba(int speed){
        posX = 0;
        this.speed = speed;
        goombaSprite = new string[10];
        SetSprite();
        direction = true;   // if true, move right; if false, move left
    }

    protected virtual void SetSprite(){
    goombaSprite[0] = @"     ________  ";
    goombaSprite[1] = @"    /        \ ";
    goombaSprite[2] = @"   /  \    /  \ ";
    goombaSprite[3] = @"  /   |    |   \ ";
    goombaSprite[4] = @" /  -^------^-  \ ";
    goombaSprite[5] = @"|________________| ";
    goombaSprite[6] = @"      /    \ ";  
    goombaSprite[7] = @" ____|      |____ ";
    goombaSprite[8] = @"/____\ ==== /____\ ";
    goombaSprite[9] = @"                     ";
    }

    // draws the sprite
    public void DrawSprite(){
        string spaces = " ";
        for (int i = 0; i < posX; i++) {
            spaces += " ";
        }
        foreach(string eachLine in goombaSprite) {
            Console.WriteLine(spaces + eachLine);
        }
    }

    // updates position with direction deciding left/right movement
    public void UpdatePos(){
        if(direction) posX += speed;    // move right
        else posX -= speed;             // move left
    }

    // changes direction of the goomba
    public void changeDir(){
        direction = !direction;
    }
}    