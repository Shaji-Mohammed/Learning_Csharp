class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a noun: ");
        string noun = Console.ReadLine();
        

        Console.Write("Enter a pluralNoun : ");
        string pluralNoun = Console.ReadLine();

        Console.Write("Enter a verb: ");
        string verb = Console.ReadLine();

        Console.Write("Enter a another verb: ");
        string verb2 = Console.ReadLine();

        Console.Write("Enter a Part of body: ");
        string partBody= Console.ReadLine();

        Console.Write("Enter a adjective: ");
        string adjective = Console.ReadLine();

        Console.Write("Enter another plural noun: ");
        string pluralNoun2 = Console.ReadLine();

        Console.WriteLine("Today, every student has a computer small enough to fit into his " + noun);
        Console.WriteLine(". He can solve any math problem by simply pushing the computer's little " + pluralNoun);
        Console.WriteLine(". Computers can add, multiply, divide and " + verb + ". They can also " + verb2);
        Console.WriteLine(" better than a human. Some computers are " + partBody);
        Console.WriteLine(". Others have a/an " +adjective+" screen that shows all kinds of "+pluralNoun2+ ".");
    }
}
