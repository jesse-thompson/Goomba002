class Goomba{
    private int posX;
    private int speed;
    private string[] goombaSprite;
    public Goomba(int speed){
        posX = 0;
        this.speed = speed;
        goombaSprite = new string[10];
        SetSprite();
    }

    private void SetSprite(){
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

    public void DrawSprite(){
        string spaces = " ";
        for (int i = 0; i < posX; i++) {
            spaces += " ";
        }
        foreach(string eachLine in goombaSprite) {
            Console.WriteLine(spaces + eachLine);
        }
    }

    public void UpdatePos(){
        posX += speed;
    }
}    