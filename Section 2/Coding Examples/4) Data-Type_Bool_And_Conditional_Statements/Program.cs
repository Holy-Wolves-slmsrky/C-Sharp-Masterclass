
/*
 * Create a simple C# program that uses a boolean variable to store whether a user is logged in and prints different messages based on the value.
 * The final output must be "Welcome back!".

 * bool isLoggedIn;
 * if (isLoggedIn)
 * {
 *     Console.WriteLine("Welcome back!");
 * }
 * else
 * {
 *     Console.WriteLine("Please log in.");
 * }
 */

bool isLoggedIn;

isLoggedIn = true;

if (isLoggedIn)
{
    Console.WriteLine("Welcome back!");
}
else
{
    Console.WriteLine("Please log in.");
}

Console.ReadKey();
