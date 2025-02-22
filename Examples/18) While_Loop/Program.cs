
/*
 * The while loop is ideal for situations where the number of iterations depends on a condition evaluated at runtime.

 * while (condition to stop the loop)
 * {
 *      Code to be executed.
 *      Within this code block, there must be a condition or code that stops the loop.
 *      If no mechanism to stop the loop is provided, the loop will enter an infinite loop and may suspend the program.
 * }

 * While döngüsü, yineleme sayısının çalışma zamanında değerlendirilen bir koşula bağlı olduğu durumlar için idealdir.

 * while (döngüyü durduracak koşul)
 * {
 *      Çalıştırılacak kodlar.
 *      Bu kod bloğu içinde, döngüyü durduracak bir koşul veya kod parçası olmalıdır.
 *      Eğer döngüyü durduracak bir mekanizma eklenmez ise, döngü sonsuz döngüye girer ve programı askıya alabilir.
 * }
 */

/*
 * Example 1:
 * Example of creating an infinite loop with a boolean value.

 * 1. Örnek
 * Boolean değer ile sonsuz döngü kurma örneği.
 */

/*
while (true)
{
    Console.WriteLine("This is an infinite loop.");
}
*/

/*
 * Example 2:
 * Example of creating an infinite loop due to the absence of a mechanism to stop the loop.

 * 2. Örnek
 * Döngüyü durduracak mekanızmanın eklenmemesi sonucu sonsuz döngü kurma örneği.
 */

/*
int counter = 10;
while (counter > 0)
{
    Console.WriteLine(counter);
}
*/

/*
 * Example 3:
 * Numbers from 10 to 0.
 * The most suitable loop type for this operation is the for loop.

 * 3. Örnek:
 * 10'dan 0'a kadar olan sayılar.
 * Bu işlem için en uygun döngü tipi for döngüsüdür.
 */

int counter = 10;
while (counter > 0)
{
    Console.WriteLine(counter);
    /*
     * This line of code is the loop stopping mechanism.
     * It decreases the value of the counter variable at each step to ensure the condition is met.

     * Bu kod satırı, döngü durdurma mekanızmasıdır.
     * Sayaç değişkeninin değerini her adımda azaltarak koşulun karşılanmasını sağlar.
     */
    counter--;
}

Console.WriteLine();

/*
 * Example 4:
 * Example of validating that the user has entered an integer.
 
 * 4. Örnek:
 * Kullanıcının bir tam sayı girdiğini doğrulama örneği.
 */

string input = "";
int number = 0;

/*
 * The int.TryParse() method returns 'true' when an integer is entered by the user.
 * If the user does not enter an integer, it returns 'false'.

 * int.TryParse() metodu, kullanıcı bir tam sayı girdiğinde 'true' değeri döner.
 * Eğer kullanıcı bir tam sayı girmezse, 'false' değeri döner.
 */

while (int.TryParse(input, out number) == false)
{
    Console.Write("Enter a whole number: ");
    input = Console.ReadLine();
}

/*
 * Example 5:
 * Example of a calculator that runs until the 'X' value is entered.

 * 5. Örnek:
 * 'X' değeri girilene kadar çalışan hesap makinesi örneği.
 */

while (true)
{
    Console.Clear();

    char character = '\0';
    int numberOne = 0;
    int numberTwo = 0;

    input = "";

    while (int.TryParse(input, out numberOne) == false)
    {
        Console.Write("Enter the first number: ");
        input = Console.ReadLine();
    }

    Console.WriteLine();
    input = "";

    while (int.TryParse(input, out numberTwo) == false)
    {
        Console.Write("Enter the second number: ");
        input = Console.ReadLine();
    }

    Console.WriteLine();
    input = "";

    Console.WriteLine("1) +");
    Console.WriteLine("2) -");
    Console.WriteLine("3) *");
    Console.WriteLine("4) /");
    Console.WriteLine("5) %");
    Console.WriteLine("X (Exit)");

    while (char.TryParse(input, out character) == false)
    {
        Console.Write("Enter your choice: ");
        input = Console.ReadLine();
    }

    /*
     * The "break" keyword is used to immediately stop the execution of loops.
     * The loop is terminated instantly with the "break" statement, even if the condition is met or no other action is performed.

     * "break" anahtar kelimesi, döngülerin çalışmasını anında durdurmak için kullanılır.
     * Döngü, koşul sağlansa da veya başka bir işlem yapılmasa da, "break" komutuyla derhal sonlanır.
     */
    if (character == 'X' || character == 'x')
        break;

    switch (character)
    {
        case '1':
            Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
            break;
        case '2':
            Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
            break;
        case '3':
            Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
            break;
        case '4':
            if (numberTwo == 0)
                Console.WriteLine("Dividing a number by zero is mathematically undefined.");
            else
                Console.WriteLine($"{numberOne} / {numberTwo} = {numberOne / numberTwo}");
            break;
        case '5':
            Console.WriteLine($"{numberOne} % {numberTwo} = {numberOne % numberTwo}");
            break;
        default:
            Console.WriteLine("Unknown operation.");
            break;
    }

    Thread.Sleep(1000);
}

Console.Clear();

/*
 * Example 6:
 * Number guessing game example.

 * 6. Örnek:
 * Sayı tahmin etme oyunu örneği.
 */

int computerNumber = new Random().Next(1, 101);
int userNumber = 0;
int answerCounter = 0;

while (true)
{
    input = "";
    answerCounter++;

    while (int.TryParse(input, out userNumber) == false)
    {
        Console.Write("Enter a whole number between 0 and 100: ");
        input = Console.ReadLine();
    }

    if (userNumber < computerNumber)
    {
        Console.WriteLine("The number you entered is smaller than the specified number.");
    }

    else if (userNumber > computerNumber)
    {
        Console.WriteLine("The number you entered is greater than the specified number.");
    }

    else
    {
        Console.WriteLine($"Congratulations. You guessed it in {answerCounter} attempts.");
        break;
    }

    Console.WriteLine();
}

Console.ReadKey();
