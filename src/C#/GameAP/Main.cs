

class Entry
{

    static Player player1;
    static Player player2;
    static char[] horizontalStripe = new char[10] { '|', '|', '|', '|', '|', '|', '|', '|', '|', '|' };
    static List<char[]> stripeCollection = new List<char[]>();
    static bool playerOneTurn = true;




    static void Display()
    {
            char[] player2Line = new char[10] { '|', '|', '|', '|', '|', '|', '|', '|', '|', '|' };
            char[] player1Line = new char[10] { '|', '|', '|', '|', '|', '|', '|', '|', '|', '|' };
            char[] sameLine = new char[10] { '|', '|', '|', '|', '|', '|', '|', '|', '|', '|' };
        bool sameY = player1.y == player2.y ? true:false;
        

        for (int i = 0; i < stripeCollection.Count; i++)
        {
            
            
            if (i == player1.y)
            {

                for (int j = 0; j < 10; j++)
                {

                    if (j == player1.x)
                    {
                        player1Line[j] = player1.symbol;
                        sameLine[j] = player1.symbol;
                    }
                }
            }
            if (i == player2.y)
            {

                for (int j = 0; j < 10; j++)
                {

                    if (j == player2.x)
                    {
                        player2Line[j] = player2.symbol;
                        sameLine[j] = player2.symbol;
                    }
                }
            }
        

            if (i == player2.y && !sameY)
            {
                string playerWhole = new string(player2Line);
                Console.WriteLine(playerWhole);
            }
            else if (i == player1.y && !sameY)
            {
                string playerWhole = new string(player1Line);
                Console.WriteLine(playerWhole);
            }else if ( i == player1.y && sameY)
            {
                string playerWhole = new string(sameLine);
                Console.WriteLine(playerWhole);
            }
            else
            {
                string wholeLine = new string(stripeCollection[i]);

                Console.WriteLine(wholeLine);
            }
        }
        //Console.WriteLine(player1.x +" " + player1.y);
        //Console.WriteLine(player2.x +" " + player2.y);
        if (playerOneTurn)
        {
            Player1Move();
        }
        else
        {
            Player2Move();
        }
    }


    static void EntryWelcome()
    {


        for (int i = 0; i < 10; i++)
        {
            stripeCollection.Add(horizontalStripe);
        }


        Console.WriteLine("Choose Player1 name");
        string name = Console.ReadLine() ?? string.Empty;
        if (name == String.Empty)
        {
            name = "Player1";
        }
        player1.SetName(name);
       CharacterSelect(player1);
        // Put character select

        Console.WriteLine("Choose Player2 name");
        name = Console.ReadLine() ?? string.Empty;
        if (name == String.Empty)
        {
            name = "Player2";
        }
        player2.SetName(name);
        CharacterSelect(player2);

        if(player1.symbol == player2.symbol)
        {
            //Check this if it doesn't work
            if(player2 is Wizard)
            {
               player2.symbol = '!' ;
            }else if (player2 is Knight)
            {
                player2.symbol = '@' ;
            }else if (player2 is Archer)
            {
                player2.symbol = '$' ;
            }
        }
        Console.WriteLine(player1.name + " = " + player1.symbol);
        Console.WriteLine(player2.name + " = " + player2.symbol);

    }
    static void Player1Move()
    {
        
        if(player1.Move(Console.ReadLine() ?? string.Empty,player2) == false)
        {
            Player1Move();
            return;
        } 
        playerOneTurn = false;
        
        Display();
        
    }
    static void Player2Move()
    {
        if(player2.Move(Console.ReadLine() ?? string.Empty,player1) == false)
        {
            Player2Move();
            return;
        }
        playerOneTurn = true;
        
        Display();
        
    }

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
    static void CharacterSelect(Player selectedPlayer)
    {
        Console.WriteLine("Select Character");
        Console.WriteLine("Wizard, Knight, or Archer");
        string character = Console.ReadLine() ?? wizard;  
        if(character == "wizard" || character == "Wizard" || character == "w")
        {
            selectedPlayer = new Wizard();
            selectedPlayer.symbol = '&'; 
        }else if (character == "knight" || character == "Knight" || character == "k")
        {
            selectedPlayer = new Knight();
            selectedPlayer.symbol = '#';
        }else if (character == "archer" || character == "Archer" || character == "a")
        {
            selectedPlayer = new Archer();
            selectedPlayer.symbol = '%';
        }
    }
    static void Main(string[] args)
    {
           // player1.SpecailMove("YIPPEE");
        Console.WriteLine("Welcome To 2 Player Game");
        EntryWelcome();
        
        Display();

    }

}
