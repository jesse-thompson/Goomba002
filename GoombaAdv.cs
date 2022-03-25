class GoombaAdv : Goomba{
    private string[] goombaSpriteLeftFoot = new string[10];
    private string[] goombaSpriteRightFoot = new string[10];
    private bool foot = true;
    
    public GoombaAdv(int speed) : base(speed){
    }

    protected override void SetSprite(){
        goombaSpriteLeftFoot[0] = @"     ________  ";
        goombaSpriteLeftFoot[1] = @"    /        \ ";
        goombaSpriteLeftFoot[2] = @"   /  \    /  \ ";
        goombaSpriteLeftFoot[3] = @"  /   |    |   \ ";
        goombaSpriteLeftFoot[4] = @" /  -^------^-  \ ";
        goombaSpriteLeftFoot[5] = @"|________________| ";
        goombaSpriteLeftFoot[6] = @" ____ /    \ ";  
        goombaSpriteLeftFoot[7] = @"/____\      |____ ";
        goombaSpriteLeftFoot[8] = @"       ==== /____\ ";
        goombaSpriteLeftFoot[9] = @"                     ";

        goombaSpriteRightFoot[0] = @"     ________  ";
        goombaSpriteRightFoot[1] = @"    /        \ ";
        goombaSpriteRightFoot[2] = @"   /  \    /  \ ";
        goombaSpriteRightFoot[3] = @"  /   |    |   \ ";
        goombaSpriteRightFoot[4] = @" /  -^------^-  \ ";
        goombaSpriteRightFoot[5] = @"|________________| ";
        goombaSpriteRightFoot[6] = @"      /    \ ____ ";
        goombaSpriteRightFoot[7] = @" ____|      /____\ ";
        goombaSpriteRightFoot[8] = @"/____\ ====         ";
        goombaSpriteRightFoot[9] = @"                     ";
    }

    // draws the sprite
    public override void DrawSprite(){   
        string spaces = " ";
        for (int i = 0; i < posX; i++) {
            spaces += " ";
        }
        if (foot){
            foreach(string eachLine in goombaSpriteLeftFoot){   // draws entire left food goomba
                Console.WriteLine(spaces + eachLine);
            }
            foot = !foot;
        }
        else{
            foreach(string eachLine in goombaSpriteRightFoot){  // draws entire right foot goomba
                Console.WriteLine(spaces + eachLine);
            }
            foot = !foot;
        }
    } 
}
