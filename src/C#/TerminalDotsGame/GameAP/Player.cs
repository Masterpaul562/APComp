public class Player
{
     private int health =5;
    public int x,y;
    private int score = 0;
    public string name = "Player"; 
    

    public Player() 
    {
        Random rnd = new Random();
        health = 10;
        x = rnd.Next(0,10);
        y = rnd.Next(0,10);
       
    }
 public void TakeDamage(int amount)
 {
    health =- amount;
 }

public bool DeathCheck()
{
    if(health == 0)
    {
    return true;
    }
    else{
        return false;
    }
}
public int HealthDisplay()
{
return health;
}
public void SetName(string setName)
    {
        name = setName;
    }

public void Move(string dir)
    {
        Console.WriteLine(x +" " + y);
        //playerOneTurn = false;
        Console.WriteLine(name + "'s" + " "+ "Turn");
        Console.WriteLine("Pick a direction");        
        if(dir == "a" || dir == "A")
        {
            x -= 1;
            if(x< 0)
            {
                x =9;
            }
        }else if (dir == "d" || dir == "D")
        {
            x += 1;
            if(x > 9)
            {
                x =0;
            }
        }else if (dir == "w" || dir == "W")
        {
            y -= 1;
            if(y < 0)
            {
                y =9;
            }
        }else if (dir == "s" || dir == "S")
        {
            y += 1;
            if(y > 9)
            {
                y =0;
            }
        }else
        {
            Move(dir);
        }
        Console.WriteLine(x +" " + y);
        // if(player1.x == player2.x && player1.y == player2.y)
        // {
        //     player2.TakeDamage(1);
        //     if(player2.DeathCheck)
        //     {
        //         Console.WriteLine(player1.name + " " +"has won");
        //        Environment.Exit(0);
             
               
        //     }
        //     Console.WriteLine(player2.HealthDisplay());
        //     Random rnd = new Random();
        //     player2.x = rnd.Next(0,10);
        //     player2.y = rnd.Next(0,10);
            
        // }
    }
}
