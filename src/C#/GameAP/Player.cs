public class Player
{
     private int health =5;
    public int x,y;

    public string name = "Player"; 

    public char symbol;
    

    public Player() 
    {
        Random rnd = new Random();
        health = 5;
        x = rnd.Next(0,10);
        y = rnd.Next(0,10);
       
    }
 public void TakeDamage(int amount)
 {
    health = health - amount;
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
    // public void DamageCheck(Player otherPlayer)
    // {
    //      if (otherPlayer.x == x && otherPlayer.y == y)
    //         {
    //             otherPlayer.TakeDamage(1);
    //             if (otherPlayer.DeathCheck())
    //             {
    //                 Console.WriteLine(name + " " + "has won");
    //                 Environment.Exit(0);

    //             }
    //             Random rnd = new Random();
    //             otherPlayer.x = rnd.Next(0, 10);
    //             otherPlayer.y = rnd.Next(0, 10);
    //             Console.WriteLine(otherPlayer.name +"'s"+ " " + "health " + otherPlayer.HealthDisplay());
    //         }
    // }
public int HealthDisplay()
{
return health;
}
public void SetName(string setName)
    {
        name = setName;
    }

public bool Input(string input,List <Player> otherPlayers, int selfIndex)
    {
        
        
       
      

        if(input == "a" || input == "A")
        {
            x -= 1;
            if(x< 0)
            {
                x =9;
            }
        }else if (input == "d" || input == "D")
        {
            x += 1;
            if(x > 9)
            {
                x =0;
            }
        }else if (input == "w" || input == "W")
        {
            y -= 1;
            if(y < 0)
            {
                y =9;
            }
        }else if (input == "s" || input == "S")
        {
            y += 1;
            if(y > 9)
            {
                y =0;
            }
        }
        else 
        {
        
        return false;  
        }
       // CollisionCheck(otherPlayers);
      
     
      otherPlayers.RemoveAt(selfIndex);
     CollisionCheck(otherPlayers);
     return true;
        
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
    private void CollisionCheck(List<Player> otherPlayers)
    {
          for(int i = 0; i<otherPlayers.Count; i++)
        {
           Player otherPlayer = otherPlayers[i];  
        if(otherPlayer.x == x && otherPlayer.y == y)
            {
                otherPlayer.TakeDamage(1);
                Random rnd = new Random();
            otherPlayer.x = rnd.Next(0,10);
            otherPlayer.y = rnd.Next(0,10);
               
            }

        }
         otherPlayers.Insert(selfIndex,this);
    }
    public virtual void SpecailMove(string input)
    {

    }
}
