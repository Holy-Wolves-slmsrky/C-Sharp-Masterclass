
/*
 * Create a simple C# program using a switch statement to replace an if-else structure for printing days of the week based on an integer value.
 * The result of execution for the default string should be:
 * "Wednesday"
 */

int day = 3;

/*
 * if (day == 1)
 *    Console.WriteLine("Monday");
 * else if (day == 2)
 *    Console.WriteLine("Tuesday");
 * else if (day == 3)
 *    Console.WriteLine("Wednesday");
 * else
 *    Console.WriteLine("Another day");
 */

// TODO: Rewrite this if-else structure using a switch statement.
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    default:
        Console.WriteLine("Another day");
        break;
}

Console.ReadKey();
