
/*
 * Create a simple C# calculator program that performs basic arithmetic operations (+, -, *, /) based on user input.
 * The program should:
 * 1) Prompt the user to enter two numbers.
 * 2) Prompt the user to choose an arithmetic operation (Addition, Subtraction, Multiplication, Division).
 * 3) Use conditional statements to perform the selected operation.
 * 4) Print the result of the operation to the console.
 * 5) Handle division by zero with a specific message.

 * Alert!
 * The program should correctly handle and display the results of the operations, as well as handle invalid operations and division by zero.

 * EXTRA INFO!
 * What does the Test Code Expect?
 * The test code verifies that your calculator program handles specific scenarios correctly.
 * Here are the details:

 * Addition Test:
 * Input: 5, 3, +
 * Expected Output:
 * Enter the first number:
 * Enter the second number:
 * Choose an operation: +, -, *, /
 * Result: 8

 * Division by Zero Test:
 * Input: 5, 0, /
 * Expected Output:
 * Enter the first number:
 * Enter the second number:
 * Choose an operation: +, -, *, /
 * Error: Division by zero is not allowed.

 * Invalid Operation Test:
 * Input: 5, 3, %
 * Expected Output:
 * Enter the first number:
 * Enter the second number:
 * Choose an operation: +, -, *, /
 * Invalid operation. Please choose +, -, *, or /.
 */

int myNumberOne = 0;
int myNumberTwo = 0;
string input = "";

Console.WriteLine("Enter the first number:");
input = Console.ReadLine();

int.TryParse(input, out myNumberOne);

Console.WriteLine("Enter the second number:");
input = Console.ReadLine();

int.TryParse(input, out myNumberTwo);

Console.WriteLine("Choose an operation: +, -, *, /");
input = Console.ReadLine();

char operation;
char.TryParse(input, out operation);

switch (operation)
{
    case '+':
        Console.WriteLine($"Result: {myNumberOne + myNumberTwo}");
        break;
    case '-':
        Console.WriteLine($"Result: {myNumberOne - myNumberTwo}");
        break;
    case '*':
        Console.WriteLine($"Result: {myNumberOne * myNumberTwo}");
        break;
    case '/':
        if (myNumberTwo == 0)
            Console.WriteLine("Error: Division by zero is not allowed.");
        else
            Console.WriteLine($"Result: {myNumberOne / myNumberTwo}");
        break;
    default:
        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
        break;
}

Console.ReadKey();
