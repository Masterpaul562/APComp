using System; 


private class Main 
{

private Player player1;
private Player palyer2; 
private char[] horizontalStripes= new char[10]{|,|,|,|,|,|,|,|,|,|};;
private List<char> stripeCollection = new List<char>(); 

public Main()
 {
     
        for(i=0;i<10;i++)
        {
            stripeCollection.Add(horizontalStripes);
        }
}

private void Display()
{
for(i=0; i <stripeCollection.Count; i++)
{
    for(j=0; i < horizontalStripes.Size; i++)
    {
        Console.WriteLine( horizontalStripes[i]);
    }

}

}

}
