

class Entry
{

    static Player player1 = new Player();
    static Player player2 = new Player();
    static char[] horizontalStripe = new char[10] { '|', '|', '|', '|', '|', '|', '|', '|', '|', '|' };
    static List<char[]> stripeCollection = new List<char[]>();
    static bool playerOneTurn = true;




    static void Display()
    {

        for (int i = 0; i < stripeCollection.Count; i++)
        {
            char[] player2Line = new char[10] { '|', '|', '|', '|', '|', '|', '|', '|', '|', '|' };
            char[] player1Line = new char[10] { '|', '|', '|', '|', '|', '|', '|', '|', '|', '|' };
            if (i == player1.y)
            {

                for (int j = 0; j < 10; j++)
                {

                    if (j == player1.x)
                    {
                        player1Line[j] = '@';
                    }
                }
            }
            if (i == player2.y)
            {

                for (int j = 0; j < 10; j++)
                {

                    if (j == player2.x)
                    {
                        player2Line[j] = '*';
                    }
                }
            }


            if (i == player2.y)
            {
                string playerWhole = new string(player2Line);
                Console.WriteLine(playerWhole);
            }
            else if (i == player1.y)
            {
                string playerWhole = new string(player1Line);
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

        Console.WriteLine("Choose Player2 name");
        name = Console.ReadLine() ?? string.Empty;
        if (name == String.Empty)
        {
            name = "Player2";
        }
        player2.SetName(name);


    }
    static void Player1Move()
    {
        player1.Move(Console.ReadLine() ?? string.Empty);
        playerOneTurn = false;
        DamageCheck(true);
        Display();
    }
    static void Player2Move()
    {
        player1.Move(Console.ReadLine() ?? string.Empty);
        playerOneTurn = true;
        DamageCheck(false);
        Display();

    }

    static void DamageCheck(bool isPlayerOne)
    {
        if (!isPlayerOne)
        {

            if (player2.x == player1.x && player2.y == player1.y)
            {
                player1.TakeDamage(1);
                if (player1.DeathCheck)
                {
                    Console.WriteLine(player2.name + " " + "has won");
                    Environment.Exit(0);

                }
                Random rnd = new Random();
                player1.x = rnd.Next(0, 10);
                player1.y = rnd.Next(0, 10);
                Console.WriteLine(player1.HealthDisplay());
            }
        }
        else if (isPlayerOne)
        {
            if (player1.x == player2.x && player1.y == player2.y)
            {
                player2.TakeDamage(1);
                if (player2.DeathCheck)
                {
                    Console.WriteLine(player1.name + " " + "has won");
                    Environment.Exit(0);


                }
                Console.WriteLine(player2.HealthDisplay());
                Random rnd = new Random();
                player2.x = rnd.Next(0, 10);
                player2.y = rnd.Next(0, 10);

            }
        }
    }
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome To 2 Player Game");
        EntryWelcome();
        Display();

    }

}
