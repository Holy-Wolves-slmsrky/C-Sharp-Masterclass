
/*
 * Create a simple C# program that initializes a 3x3 two-dimensional array with integers, calculates the sum of each row, and prints the sums to the console.

 * The program should:

 * 1) Declare and initialize a 3x3 two-dimensional array with the following values:
 * 1 2 3
 * 4 5 6
 * 7 8 9

 * 2) Calculate the sum of each row in the array.

 * 3) Print the sum of each row to the console.

 * The result of execution for the default string should be:
 * 6
 * 15
 * 24
 */

// TODO
int[,] array =
{
    { 1, 2, 3},
    { 4, 5, 6},
    { 7, 8, 9}
};

int sum;

for (int firstCounter = 0; firstCounter < 3; firstCounter++)
{
    sum = 0;
    for (int secondCounter = 0; secondCounter < 3; secondCounter++)
    {
        sum += array[firstCounter, secondCounter];
    }
    Console.WriteLine(sum);
}

Console.ReadKey();
