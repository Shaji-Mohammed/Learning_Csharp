// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number (0-6): ");
        Console.WriteLine(getDay(Convert.ToInt32(Console.ReadLine())));
    }

    static string getDay(int dayNum)
    {
        string day;

        switch (dayNum)
        {
            case 0:
                day = "Sunday";
                break;
            case 1:
                day = "Monday";
                break;
            case 2:
                day = "Tuesday";
                break;
            case 3:
                day = "Wednesday";
                break;
            case 4:
                day = "Thursday";
                break;
            case 5:
                day = "Friday";
                break;
            case 6:
                day = "Saturday";
                break;
            default:
                day = "Invalid day number";
                break;
        }

        return day;
    }
}
