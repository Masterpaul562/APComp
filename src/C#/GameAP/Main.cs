

class Entry
{

    static List <Player> players = new List<Player>();
   static int turnNumber;





    static void Display()
    {
        
        List<char[]> stripeCollection = new List<char[]>();

           for (int i = 0; i < 10; i++)
        {
            stripeCollection.Add( new char[10] { '|', '|', '|', '|', '|', '|', '|', '|', '|', '|' });
        }  
        
       // bool sameY = true;
            for(int t = 0; t < players.Count; t++)
           {
                Player player = players[t];
                stripeCollection[player.y][player.x] = player.symbol;
                Console.WriteLine("Position: " + player.x + " " + player.y);
                
           }
            
        for (int i = 0; i < stripeCollection.Count; i++)
        {
            //  for (int j = 0; j < 10; j++)
            // {
            //     Console.Write(stripeCollection[j][i]);
            // }
            // for(int t = 0; t < players.Count; t++)
            // {
            //     Player player = players[t];
            //     if(player.y == i )
            //     {
            //         for (int j = 0; j < 10; j++)
            //          {

            //                 if (player.x==j )
            //                 {
            //                   
            //                   j= 1000;
                        
            //                  }
            //          }
            //     }
            // }
            
            
             string wholeLine = new string(stripeCollection[i]);

            Console.WriteLine(wholeLine);
        }
        Turn();
    }

        // if (playerOneTurn)
        // {
        //    // Player1Move();
        // }
        // else
        // {
        //    // Player2Move();
        // }
            // if (i == player2.y)
            // {

            //     for (int j = 0; j < 10; j++)
            //     {

            //         if (j == player2.x)
            //         {
            //             player2Line[j] = player2.symbol;
            //             sameLine[j] = player2.symbol;
            //         }
            //     }
            // }
        

            // if (i == player2.y && !sameY)
            // {
            //     string playerWhole = new string(player2Line);
            //     Console.WriteLine(playerWhole);
            // }
            // else if (i == player1.y && !sameY)
            // {
            //     string playerWhole = new string(player1Line);
            //     Console.WriteLine(playerWhole);
            // }else if ( i == player1.y && sameY)
            // {
            //     string playerWhole = new string(sameLine);
            //     Console.WriteLine(playerWhole);
            // }
            // else
            // {
            //     string wholeLine = new string(stripeCollection[i]);

            //     Console.WriteLine(wholeLine);
            // }
     
        //Console.WriteLine(player1.x +" " + player1.y);
        //Console.WriteLine(player2.x +" " + player2.y);
        
    


    static void EntryWelcome()
    {
       

      
            CharacterSelect();
            
        

    }
        // Console.WriteLine("Choose Player1 name");
        // string name = Console.ReadLine() ?? string.Empty;
        // if (name == String.Empty)
        // {
        //     name = "Player1";
        // }
      
        
        // player1.SetName(name);
        
        // // Put character select

        // Console.WriteLine("Choose Player2 name");
        // name = Console.ReadLine() ?? string.Empty;
        // if (name == String.Empty)
        // {
        //     name = "Player2";
        // }
        
        
        // player2.SetName(name);
        

        // if(player1.symbol == player2.symbol)
        // {
        //     //Check this if it doesn't work
        //     if(player2 is Wizard)
        //     {
        //        player2.symbol = '?' ;
        //     }else if (player2 is Knight)
        //     {
        //         player2.symbol = '@' ;
        //     }else if (player2 is Archer)
        //     {
        //         player2.symbol = '$' ;
        //     }
        // }
        // Console.WriteLine(player1.name + " = " + player1.symbol);
        // Console.WriteLine(player2.name + " = " + player2.symbol);

    
    // static void Player1Move()
    // {
        
    //     if(player1.Move(Console.ReadLine() ?? string.Empty,player2) == false)
    //     {
    //         Player1Move();
    //         return;
    //     } 
    //     playerOneTurn = false;
        
    //     Display();
        
    // }
    // static void Player2Move()
    // {
    //     if(player2.Move(Console.ReadLine() ?? string.Empty,player1) == false)
    //     {
    //         Player2Move();
    //         return;
    //     }
    //     playerOneTurn = true;
        
    //     Display();
        
    // }

    // static void DamageCheck(bool isPlayerOne)
    // {
    //     if (!isPlayerOne)
    //     {

           
    //     }
    //     else if (isPlayerOne)
    //     {
    //         if (player1.x == player2.x && player1.y == player2.y)
    //         {
    //             player2.TakeDamage(1);
    //             if (player2.DeathCheck())
    //             {
    //                 Console.WriteLine(player1.name + " " + "has won");
    //                 Environment.Exit(0);


    //             }
    //             Console.WriteLine("player2's health " + player2.HealthDisplay());
    //             Random rnd = new Random();
    //             player2.x = rnd.Next(0, 10);
    //             player2.y = rnd.Next(0, 10);

    //         }
    //     }
    // }
    static void CharacterSelect()
    {
       for(int i = 0; i < 2; i++)
        {
            Console.WriteLine("Choose Player"+ (i+1) +" name");
            string name = Console.ReadLine() ?? string.Empty;
            if (name == String.Empty)
            {
                name = "Player1";
            }
            
           Console.WriteLine("Select Character");
           Console.WriteLine("Wizard, Knight, or Archer");
            string character = Console.ReadLine() ?? "wizard";  
            if(character == "wizard" || character == "Wizard" || character == "w")
            {
                players.Add(new Wizard());
                players[i].symbol = '+';
                players[i].name = name;
           
             
            }else if (character == "knight" || character == "Knight" || character == "k")
            {
                players.Add(new Knight());
                players[i].symbol = '#';
                players[i].name = name;

             }else if (character == "archer" || character == "Archer" || character == "a")
             {
                players.Add(new Archer());
                players[i].symbol = '$';
                players[i].name = name;
             }else
             {
                
             }
        }
        //Console.WriteLine(players[0].x + " " + players[0].y + " " + players[0] + "YAY");
    }
    static void Turn()
    {
        turnNumber++;
        for(int i = 0; i < players.Count; i++)
        {
            Console.WriteLine(i + "YA" + players.Count);
            Player player = players[i];
             Console.WriteLine(player.name + "'s" + " "+ "Turn");
             Console.WriteLine("Pick a Input"); 
            if (!players[i].Input(Console.ReadLine() ?? string.Empty, players, i))
            {
                Turn();
                return;
            }
            player.SpecialMove(player.name);
        }
       
        DeathCheck();
        if(turnNumber>= players.Count)
        {
            turnNumber = 0;
        Display();
        }
    }

   static void DeathCheck()
    {
        for(int i = 0; i<players.Count; i++)
        {
            Player player = players[i];
            if (player.DeathCheck())
            {
                Console.WriteLine(player.name + " " +"has died");
                players.RemoveAt(i);
            }
        }
        // if(players.Count == 0)
        // {
        //     EndGame();
        // }
    }
     static void EndGame()
    {
        Console.WriteLine(players[0].name + " " + "Has Won"); 
    }
    static void Main(string[] args)
    {
           // player1.SpecailMove("YIPPEE");
        Console.WriteLine("Welcome To 2 Player Game");
        EntryWelcome();
        
        Display();

    }

}
