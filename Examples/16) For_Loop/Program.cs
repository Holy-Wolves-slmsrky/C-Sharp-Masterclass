
/*
 * The for loop is ideal for equations that follow a specific pattern.

 * for (initial value; condition to stop the loop; increment - decrement value)
 * {
 *     Code to be executed.
 * }

 * For döngüsü, belirli bir örüntüyü takip eden denklemler için idealdir.

 * for (başlangıç değeri; döngüyü durduracak koşul; arttırma - azaltma değeri)
 * {
 *     Çalıştırılacak kodlar.
 * }
 */

/*
 * Example 1:
 * The even numbers from the user input to 100.

 * 1. Örnek:
 * Kullanıcının girdiği sayıdan, 100'e kadar olan çift sayılar.
 */

string userInput = "";
int userNumber = 0;

Console.Write("Enter a whole number: ");
userInput = Console.ReadLine();

int.TryParse(userInput, out userNumber);

Console.WriteLine($"Entered number: {userNumber}\n");

if (userNumber < 100)
{
    Console.WriteLine($"Even numbers between {userNumber} and 100:");

    userNumber = userNumber % 2 == 0 ? userNumber : ++userNumber;

    for (int counter = userNumber; counter < 101; counter += 2)
    {
        Console.WriteLine(counter);
    }
}

Console.WriteLine();

/*
 * Example 2:
 * The numbers from 200 to 10 that satisfy the equation "2x - 30 = 24 ~ (multiples of 24)."

 * 2. Örnek:
 * 200'den 10'a kadar olan, "2x - 30 = 24 ~ (24'ün katları)" denklemini sağlayan sayılar.
 */

for (int counter = 200; counter >= 10; counter--)
{
    if (((2 * counter) - 30) % 24 == 0)
    {
        Console.WriteLine(counter);
    }
}

/*
 * Example 3:
 * Infinite loop.

 * 3. Örnek:
 * Sonsuz döngü.
 */

//for ( ; ; )
//{
//    Console.WriteLine("This is an infinite loop.");
//}

Console.ReadKey();
