class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess you favourite Footballers Team.");
        string[] names = { "Messi", "Ronaldo", "Neymar" };
        string guess = "";
        int numOfGuesses = 2;
        bool correctAns = false;

        Console.WriteLine("Select you favourite player: ");
        for (int i =0; i <=2; i++)
        {
            Console.Write(names[i]+ "\t");
        }
        
        string player = Console.ReadLine();
        while (numOfGuesses >= 0 && !correctAns)
        {
            if (player == names[0])
            {
                Console.Write("Guess the team: ");
                guess = Console.ReadLine();
                if (guess == "Inter Miami")
                {
                    correctAns = true;   
                }
            } else if (player == names[1])
            {
                Console.Write("Guess the team: ");
                guess = Console.ReadLine();
                if (guess == "Al Nasr")
                {
                    correctAns = true;
                }
            } else 
            {
                Console.Write("Guess the team: ");
                guess = Console.ReadLine();
                if (guess == "PSG")
                {
                    correctAns = true;
                }
            }
            numOfGuesses--;

        }
        if (correctAns)
        {
            Console.WriteLine("You win 5 Schrute bucks!!!!");
        } else
        {
            Console.WriteLine("You can try again....");
        }
    }
}