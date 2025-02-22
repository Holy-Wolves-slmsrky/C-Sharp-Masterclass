
/*
 * Create a simple C# program that declares an array of integers, initializes it with values, and uses a foreach loop to print each value to the console.
 * The result of execution for each default value should be printed on new lines as:
 * 1
 * 2
 * 3
 * 4
 * 5
 */

// Initialize array and print each number using a foreach loop
int[] numbers = new int[5];

for (int counter = 0; counter < numbers.Length; counter++)
{
    numbers[counter] = counter + 1;
}

foreach (int item in numbers)
{
    Console.WriteLine(item);
}

Console.ReadKey();
