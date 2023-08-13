using ClassesAndObjects;

class Program
{
    static void Main(string[] args)
    {
        Movies tenet = new Movies("Tenet", "C. Nolan", 9, "PG");
        Movies bladeRunner = new Movies("Blade Runner", "R. Scott", 8.5, "PG-13");

        tenet.Ratings = "R";
        Console.WriteLine(tenet.Ratings);

    }
}